using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Ellipse : Shape, IPersist, IComparable<Ellipse>
    {
        double _radius1;
        double _radius2;
        double pie = 3.14;//Consider 'Math.PI' https://msdn.microsoft.com/en-us/library/system.math.pi(v=vs.110).aspx (more accurate)

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

        public void Write(StringBuilder sb)
        {
            sb.Append("Radius1:").Append(_radius1).AppendLine();
            sb.Append("Radius2:").Append(_radius2).AppendLine();
            sb.AppendLine();
        }

        /**
         An incorrect implementation.. according to it, an ellipse is either equal to another, or greater than it - but never lesser
            Also, consider using Area as a sorting parameter
         */
        public int CompareTo(Ellipse el)
        {
            if (this._radius1 == el._radius1 && this._radius2==el._radius2)
            {
                return 0;
            }
            return 1;
        }
    }
}
