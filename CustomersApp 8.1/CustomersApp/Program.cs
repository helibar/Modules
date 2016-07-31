using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Program
    {
        static List<Customer> list = new List<Customer>();

        //My Delegate
        internal delegate bool CustomerFilter(Customer cus);

        //Ok, though you should have used IEnumerable with yield.
        //Consider better names for your arguments.
        static ICollection<Customer> GetCustomer(ICollection<Customer> cusc, CustomerFilter cfx)
        {
            List<Customer> filteredList = new List<Customer>();
            foreach (var item in cusc)
            {
                if (cfx(item))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }

        //What about small letters?
        static bool CusLetterAK(Customer cus)
        {
            return (cus.Name[0] >= 'A' && cus.Name[0] <= 'K');
        }

        //What about small letters?
        //you could have implemented this directly in the anonymous method
        static bool CusLetterLZ(Customer cus)
        {
            return (cus.Name[0] >= 'L' && cus.Name[0] <= 'Z');
        }

        //You could have implemented this directly in the lambda
        static bool IdLessThen100(Customer cus)
        {
            return (cus.ID < 100);
        }

        static void Main(string[] args)
        {
            list.Add(new Customer() { Name = "Omri", ID = 123456789, Address = "USA" });
            list.Add(new Customer() { Name = "Lea", ID = 200200200, Address = "Hadera 42" });
            list.Add(new Customer() { Name = "Nitsan", ID = 99, Address = "Hadera" });
            list.Add(new Customer() { Name = "Yuval", ID = 999888777, Address = "Afula" });
            list.Add(new Customer() { Name = "Kler", ID = 0, Address = "Tel Aviv 3" });
            list.Add(new Customer() { Name = "AlOn", ID = 123333780, Address = "Tel Aviv 3" });
            list.Add(new Customer() { Name = "OmrI", ID = 1, Address = "Aoranim" });
            list.Add(new Customer() { Name = "Heli", ID = 100, Address = "Kiryat Ata" });


            Console.WriteLine("Origenal Array:");
            foreach (var cus in list)
            {
                Console.WriteLine("Name: {0}, ID: {1}, Address: {2}", cus.Name, cus.ID, cus.Address);
            }

            // Uses IComparable.CompareTo()
            list.Sort();
            Console.WriteLine("\nSorted Array:");

            //Consider extracting this to another method
            foreach (var cus in list)
            {
                Console.WriteLine("Name: {0}, ID: {1}, Address: {2}", cus.Name, cus.ID, cus.Address);
            }

            //IComparer
            list.Sort(new AnotherCustomerComparer());
            Console.WriteLine("\n Comparer:");
            foreach (var cus in list)
            {
                Console.WriteLine("Name: {0}, ID: {1}, Address: {2}", cus.Name, cus.ID, cus.Address);
            }

            Console.WriteLine("\n Customers name start with the letters A-K:");
            CustomerFilter customerfilter1 = new CustomerFilter(CusLetterAK);
            var cusListAK = GetCustomer(list, customerfilter1);
            foreach (var cus in cusListAK)
            {
                Console.WriteLine("Name: {0}, ID: {1}, Address: {2}", cus.Name, cus.ID, cus.Address);
            }

            Console.WriteLine("\n Customers name start with the letters L - Z:");
            CustomerFilter customerfilter2 = delegate (Customer cus) { return CusLetterLZ(cus); };
            var cusListLZ = GetCustomer(list, customerfilter2);
            foreach (var cus in cusListLZ)
            {
                Console.WriteLine("Name: {0}, ID: {1}, Address: {2}", cus.Name, cus.ID, cus.Address);
            }


            Console.WriteLine("\n Customers ID less then 100:");
            CustomerFilter customerfilter3 = (Customer cus) => IdLessThen100(cus);
            var IdRange = GetCustomer(list, customerfilter3);
            foreach (var cus in IdRange)
            {
                Console.WriteLine("Name: {0}, ID: {1}, Address: {2}", cus.Name, cus.ID, cus.Address);
            }
        }

    }
}
