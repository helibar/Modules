using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    //Nice idea to create a class.
    //Though I would expect the class to accept the string array in a constructor, then to have properties that returns them sorted, reversed, etc...
    public class StringsActions
    {
        //Consider a better name
        //return number of words
        public int WordsNum(string[] words)
        {
            return words.Length;
        }

        //Consider the use of Array.Reverse(words).
        //Consider the use of string.Builder
        //revers the words
        public string Revers(string[] words)
        {
            string s = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                s = s + words[i] + " ";
            }
            return s;
        }

        //Consier the use of String.Builder
        //sort words
        public string Sort(string[] words)
        {
            string str = "";
            Array.Sort(words);
            foreach (string word in words)
            {
                str = str + word + " ";
            }
            return str;
        }
    }
}
