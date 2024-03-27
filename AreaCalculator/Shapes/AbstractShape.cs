namespace AreaCalculator.Shapes
{
    /// <summary>
    /// Базовый класс для всех фигур.
    /// </summary>
    public abstract class AbstractShape
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateArea()
        {
            double area = CalculateAreaInternal();
            return area;
        }

        /// <summary>
        /// Внутренний метод вычисления площади конкретной фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        protected abstract double CalculateAreaInternal();
    }
}
