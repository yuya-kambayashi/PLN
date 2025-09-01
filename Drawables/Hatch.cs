using BaseCAD.Geometry;
using BaseCAD.Graphics;

namespace BaseCAD.Drawables
{
    public class Hatch : Polygon
    {
        public Hatch() : base()
        {
            ;
        }

        public Hatch(Point2DCollection pts) : base(pts)
        {
            ;
        }

        public Hatch(params Point2D[] pts) : base(pts)
        {
            ;
        }

        public Hatch(PointF[] pts) : base(pts)
        {
            ;
        }

        public override void Draw(Renderer renderer)
        {
            renderer.FillPolygon(Style.ApplyLayer(Layer), Points);
        }
    }
}
