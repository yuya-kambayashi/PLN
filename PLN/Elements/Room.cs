using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;

namespace PLN.Elements
{
    internal class Room : Polygon
    {
        private string name;
        public string Name { get => name; set { name = value; } }

        public Room(string name) : base() { this.name = name; }
        public Room(string name, Point2DCollection pts) : base(pts) { this.name = name; }
        public Room(string name, params Point2D[] pts) : base(pts) { this.name = name; }
        public Room(string name, PointF[] pts) : base(pts) { this.name = name; }
        public override void Draw(Renderer renderer)
        {
            Layer layer = new Layer("1", new Style(new Graphics.Color(128, Graphics.Color.Pink)));

            renderer.FillPolygon(Style.ApplyLayer(layer), Points);
        }

    }
}
