using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    //+1 for using the IComparable<T> - there is also IComparable (without type parameters)
    public class Rectangle : Shape, IPersist, IComparable<Rectangle>
    {
        double _width;
        double _height;

        //You are missing a constructor with a ConsoleColor enumeration parameter

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

        //Did you mean Area?
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
