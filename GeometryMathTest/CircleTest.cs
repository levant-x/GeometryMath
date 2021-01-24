using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryMath;
using System;

namespace GeometryMathTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalcSquare_in10_out314()
        {
            var r = 10;
            var expected = Math.PI * 100;

            var circle = new Circle();
            var actual = circle.CalcSquare(r);

            Assert.AreEqual(expected, actual);
        }
    }
}
