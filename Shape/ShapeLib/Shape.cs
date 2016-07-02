using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public abstract class Shape
    {
        ConsoleColor _color;

        public Shape(ConsoleColor color)
        {
            _color = color;
        }

        public Shape()
            : this(ConsoleColor.White)
        {

        }

        public virtual void Display()
        {
            Console.ForegroundColor = _color;
        }

        public abstract double Area {get;}
    }

}
