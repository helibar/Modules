using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quad
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            double a, b, c;

            while (true) //for dbg
            {

                try
                {
                    Console.WriteLine("This program calculate quardratic equation a*x^2 + b*x + c = 0");
                    Console.WriteLine("Enter value for a : ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter value for b : ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter value for c : ");
                    c = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                Console.WriteLine(calc.calcQuard(a,b,c));
                
            }//while

        }
    }
}
