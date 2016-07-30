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
            //You are ignoring the instruction to use command line arguments

            Console.WriteLine("Please enter directory path:");
            var path= Console.ReadLine();
            Console.WriteLine("Please enter string:");
            var str = Console.ReadLine();
            
            //Bug: I could just crash your application by hitting 'Enter' twice
            
            string[] files = Directory.GetFiles(@path, "*" + str + "*");
            Console.WriteLine("Number of files: "+files.Length.ToString());
            foreach (string file in files)//Bug: You were required to display the size of the file, not of its name
                Console.WriteLine(file+"\n Length: "+file.Length);
        }
    }
}
