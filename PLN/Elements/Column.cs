using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using Point = PLN.Drawables.Point;
using OpenTK.Graphics.OpenGL;


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
        public override void Draw3D()
        {
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(System.Drawing.Color.White);

            GL.Vertex3(Fig.Location.X, Fig.Location.Y, ReferenceLevel * 100);
            GL.Vertex3(Fig.Location.X, Fig.Location.Y, UpperLevel * 100);

            GL.End();
        }
        public override Extents2D GetExtents()
        {
            return Fig.GetExtents();
        }
    }
}