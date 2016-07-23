using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quad
{
    //Good dicision to extract this logic to a seperate class in a seperate file.
    //Though, it would have been better to add also an interface :)
    public class Calc
    {
        //The convension in C# is to declare each variable in its own line.
        double x1,x2;

        public string calcQuard(double a, double b, double c)
        {
            if (a == 0)
            {
                //It's not a good idea to return strings.
                //Console.WriteLine("a cannot be zero!");
                return "a cannot be zero!";
            }
            double sqrtpart = (b * b) - (4 * a * c);

            if (sqrtpart > 0)
            {
                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);

                //Not a good idea to return such string as the result
                return "x1="+x1+" x2="+x2;
            }
            else if (sqrtpart < 0)
            {
                return "No solutions";
            }
            else //sqrtpart=0
            {
                x1 = (-b) / (2 * a);
                return "x=" + x1;
            }
        }
    }
}
