using TriangleLibrary.Entities;

namespace TriangleLibrary.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            TriangleType triangleType = (TriangleType)Triangle.GetTriangleType(-1, 2, 3);
            Assert.IsTrue(triangleType == TriangleType.INVALID);
        }
    }
}