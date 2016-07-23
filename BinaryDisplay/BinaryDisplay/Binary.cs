using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDisplay
{
    //Good decision to extract this to a new class.
    public class Binary
    {
        //Get int num and return it in bibary
        public string Bin(int input) 
        {
            string binary = Convert.ToString(input, 2);
            return binary;
        }

        //Get binary number as string and return the number of times "1" appear in it.
        public int Count(string binNum)
        {
            int count = 0;
            var c = Convert.ToInt32(binNum, 2);

            do
            {
                var result = (c & 1);
                if (result == 1)
                {
                    count++;
                }
                c >>= 1;


            } while (c != 0);

            return count;
        }
    }
}
