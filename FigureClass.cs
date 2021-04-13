using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class FigureClass
    {
        public double GetCircleArea(double radius)
        {
            var Circle = new Circle(radius);
            Circle.SetArea();
            return Math.Round(Circle.Area, 2);
        }
        public double GetTriangleArea(double a, double b, double c)
        {
            var Triangle = new Triangle(a, b, c);
            Triangle.SetArea();
            return Math.Round(Triangle.Area, 2);
        }
    }
}
