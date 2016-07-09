using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter directory path:");
            var path= Console.ReadLine();
            Console.WriteLine("Please enter string:");
            var str = Console.ReadLine();

            string[] files = Directory.GetFiles(@path, "*" + str + "*");
            Console.WriteLine("Number of files: "+files.Length.ToString());
            foreach (string file in files)
                Console.WriteLine(file+"\n Length: "+file.Length);
        }
    }
}
