using GeometryMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryMathTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalcSquare_in3_4_5_out6()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var expected = 6;

            var triangle = new Triangle();
            var actual = triangle.CalcSquare(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfRight_in3_4_5_out6()
        {
            var expected = true;

            var triangle = new Triangle(3, 4, 5);
            var actual = triangle.IsRight;

            Assert.AreEqual(expected, actual);
        }
    }
}
