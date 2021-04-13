using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    class Triangle : FigureInterface
    {
        private double a, b, c = 0;
        public double Area { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void SetArea()
        {
            var p = (a + b + c) / 2;
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            this.Area = S;
        }


    }
}
