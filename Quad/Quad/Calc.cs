using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quad
{
    public class Calc
    {
        double x1,x2;

        public string calcQuard(double a, double b, double c)
        {
            if (a == 0)
            {
                //Console.WriteLine("a cannot be zero!");
                return "a cannot be zero!";
            }
            double sqrtpart = (b * b) - (4 * a * c);

            if (sqrtpart > 0)
            {
                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
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
