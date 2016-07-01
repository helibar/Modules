using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        static int[] CalcPrimes(int num1, int num2)
        {
            ArrayList primesList = new ArrayList();
            
            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);

            bool isPrime = true;
            for (int i = min; i < max; i++)
            {
                for (int j = 2; j <= max; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primesList.Add(i);
                }
                isPrime = true; 
           
            }

            int[] intArray = new int[primesList.Count];
            primesList.CopyTo(intArray);
          
            return intArray;


        }       
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first integer number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter sec integer number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int[] primeIntArray = CalcPrimes(num1, num2);
                for (int i = 0; i < primeIntArray.Length; i++)
                {
                    Console.WriteLine(primeIntArray[i].ToString());

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
            
        }
    }
}
