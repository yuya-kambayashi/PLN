using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;

namespace PLN.Elements
{
    internal class Room : Element
    {
        private Polygon fig;
        public Polygon Fig { get; set; }
        public override LayoutType LayoutType => LayoutType.Horizontal;

        private string name;
        public string Name { get => name; set { name = value; } }
        public Room(string name, Point2DCollection pts)
        {
            this.fig = new Polygon(pts);
            this.name = name;
        }
        public override void Draw(Renderer renderer)
        {
            Layer layer = new Layer("1", new Style(new Graphics.Color(128, Graphics.Color.Pink)));

            renderer.FillPolygon(Style.ApplyLayer(layer), fig.Points);
        }

        public override Extents2D GetExtents()
        {
            return fig.GetExtents();
        }

    }
}
