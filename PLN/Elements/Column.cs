using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using Point = PLN.Drawables.Point;
using Vector3 = OpenTK.Vector3;

namespace PLN.Elements
{
    internal class Column : Element
    {
        public override LayoutType LayoutType => LayoutType.Vertical;

        public Point Fig { get; private set; }
        public float D { get; private set; }

        public Column(int referenceLevel, Point location, float d)
        {
            updateLevel(referenceLevel);

            this.Fig = location;

            this.D = d;
        }
        public override void Draw(Renderer renderer)
        {
            renderer.FillRectangle(Style.ApplyLayer(Layer),
                new Point2D(Fig.Location.X - D / 2, Fig.Location.Y - D / 2),
                new Point2D(Fig.Location.X + D / 2, Fig.Location.Y + D / 2));
        }
        public override (Vector3 start, Vector3 end) Draw3D()
        {
            Vector3 s = new Vector3(Fig.Location.X, Fig.Location.Y, ReferenceLevel * 100);
            Vector3 e = new Vector3(Fig.Location.X, Fig.Location.Y, UpperLevel * 100);

            return (s, e);
        }
        public override Extents2D GetExtents()
        {
            return Fig.GetExtents();
        }
    }
}