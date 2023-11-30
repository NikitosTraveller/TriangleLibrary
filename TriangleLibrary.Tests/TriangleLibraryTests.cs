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
        public void IsTriangleValidTest()
        {
            TriangleType triangleType = (TriangleType)Triangle.GetTriangleType(-4, 6, 1.34);
            Assert.IsTrue(triangleType != TriangleType.INVALID);
        }

        [Test]
        public void IsTriangleRightTest()
        {
            TriangleType triangleType = (TriangleType)Triangle.GetTriangleType(3, 5, 4);
            Assert.IsTrue(triangleType == TriangleType.RIGHT);
        }

        [Test]
        public void IsTriangleObtuseTest()
        {
            TriangleType triangleType = (TriangleType)Triangle.GetTriangleType(12.45, 23.78, 15.9);
            Assert.IsTrue(triangleType == TriangleType.OBTUSE);
        }

        [Test]
        public void IsTriangleAcuteTest()
        {
            TriangleType triangleType = (TriangleType)Triangle.GetTriangleType(4.5, 4.5, 4.5);
            Assert.IsTrue(triangleType == TriangleType.ACUTE);
        }
    }
}