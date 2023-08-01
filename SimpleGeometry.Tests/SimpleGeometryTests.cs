using SimpleGeometryLibrary.Figures;

namespace SimpleGeometryLibrary.Tests
{
    public class SimpleGeometryTests
    {
        #region CircleTests
        [Fact]
        public void CircleTest1()
        {
            Assert.Equal(Math.PI * 25, new Circle(5).GetArea());
        }

        [Fact]
        public void CircleTest2()
        {
            Assert.Equal(Math.PI * 3.75 * 3.75, new Circle(3.75).GetArea());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-0.2)]
        public void CircleTest3(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius).GetArea());
        }

        [Fact]
        public void CircleTest4()
        {
            var circle = new Circle(4.7);
            Assert.Equal(Math.PI * 4.7 * 4.7, SimpleGeometry.GetArea(circle));
        }

        [Fact]
        public void CircleTest5()
        {
            Assert.Equal(Math.PI * 4.7 * 4.7, SimpleGeometry.GetArea(4.7));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-0.2)]
        public void CircleTest6(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius).GetArea());
        }
        #endregion CircleTests

        #region TriangleTests
        [Fact]
        public void TriangleTest1()
        {
            Assert.Equal(600, new Triangle(30, 40, 50).GetArea());
        }

        [Fact]
        public void TriangleTest2()
        {
            Assert.Equal(Math.PI * 3.75 * 3.75, new Circle(3.75).GetArea());
        }

        [Theory]
        [InlineData(5.1, 5.9, 11)]
        [InlineData(11, 3.15, 7.85)]
        [InlineData(6, 5, 11)]
        [InlineData(11, 6, 5)]
        [InlineData(5, 11, 6)]
        [InlineData(6, 11, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 0, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        public void TriangleTest3(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c).GetArea());
        }

        [Fact]
        public void TriangleTest4()
        {
            var circle = new Triangle(3, 5, 4);
            Assert.Equal(6, SimpleGeometry.GetArea(circle));
        }

        [Fact]
        public void TriangleTest5()
        {
            Assert.Equal(600, SimpleGeometry.GetArea(30, 40, 50));
        }
        #endregion TriangleTests
    }
}