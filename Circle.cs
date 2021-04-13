using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class Circle : FigureInterface
    {
        private double radius = 0;
        public double Area { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void SetArea()
        {
            this.Area = Math.PI * Math.Pow(radius, 2);
        }
    }
}
