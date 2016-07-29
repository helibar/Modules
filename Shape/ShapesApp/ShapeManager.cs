using ShapeLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    class ShapeManager
    {
        ArrayList shapes = new ArrayList();
        
        //No input validation
        public void Add(Shape s)
        {
            shapes.Add(s);
        }

        public void DisplayAll()
        {
            foreach (Shape shape in shapes)
            {
                shape.Display();
                Console.WriteLine("Area is: " + shape.Area);
                Console.WriteLine("-----------------------------------------------");

            }
        }

        //Very good!
        public Shape this[int index]
        {
            get
            {
                return shapes[index] as Shape;
            }
        }

        public int count()
        {
            return shapes.Count;
        }

        /**
         * Bug - it is not neccesary that every shape will implement IPersist.
           Consider:
           
            foreach (var persistable in Shapes.OfType<IPersist>())
            {
               persistable.Write(st);
            }

        OfType will select only members which are assignable to an IPersist reference and return such a collection
        https://msdn.microsoft.com/en-us/library/bb360913(v=vs.110).aspx

         */
        public StringBuilder Save(StringBuilder sb)
        {
            foreach (Shape s in shapes)
            {
                IPersist p = (IPersist)s;
                p.Write(sb);
            }
            return sb;
        }
        public void Sort()
        {
            foreach (Rectangle s in shapes)
            {
                shapes.Sort();
            }
            foreach (Ellipse s in shapes)
            {
                shapes.Sort();
            }
        }

        
    }
}
