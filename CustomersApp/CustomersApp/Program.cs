using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            list.Add(new Customer() { Name = "Omri", ID = 123456789, Address = "USA" });
            list.Add(new Customer() { Name = "Lea", ID = 200200200, Address = "Hadera 42" });
            list.Add(new Customer() { Name = "Nitsan", ID = 123456789, Address = "Hadera" });
            list.Add(new Customer() { Name = "Yuval", ID = 999888777, Address = "Afula" });
            list.Add(new Customer() { Name = "omri", ID = 123456780, Address = "Tel Aviv 3" });
            list.Add(new Customer() { Name = "AlOn", ID = 123333780, Address = "Tel Aviv 3" });
            list.Add(new Customer() { Name = "OmrI", ID = 123400789, Address = "Aoranim" });


            Console.WriteLine("Origenal Array:");
            foreach (var cus in list)
            {
                Console.WriteLine("Name: {0}, ID: {1}, Address: {2}", cus.Name, cus.ID, cus.Address);
            }

            // Uses IComparable.CompareTo()
            list.Sort();
            Console.WriteLine("\nSorted Array:");
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
        }
    }
}
