using AreaCalculator.Exceptions;

namespace AreaCalculator.Shapes
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            ThrowIfInvalid();
        }

        protected override double CalculateAreaInternal()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Проверка существования круга
        /// </summary>
        /// <exception cref="ZeroRadiusException">У круга радиус не превышает 0</exception>
        private void ThrowIfInvalid()
        {
            // У треугольника должно быть три стороны
            if (Radius <= 0)
            {
                throw new ZeroRadiusException();
            }
        }
    }
}
