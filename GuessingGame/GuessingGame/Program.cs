using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(1, 101);
           
            int count = 0; //number of guesses
            do
            {
                Console.WriteLine("Guess integer number: ");
                try
                {
                    int guess = int.Parse(Console.ReadLine());

                    if (guess > secret)
                    {
                        Console.WriteLine("Too big");
                        count++;
                    }
                    else if (guess < secret)
                    {
                        Console.WriteLine("Too small");
                        count++;
                    }
                    else //guess=secret
                    {
                        if (count > 7)
                        {
                            Console.WriteLine("You failed");
                        }

                        Console.WriteLine("Number of guesses:" + count);
                        Environment.Exit(1);
                        //break; //end when number is guessed
                    }
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (count <7);
            Console.WriteLine("You failed, number is: "+secret);

        }
    }
}
