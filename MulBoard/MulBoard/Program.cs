using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 10;
            int col = 10;
            
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    //Console.Write has an overload with format. It was enough to write:
                    //Console.Write("{0, 4", i*j);
                    //Also, consider using the new C# 6 feature - string interpolation. where you can write Console.Write($"{i*j, 4}")
                    Console.Write(String.Format("{0,4}", i*j ));
                }

                Console.WriteLine();
            }
        }
    }
}
