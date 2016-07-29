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

        /**
          What about calling the base method so that the color will be set?
          This class design (Circle: Ellipse) introduces a challenge in how you will manage both of the following:
            1)Change the console color, which only the ellipse can do by invoking base.Display()
            2)Not display the output of Ellipse.Display's override when a Circle.Display is invoked
         */

        public override void Display()
        {
            Console.WriteLine("It's a Circle! Radius is:" + _radius);
        }
    }
}
