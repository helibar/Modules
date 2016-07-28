using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class Program
    {
        [Key]
        struct keyOfSomething
        {
            public int keyValue;
        }

        static void Main(string[] args)
        {
            var MulDic = new MultiDictionary<keyOfSomething, int>();
            keyOfSomething k;
            k.keyValue = 1;
            MulDic.Add(k, 1);
            k.keyValue = 2;
            MulDic.Add(k, 2);


            //MultiDictionary<keyOfSomething, int>.HasKeyAttribute(1);
            //MulDic.Add(3, 3);

        }
    }
}
