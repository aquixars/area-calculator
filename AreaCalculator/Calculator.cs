using AreaCalculator.Shapes;

namespace AreaCalculator
{
    /// <summary>
    /// Класс для вычисления характеристик фигур.
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <param name="shape">Фигура, площадь которой нужно вычислить.</param>
        /// <returns>Площадь фигуры.</returns>
        public static double CalculateArea(AbstractShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
