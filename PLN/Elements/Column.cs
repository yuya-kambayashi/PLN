using PLN.Geometry;
using PLN.Graphics;
using Point = PLN.Drawables.Point;

namespace PLN.Elements
{
    internal class Column : Point
    {
        private float d;
        public float D { get => d; set { d = value; } }

        private int level;
        public int Level { get => level; set { level = value; } }

        public Column(Point2D location, float d)
        {
            Location = location;

            this.d = d;
        }
        public override void Draw(Renderer renderer)
        {
            renderer.FillRectangle(Style.ApplyLayer(Layer),
                new Point2D(Location.X - d / 2, Location.Y - d / 2),
                new Point2D(Location.X + d / 2, Location.Y + d / 2));
        }
    }
}