using AreaCalculator.Shapes;

namespace AreaCalculator
{
    public static class Calculator
    {
        public static double CalculateArea(AbstractShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
