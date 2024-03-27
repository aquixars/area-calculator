namespace AreaCalculator.Shapes
{
    public abstract class AbstractShape
    {
        public double CalculateArea()
        {
            double area = CalculateAreaInternal();
            return area;
        }

        protected abstract double CalculateAreaInternal();
    }
}
