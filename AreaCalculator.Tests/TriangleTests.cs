using AreaCalculator;
using AreaCalculator.Exceptions;
using AreaCalculator.Shapes;

namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        [TestCase(-2, 3, 3)]
        [TestCase(99, -2, 5)]
        [TestCase(2, 1, -3)]
        [TestCase(0, 0, 0)]
        public void TriangleCtor_InvalidSidesSize_ThrowsEx(double a, double b, double c)
        {
            Assert.Catch<InvalidSideException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void TriangleCtor_SidesAre3_5_10_ThrowsEx()
        {
            Assert.Catch<InvalidSidesSizeException>(() => new Triangle(3, 5, 10));
        }

        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(5, 12, 13, ExpectedResult = 30)]
        [TestCase(10, 10, 10, ExpectedResult = 43.301270189221931d)]
        [TestCase(6, 8, 10, ExpectedResult = 24)]
        [TestCase(7, 8, 9, ExpectedResult = 26.832815729997478d)]
        public double CalculateArea_ValidSides_ReturnsCorrectArea(double a, double b, double c)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var result = Calculator.CalculateArea(triangle);

            // Assert
            return result;
        }

        [TestCase(3, 4, 4, ExpectedResult = false)]
        [TestCase(3, 4, 5 - 0.0000001, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 5 + 0.0000001, ExpectedResult = false)]
        public bool IsRectangular(double a, double b, double c)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var isRight = triangle.IsRectangular();

            // Assert
            return isRight;
        }
    }
}
