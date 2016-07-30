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

        /*

       No input validation:

       Syntactically, this is correct:

       var color = (ConsoleColor)9999;
       var shape = new MyShape(color);

       This will not throw a runtime exception, despite the fact that there is no such a memeber in the enumeration.
       Consider using Enum.IsDefined
       https://msdn.microsoft.com/en-us/library/system.enum.isdefined(v=vs.110).aspx

       This will enable you to detect invalid instances
       And destroy them before they are used by throwing an exception from within the constructor

     */
        public Shape(ConsoleColor color)
        {
            _color = color;
        }

        //Very good! 
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
