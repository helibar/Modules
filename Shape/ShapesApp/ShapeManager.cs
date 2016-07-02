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
        
        public void Add(Shape s)
        {
            shapes.Add(s);
        }

        public void DisplayAll()
        {
            foreach (Shape shape in shapes)
            {
                shape.Display();
                Console.WriteLine("Area is: "+shape.Area);
              
            }
        }

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
    }
}
