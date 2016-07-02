using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Ellipse : Shape
    {
        double _radius1;
        double _radius2;
        double pie = 3.14;

        public override double Area
        {
            get
            {
                return _radius1 * _radius2 * pie;
            }
        }
        public Ellipse(double radius1, double radius2)
        {
            _radius1 = radius1;
            _radius2 = radius2;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("It's a Ellipse! Radius1 is:" + _radius1 + " Radius2 is:" + _radius2);

        }
    }
}
