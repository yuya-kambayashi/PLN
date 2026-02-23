using PLN.Geometry;
using System.ComponentModel;
using Clipper2Lib;

namespace PLN.Drawables
{
    public class Polygon : Polyline
    {
        [Browsable(false)]
        public override bool Closed => true;

        public PathsD Paths = new PathsD();

        public Polygon() : base() { }
        public Polygon(Point2DCollection pts) : base(pts)
        {
            Paths.Add(new PathD(
                pts.Select(p => new PointD((double)p.X, (double)p.Y))
            ));
        }
        public Polygon(params Point2D[] pts) : base(pts)
        {
            Paths.Add(new PathD(
                pts.Select(p => new PointD((double)p.X, (double)p.Y))
            ));
        }
        public Polygon(PointF[] pts) : base(pts)
        {
            Paths.Add(new PathD(
                pts.Select(p => new PointD((double)p.X, (double)p.Y))
            ));
        }

        public Boolean IsOnline(Polygon other)
        {
            PathsD intersection = Clipper.Intersect(Paths, other.Paths, FillRule.NonZero);
            //PathsD difference = Clipper.Difference(Paths, other.Paths, FillRule.NonZero);
            PathsD union = Clipper.Union(Paths, other.Paths, FillRule.NonZero);

            if (intersection.Count == 0 && union.Count == 1)
            {
                return true;
            }

            return false;
        }
        public Boolean IsOverlap(Polygon other)
        {
            PathsD intersection = Clipper.Intersect(Paths, other.Paths, FillRule.NonZero);
            //PathsD difference = Clipper.Difference(Paths, other.Paths, FillRule.NonZero);
            PathsD union = Clipper.Union(Paths, other.Paths, FillRule.NonZero);

            if (intersection.Count == 0 && union.Count == 1)
            {
                return true;
            }

            return false;
        }
        public Boolean isInside(Polygon other)
        {
            // thisがotherの内部か判定

            PathsD intersection = Clipper.Intersect(Paths, other.Paths, FillRule.NonZero);
            PathsD difference = Clipper.Difference(Paths, other.Paths, FillRule.NonZero);
            PathsD union = Clipper.Union(Paths, other.Paths, FillRule.NonZero);

            if (difference.Count == 0 && union.Count == 1)
            {
                return true;
            }

            return false;
        }

    }
}
