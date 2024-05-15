using GeometricShapesLib;
namespace GeometricShapesTest
{
    public class UnitTest1
    {
        [Fact]
        public void TriangleIsRectangular()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool result = triangle.IsRectangular;
            Assert.True(result);
        }

        [Fact]
        public void TriangleDoesNotExist()
        {
            try
            {
                Shape triangle = new Triangle(1, 4, 5);
                Assert.Fail("Expected exception");
            }
            catch (Exception ex)
            {

            }
        }

        [Fact]
        public void TriangleIsExist()
        {
            Shape triangle = new Triangle(3, 4, 5);
            bool result = triangle.Exist();
            Assert.True(result);
        }

        [Fact]
        public void CircleleDoesNotExist()
        {
            try
            {
                Shape triangle = new Circle(-3);
                Assert.Fail("Expected exception");
            }
            catch (Exception ex)
            {

            }
        }

        [Fact]
        public void TriangleSquare()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double answ = 6;
            double squareTriangle = triangle.Area;
            Assert.Equal(squareTriangle, answ);
        }
    }
}