using System;
using GeometryMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryMathTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalcSquare_in10_out314()
        {
            var r = 10;
            var delta = 0.0001;
            var expected = Math.PI * 100;

            var circle = new Circle();
            var actual = circle.CalcSquare(r);

            Assert.AreEqual(expected, actual, delta);
        }
    }
}
