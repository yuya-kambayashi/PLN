using OpenTK.Graphics.OpenGL;
using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using System.Drawing;
using Point = PLN.Drawables.Point;


namespace PLN.Elements
{
    internal class Column : Element
    {
        public override LayoutType LayoutType => LayoutType.Vertical;
        public float D { get; private set; }

        public Column(int referenceLevel, Point location, float d)
        {
            updateLevel(referenceLevel);

            this.Fig = location;

            this.D = d;

            this.ElementType = "New Column";
        }
        public override void Draw(Renderer renderer)
        {
            Point point = (Point)Fig;

            renderer.FillRectangle(Style.ApplyLayer(Layer),
                new Point2D(point.Location.X - D / 2, point.Location.Y - D / 2),
                new Point2D(point.Location.X + D / 2, point.Location.Y + D / 2));
        }
        public override void Draw3D()
        {
            Point point = (Point)Fig;

            GL.Begin(PrimitiveType.Lines);

            GL.Color3(System.Drawing.Color.White);

            GL.Vertex3(point.Location.X, point.Location.Y, ReferenceLevel * 100);
            GL.Vertex3(point.Location.X, point.Location.Y, UpperLevel * 100);

            GL.End();
        }
        public override Extents2D GetExtents()
        {
            return Fig.GetExtents();
        }
    }
}