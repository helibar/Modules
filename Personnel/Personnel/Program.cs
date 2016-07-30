using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    class Program
    {
        static List<string> _fileList = new List<string>();

        static void Main(string[] args)
        {
            ReadFile();
            foreach (var line in _fileList)
            {
                Console.WriteLine(line);
            }
        }

        /**Bug: Application crashes because file is not found (consider not using an absolute path when working with files)
         * Which would have been fine since your code is correct. unfortunately you are not handling exceptions at all, which is expected at this point in the course.
         * Consider this:
         * https://msdn.microsoft.com/en-us/library/ms164917.aspx
         */
        static List<string> ReadFile()
        {
            using (StreamReader reader = new StreamReader((@"C:\Users\hassayax\Documents\CodeValue\exercise\10\Personnel\Names.txt")))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _fileList.Add(line); // Add to list.
                }
                return _fileList;
            }
        }
    }
}
