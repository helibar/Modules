using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            var strEmpty = false;
            var s = new StringsActions();

            while (!strEmpty) //while me string is not empty
            {
                Console.WriteLine("Enter a sentence:");
                string str = Console.ReadLine(); //get new string
                strEmpty = string.IsNullOrEmpty(str); //strEmpty=true if my string is empty

                if (!strEmpty)
                {
                    string[] words = str.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine("Number of words is: " + s.WordsNum(words));

                    Console.WriteLine(s.Revers(words));

                    Console.WriteLine(s.Sort(words));
                }
            }
        }
    }
}
