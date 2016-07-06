using System;
using ShapeLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ShapeManager();
            StringBuilder sb = new StringBuilder();

            //Create 5 rectabgles
            double w = 1.5;
            double h = 2.5;

            for (int i = 1; i < 3; i++)
            {
                var rectangle = new ShapeLib.Rectangle(w, h);
                Shape s = rectangle;
                manager.Add(s);
                w += i;
                h += i;
            }

            //Create 5 circles
            double radius = 1.5;

            for (int i = 1; i < 2; i++)
            {
                var circle = new ShapeLib.Circle(radius);
                Shape s = circle;
                manager.Add(s);
                radius += i;
            }

            //Create 5 ellipse
            double radius1 = 1.9;
            double radius2 = 7.1;

            for (int i = 0; i < 3; i++)
            {
                var ellipse = new ShapeLib.Ellipse(radius1, radius2);
                Shape s = ellipse;
                manager.Add(s);
                radius1++;
                radius2++;
            }

            manager.DisplayAll();

            manager.Save(sb);
            Console.WriteLine(sb.ToString());

            //Console.WriteLine();
            //manager.Sort();
            ////manager.DisplayAll();

        }
    }
}
