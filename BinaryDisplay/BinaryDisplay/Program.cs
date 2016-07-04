using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            var toBin = new Binary();
            try
            {
                Console.WriteLine("Enter positive integer number:");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Not a positive number!");
                }
                else
                {
                    string binary = toBin.Bin(input);
                    int count = toBin.Count(binary);

                    Console.WriteLine("binary num is: {0}",binary);
                    Console.WriteLine("count 1: {0} times",count);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
