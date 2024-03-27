namespace AreaCalculator
{
    public abstract class Shape
    {
        public double CalculateArea()
        {
            double area = CalculateAreaInternal();
            return area;
        }

        protected abstract double CalculateAreaInternal();
    }
}
