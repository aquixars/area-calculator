namespace AreaCalculator.Shapes
{
    public class Triangle : AbstractShape
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }

        protected override double CalculateAreaInternal()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public bool IsRightAngled()
        {
            // проверяем что треугольник существует
            if (!IsValid())
            {
                // todo: InvalidShapeException
                throw new Exception();
            }

            // проверяем что треугольник прямоугольный
            if (sideA * sideA + sideB * sideB == sideC * sideC ||
                sideA * sideA + sideC * sideC == sideB * sideB ||
                sideB * sideB + sideC * sideC == sideA * sideA)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка существования треугольника
        /// </summary>
        /// <returns></returns>
        private bool IsValid()
        {
            // У треугольника должно быть три стороны
            if (sideA == 0 || sideB == 0 || sideC == 0)
            {
                return false;
            }

            // У треугольника сумма любых двух сторон должна быть больше третьей
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                return false;
            }

            return true;
        }
    }
}
