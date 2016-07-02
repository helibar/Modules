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

                    Console.Write(String.Format("{0,4}", i*j ));
                }

                Console.WriteLine();
            }
        }
    }
}
