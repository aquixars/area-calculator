using AreaCalculator.Exceptions;

namespace AreaCalculator.Shapes
{
    /// <summary>
    /// Класс для представления треугольника.
    /// </summary>
    public class Triangle : AbstractShape
    {
        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Triangle"/>.
        /// </summary>
        /// <param name="sideA">Первая сторона треугольника.</param>
        /// <param name="sideB">Вторая сторона треугольника.</param>
        /// <param name="sideC">Третья сторона треугольника.</param>
        /// <exception cref="InvalidSideException">У треугольника одна из сторон не больше 0.</exception>
        /// <exception cref="InvalidSidesSizeException">У треугольника сумма каких-либо двух сторон не больше третьей.</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            ThrowIfInvalid();
        }

        /// <summary>
        /// Вычисляет площадь треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        protected override double CalculateAreaInternal()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>true, если треугольник прямоугольный, иначе false.</returns>
        /// <exception cref="InvalidSideException">У треугольника одна из сторон не больше 0.</exception>
        /// <exception cref="InvalidSidesSizeException">У треугольника сумма каких-либо двух сторон не больше третьей.</exception>
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
        /// Проверяет, существует ли треугольник.
        /// </summary>
        /// <exception cref="InvalidSideException">У треугольника одна из сторон не больше 0.</exception>
        /// <exception cref="InvalidSidesSizeException">У треугольника сумма каких-либо двух сторон не больше третьей.</exception>
        private void ThrowIfInvalid()
        {
            // У треугольника должно быть три стороны
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new InvalidSideException();
            }

            // У треугольника сумма любых двух сторон должна быть больше третьей
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                throw new InvalidSidesSizeException();
            }
        }
    }
}
