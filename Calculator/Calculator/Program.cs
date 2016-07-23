using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Nice input validations.
    //Nice UnitTests.
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first number:");
                    double firstN = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    double secondN = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter operator (+,-,* or /) : ");
                    string oper = Console.ReadLine();

                    double res;
                    var calc = new Calc();

                    if (oper == "+")
                    {
                        res = calc.Add(firstN, secondN);
                        Console.WriteLine(res);
                    }
                    else if (oper == "-")
                    {
                        res = calc.Sub(firstN, secondN);
                        Console.WriteLine(res);
                    }
                    else if (oper == "*")
                    {
                        res = calc.Mul(firstN, secondN);
                        Console.WriteLine(res);
                    }
                    else if (oper == "/")
                    {
                        res = calc.Div(firstN, secondN);
                        Console.WriteLine(res);
                    }

                    else
                    {
                        Console.WriteLine("Bad operator");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
           
        }
 

    }
}
