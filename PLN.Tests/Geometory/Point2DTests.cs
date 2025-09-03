using PLN.Geometry;

namespace PLN.Tests.Geometory
{
    [TestClass]
    public sealed class Point2DTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Point2D pt = new Point2D(0, 0);

            Assert.AreEqual(pt, Point2D.Zero);
        }
    }
}
