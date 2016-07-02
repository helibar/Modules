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
            Console.WriteLine("Hello "+ userName);
            Console.WriteLine("Enter a number in range 1-10:");
            string input = Console.ReadLine();
            int n = 0;
            string sp = "";
            if (int.TryParse(input, out n) && n>0 && n<11)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(sp + userName);
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
