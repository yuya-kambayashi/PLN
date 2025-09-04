using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using Point = PLN.Drawables.Point;

namespace PLN.Elements
{
    internal class Column : Point
    {
        private float d;
        public float D { get => d; set { d = value; } }

        public Column(Point2D location, float d)
        {
            Location = location;

            this.d = d;
        }
        public override void Draw(Renderer renderer)
        {
            float size = renderer.View.ScreenToWorld(new Vector2D(renderer.View.Document.Settings.PointSize, 0)).X / 2;
            renderer.DrawCircle(Style.ApplyLayer(Layer), Location, size);
        }
    }
}