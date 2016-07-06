using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectangle : Shape, IPersist, IComparable<Rectangle>
    {
        double _width;
        double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area
        {

            get
            {
                return _width * _height;
            }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("It's a Rectabgle! Wigth:" + _width + " Height:" + _height);

        }

        public void Write(StringBuilder sb)
        {
            sb.Append("Width: ").Append(_width).AppendLine();
            sb.Append("Height:").Append(_height).AppendLine();
            sb.AppendLine();
        }

        public int CompareTo(Rectangle other)
        {
            // Alphabetic sort if Width is equal.
            if (this.Width == other.Width)
            {
                return this.Height.CompareTo(other.Height);
            }
            // Default to width sort. [High to low]
            return other.Width.CompareTo(this.Width);
        }
    }
}
