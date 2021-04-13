using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureArea.Test
{
    [TestClass]
    public class FigureClassTests
    {
        [TestMethod]
        public void GetCircleArea_4_5027_returned()
        {
            double x = 4.0;
            double expected = 50.2655;

            FigureClass figure = new FigureClass();
            double actual = figure.GetCircleArea(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTriangleArea_4_29047_returned()
        {
            double a = 2.0;
            double b = 3.0;
            double c = 4.0;
            double expected = 2.9047;

            FigureClass figure = new FigureClass();
            double actual = figure.GetTriangleArea(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
