using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttribDemo
{
    class Program
    {

        static bool isAllRevApproved = true;

        public static void AnalayzeAssembly(Assembly assObj)
        {

            foreach (var type in assObj.GetTypes())
            {
                // Using reflection.
                Attribute[] attrs = Attribute.GetCustomAttributes(type);

                foreach (Attribute attr in attrs)
                {
                    if (attr is CodeReviewAttribute)
                    {
                        CodeReviewAttribute a = (CodeReviewAttribute)attr;
                        System.Console.WriteLine("Reviewer name: {0}, Review date: {1}, Is code approved? {2}", a.RevName, a.RevDate, a.IsApproved);
                        isAllRevApproved = isAllRevApproved && a.IsApproved;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Assembly currentAssem = Assembly.GetExecutingAssembly();

            AnalayzeAssembly(currentAssem);
            if (isAllRevApproved)
            {
                Console.WriteLine("All reviewed types are approved!");
            } 
            else
            {
                Console.WriteLine("Not all reviewed types are approved!");
            }


            //10.	What happens if you pass a reference to some other Assembly to the AnalyzeAssembly method? Try it
            //Nothing will happen since it cannot find CodeReview Attribute.
            Type t = typeof(int);
            Assembly intAssem = Assembly.GetAssembly(t);
            AnalayzeAssembly(intAssem);

        }
    }
}
