using AreaCalculator.Exceptions;

namespace AreaCalculator.Shapes
{
    public class Triangle : AbstractShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        protected override double CalculateAreaInternal()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRectangular()
        {
            try
            {
                ThrowIfInvalid();

                // проверяем что треугольник прямоугольный
                if (SideA * SideA + SideB * SideB == SideC * SideC ||
                    SideA * SideA + SideC * SideC == SideB * SideB ||
                    SideB * SideB + SideC * SideC == SideA * SideA)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Проверка существования треугольника
        /// </summary>
        /// <exception cref="ZeroSideException">У треугольника одна из сторон не больше 0</exception>
        /// <exception cref="InvalidSidesException">У треугольника сумма каких-либо двух сторон не больше третьей</exception>
        private void ThrowIfInvalid()
        {
            // У треугольника должно быть три стороны
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ZeroSideException();
            }

            // У треугольника сумма любых двух сторон должна быть больше третьей
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                throw new InvalidSidesException();
            }
        }
    }
}
