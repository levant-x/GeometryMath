using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryMath
{
    public class Circle : ShapeBase
    {
        protected override float Calc(params float[] args)
        {
            var r = args[0];
            return (float)Math.PI * r * r;
        }
    }
}
