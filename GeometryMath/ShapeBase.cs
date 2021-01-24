using System;

namespace GeometryMath
{
    public abstract class ShapeBase
    {
        public virtual float CalcSquare(params float[] args)
        {
            if (args == null || args.Length == 0)
                throw new ArgumentException("Требуется хотя бы 1 сторона");
            else return Calc(args);
        }

        protected abstract float Calc(params float[] args);
    }
}
