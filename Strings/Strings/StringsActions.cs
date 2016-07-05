using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class StringsActions
    {
        //return number of words
        public int WordsNum(string[] words)
        {
            return words.Length;
        }

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
