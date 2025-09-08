using PLN.Drawables;
using PLN.Geometry;

namespace PLN.Tests.Drawables
{
    [TestClass]
    public sealed class LineTests
    {
        [TestMethod]
        public void Line_IsAxisParallel()
        {

            Assert.IsTrue(new Line(new Point2D(0, 0), new Point2D(10, 0)).IsAxisParallel());
            Assert.IsTrue(new Line(new Point2D(0, 0), new Point2D(0, 10)).IsAxisParallel());
            Assert.IsTrue(new Line(new Point2D(0, 0), new Point2D(-10, 0)).IsAxisParallel());
            Assert.IsTrue(new Line(new Point2D(0, 0), new Point2D(0, -10)).IsAxisParallel());

            Assert.IsFalse(new Line(new Point2D(0, 0), new Point2D(10, 1)).IsAxisParallel());
            Assert.IsFalse(new Line(new Point2D(0, 0), new Point2D(1, 10)).IsAxisParallel());
            Assert.IsFalse(new Line(new Point2D(0, 0), new Point2D(-10, -1)).IsAxisParallel());
            Assert.IsFalse(new Line(new Point2D(0, 0), new Point2D(-1, -10)).IsAxisParallel());
        }
    }
}
