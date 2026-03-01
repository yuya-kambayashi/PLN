using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using System.Xml.Linq;

namespace PLN.Elements
{
    internal class Room : Element
    {
        public override LayoutType LayoutType => LayoutType.Horizontal;
        public Room(int referenceLevel, Point2DCollection pts, string elementType)
        {
            updateLevel(referenceLevel);

            this.Fig = new Polygon(pts);
            this.ElementType = elementType;
        }
        public override void Draw(Renderer renderer)
        {
            Layer layer = new Layer("1", new Style(new Graphics.Color(128, Graphics.Color.Pink)));

            renderer.FillPolygon(Style.ApplyLayer(layer), ((Polygon)Fig).Points);
        }

        public override Extents2D GetExtents()
        {
            return Fig.GetExtents();
        }

    }
}
