using PLN.Geometry;

namespace PLN.Tests.Geometory
{
    [TestClass]
    public sealed class Point2DTests
    {
        [TestMethod]
        public void PointZero_DefaultCoordinates_AreZero()
        {
            Assert.AreEqual(Point2D.Zero.X, 0);

            Assert.AreEqual(Point2D.Zero.Y, 0);

            Assert.AreEqual(new Point2D(0, 0), Point2D.Zero);
        }

        [TestMethod]
        public void Point2D_Transform_M()
        {
            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(1, 0, 1, 0, 0, 0)), Point2D.Zero);
            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(0, 1, 0, 1, 0, 0)), Point2D.Zero);
            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(1, 1, 1, 1, 0, 0)), Point2D.Zero);

            Assert.AreEqual(new Point2D(1, 1).Transform(new Matrix2D(1, 0, 1, 0, 0, 0)), new Point2D(1, 1));
            Assert.AreEqual(new Point2D(1, 1).Transform(new Matrix2D(0, 1, 0, 1, 0, 0)), new Point2D(1, 1));
            Assert.AreEqual(new Point2D(1, 1).Transform(new Matrix2D(1, 1, 0, 1, 0, 0)), new Point2D(2, 1));
            Assert.AreEqual(new Point2D(1, 1).Transform(new Matrix2D(1, 1, 1, 1, 0, 0)), new Point2D(2, 2));

            Assert.AreEqual(new Point2D(1, 1).Transform(new Matrix2D(-1, 0, -1, 0, 0, 0)), new Point2D(-1, -1));
            Assert.AreEqual(new Point2D(1, 1).Transform(new Matrix2D(0, -1, 0, -1, 0, 0)), new Point2D(-1, -1));
            Assert.AreEqual(new Point2D(1, 1).Transform(new Matrix2D(-1, -1, 0, -1, 0, 0)), new Point2D(-2, -1));
            Assert.AreEqual(new Point2D(1, 1).Transform(new Matrix2D(-1, -1, -1, -1, 0, 0)), new Point2D(-2, -2));
        }
        public void Point2D_Transform_DXDY()
        {

            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(0, 0, 0, 0, 1, 0)), new Point2D(1, 0));
            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(0, 0, 0, 0, 0, 1)), new Point2D(0, 1));
            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(0, 0, 0, 0, 1, 1)), new Point2D(1, 1));

            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(0, 0, 0, 0, -1, 0)), new Point2D(-1, 0));
            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(0, 0, 0, 0, 0, -1)), new Point2D(0, -1));
            Assert.AreEqual(Point2D.Zero.Transform(new Matrix2D(0, 0, 0, 0, -1, -1)), new Point2D(-1, -1));
        }
    }
}
