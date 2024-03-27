namespace AreaCalculator.Shapes
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        protected override double CalculateAreaInternal()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
