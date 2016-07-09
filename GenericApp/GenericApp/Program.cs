using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDictionary<int, string> MulDic = new MultiDictionary<int, string>()
            { { 1, "one" }, { 1, "ich" }, { 2, "two" }, { 3, "three" },{2, "nee" }, {3, "sun" } };

            //Prints Total items in MulDic
            Console.WriteLine("Count: {0}", MulDic.Count);

            //Prints all keys in MulDic
            Console.WriteLine("Keys: ");
            foreach (var key in MulDic.Keys)
            {
                Console.WriteLine(key.ToString());
            }

            //Prints all values in MulDic
            Console.WriteLine("Values: ");
            foreach (var valuesList in MulDic.Values)
            {
                Console.WriteLine(valuesList.ToString());
            }

            //Remove key "2" with it's values and display current count
            if (MulDic.Remove(2))
            {
                Console.WriteLine("Key 2 and it's values has been removed.");
            }
            Console.WriteLine("Count: {0}", MulDic.Count);

            //Add 1, "Uno"
            MulDic.Add(1, "Uno");
            Console.WriteLine("Uno has been added to key 1.");

            //Prints all keys in MulDic
            Console.WriteLine("Keys: ");
            foreach (var key in MulDic.Keys)
            {
                Console.WriteLine(key.ToString());
            }

            //Prints all values in MulDic
            Console.WriteLine("Values: ");
            foreach (var valuesList in MulDic.Values)
            {
                Console.WriteLine(valuesList.ToString());
            }
        }
    }
}
