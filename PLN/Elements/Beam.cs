using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace PLN.Elements
{
    internal class Beam : Element
    {
        public override LayoutType LayoutType => LayoutType.Horizontal;
        public float H { get; private set; }
        public float B { get; private set; }

        public Beam(int referenceLevel, Line line, float h, float b)
        {
            updateLevel(referenceLevel);

            //Fig.StartPoint = line.StartPoint;
            //Fig.EndPoint = line.EndPoint;
            Fig = new Line(line.StartPoint, line.EndPoint);

            this.H = h;
            this.B = b;
            this.ElementType = "New Beam";
        }
        public override void Draw(Renderer renderer)
        {
            Line lineFig = (Line)Fig;

            Vector2D dir = lineFig.EndPoint - lineFig.StartPoint;
            float angle = dir.Angle;
            float len = dir.Length;

            Composite items = new Composite();

            // 始点側の底
            Line line1 = new Line(0, -B / 2, 0, B / 2);
            line1.Style = Style.ApplyLayer(Layer);
            items.Add(line1);

            // 終点側の底
            Line line2 = new Line(len, -B / 2, len, B / 2);
            line2.Style = Style.ApplyLayer(Layer);
            items.Add(line2);

            // 始点から終点
            Line line3 = new Line(line1.StartPoint, line2.StartPoint);
            line3.Style = Style.ApplyLayer(Layer);
            items.Add(line3);

            // 終点から始点
            Line line4 = new Line(line1.EndPoint, line2.EndPoint);
            line4.Style = Style.ApplyLayer(Layer);
            items.Add(line4);

            Matrix2D trans = Matrix2D.Transformation(1, 1, angle, lineFig.StartPoint.X, lineFig.StartPoint.Y);
            items.TransformBy(trans);

            foreach (var item in items)
            {
                Line line = (Line)item;

                renderer.DrawLine(Style.ApplyLayer(Layer), line.StartPoint, line.EndPoint);
            }

        }
        public override void Draw3D()
        {
            Line line = (Line)Fig;

            GL.Begin(PrimitiveType.Lines);

            GL.Color3(System.Drawing.Color.White);

            GL.Vertex3(line.StartPoint.X, line.StartPoint.Y, ReferenceLevel * 100);
            GL.Vertex3(line.EndPoint.X, line.EndPoint.Y, ReferenceLevel * 100);

            GL.End();
        }
        public override Extents2D GetExtents()
        {
            return Fig.GetExtents();
        }
    }
}
