using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What’s your name?");
            string userName = Console.ReadLine();

            //It is better to use string.Format. fortuanatelly, Console.WriteLine does it for us, so it would have been better to write Console.WriteLine("Hello {0}", userName);
            Console.WriteLine("Hello "+ userName);
            Console.WriteLine("Enter a number in range 1-10:");

            string input = Console.ReadLine();

            //please use better variable names.
            //Also, in C# all the variables are initialized in their default values. 0 for ints and null for strings (reference types)
            int n = 0;
            string sp = "";
            if (int.TryParse(input, out n) && n>0 && n<11)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(sp + userName);

                    //Not efficient. Consider the using for StringBuilder.
                    sp += " ";
                }
            }
            else
            {
                Console.WriteLine("Not integer number or not in range.");
            }
        }
    }
}
