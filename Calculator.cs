using AreaCalculator.Shapes;

namespace AreaCalculator
{
    public class Calculator
    {
        public double CalculateArea(AbstractShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
