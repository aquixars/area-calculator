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
        public void CalculateArea_SidesAre3_4_5_Returns6()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = Calculator.CalculateArea(triangle);

            // Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void TriangleCtor_SidesAre3_5_10_ThrowsEx()
        {
            Assert.Catch<InvalidSidesSizeException>(() => new Triangle(3, 5, 10));
        }

        [Test]
        public void IsRectangular_SidesAre3_4_5_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.IsRectangular();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsRectangular_SidesAre4_4_4_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(4, 4, 4);

            // Act
            var result = triangle.IsRectangular();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
