using PLN.Geometry;
using PLN.Graphics;

namespace PLN.Drawables
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
            Layer layer = new Layer("1", new Style(new Graphics.Color(128, Graphics.Color.Yellow)));

            renderer.FillPolygon(Style.ApplyLayer(layer), Points);
        }
    }
}
