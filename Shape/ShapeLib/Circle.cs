using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle : Ellipse
    {
        double _radius;
        public Circle(double radius1) : base(radius1, radius1)
        {
            _radius = radius1;
        }

        public override void Display()
        {
            Console.WriteLine("It's a Circle! Radius is:" + _radius);
        }
    }
}
