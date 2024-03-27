using AreaCalculator;
using AreaCalculator.Exceptions;
using AreaCalculator.Shapes;

namespace AreaCalculatorTests
{
    public class CircleTests
    {
        [TestCase(-1)]
        [TestCase(0)]
        public void CircleCtor_InvalidRadius_ThrowsEx(double radius)
        {
            Assert.Catch<ZeroRadiusException>(() => new Circle(radius));
        }

        [TestCase(1, ExpectedResult = 3.1415926535897931d)]
        [TestCase(2, ExpectedResult = 12.566370614359172d)]
        [TestCase(3, ExpectedResult = 28.274333882308138d)]
        [TestCase(4, ExpectedResult = 50.26548245743669d)]
        [TestCase(5, ExpectedResult = 78.53981633974483d)]
        public double CalculateArea_ValidRadius_ReturnsCorrectArea(double radius)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = Calculator.CalculateArea(circle);

            // Assert
            return result;
        }
    }
}
