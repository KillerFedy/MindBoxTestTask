using Domain.Interfaces;
using Domain.Models;

namespace UnitTests.Tests
{
    public class UnitTests
    {
        [Fact]
        public void GetCircleSqure()
        {
            IMathFigure circle = new Circle(5);
            var square = circle.GetSquare();
            Assert.Equal(78.5, Math.Round(square, 1));
        }

        [Fact]
        public void GetTriangleSqure()
        {
            IMathFigure triangle = new Triangle(6, 8, 10);
            var square = triangle.GetSquare();
            Assert.Equal(24, square);
        }

        [Fact]
        public void IsTriangleRectanglular()
        {
            Triangle triangle = new Triangle(5, 12, 13);
            var isRectangle = triangle.IsTriangleRectangular();
            Assert.True(isRectangle);
        }

        [Fact]
        public void IsNotTriangleRectanglular()
        {
            Triangle triangle = new Triangle(7, 8, 10);
            var isRectangle = triangle.IsTriangleRectangular();
            Assert.False(isRectangle);
        }
    }
}
