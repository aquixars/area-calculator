using AreaCalculator;
using AreaCalculator.Exceptions;
using AreaCalculator.Shapes;

namespace AreaCalculatorTests
{
    public class CircleTests
    {
        [Test]
        public void CalculateArea_RadiusIs2_Returns12_56()
        {
            // Arrange
            var circle = new Circle(2);

            // Act
            var result = Calculator.CalculateArea(circle);

            // Assert
            Assert.AreEqual(12.56, result, 0.01);
        }

        [Test]
        public void CircleCtor_RadiusIs0_ThrowsEx()
        {
            Assert.Catch<ZeroRadiusException>(() => new Circle(0));
        }

        [Test]
        public void CircleCtor_NegativeRadius_ThrowsEx()
        {
            Assert.Catch<ZeroRadiusException>(() => new Circle(-1d));
        }
    }
}
