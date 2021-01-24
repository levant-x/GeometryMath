using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GeometryMath
{
    public class Triangle : ShapeBase
    {
        protected float[] sides = new float[3];

        public bool IsRight
        {
            get
            {
                // Если стороны инициализированы, то и отсортированы, тогда 3 сторона наибольшая
                var a = sides[0];
                var b = sides[1];
                var c = sides[2];
                return a * a + b * b == c * c;
            }
        }


        public Triangle() { }

        public Triangle(float a, float b, float c)
        {
            sides[0] = a;
            sides[1] = b;
            sides[2] = c;
            OrderSides();
        }


        protected override float Calc(params float[] args)
        {
            if (args.Length < 3)
                throw new ArgumentException("Требуется 3 аргумента!");
            for (int i = 0; i < 3; i++)
                sides[i] = args[i];
            OrderSides();

            var p = sides.Sum() / 2;
            var res = Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
            return (float)res;
        }

        void OrderSides()
        {
            sides = sides.OrderBy(s => s).ToArray();
        }
    }
}
