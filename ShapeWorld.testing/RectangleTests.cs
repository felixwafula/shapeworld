using ShapeWorld.Domain.Models;
using Xunit;

namespace ShapeWorld.Testing
{
    public class RectangleTests
    {
        public void Test_Edges()
        {
            //arrange
            var rectangle = new Rectangle(3, 2);
            var expected = 4;

            //act
            var actual = RectangleTests.NumberOfEdges;

            //assert
            Assert.True(expected == actual);
        }
    }
}