using AreaCalculator.Exceptions;

namespace AreaCalculator.Shapes
{
    /// <summary>
    /// Класс для представления круга.
    /// </summary>
    public class Circle : AbstractShape
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Circle"/>.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <exception cref="ZeroRadiusException">У круга радиус не превышает 0.</exception>
        public Circle(double radius)
        {
            Radius = radius;
            ThrowIfInvalid();
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        protected override double CalculateAreaInternal()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Проверяет, существует ли круг.
        /// </summary>
        /// <exception cref="ZeroRadiusException">У круга радиус не превышает 0.</exception>
        private void ThrowIfInvalid()
        {
            if (Radius <= 0)
            {
                throw new ZeroRadiusException();
            }
        }
    }
}
