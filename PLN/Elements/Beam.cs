using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;

namespace PLN.Elements
{
    internal class Beam : Line
    {
        private float h;
        private float b;
        public float H { get => h; set { h = value; } }
        public float B { get => b; set { b = value; } }

        public Beam(Line line, float h, float b)
            : this(line.StartPoint, line.EndPoint, h, b)
        { }
        public Beam(Point2D p1, Point2D p2, float h, float b)
        {
            StartPoint = p1;
            EndPoint = p2;

            this.h = h;
            this.b = b;
        }
        public override void Draw(Renderer renderer)
        {

            Vector2D dir = EndPoint - StartPoint;
            float angle = dir.Angle;
            float len = dir.Length;

            Composite items = new Composite();

            // 始点側の底
            Line line1 = new Line(0, -b / 2, 0, b / 2);
            line1.Style = Style.ApplyLayer(Layer);
            items.Add(line1);

            // 終点側の底
            Line line2 = new Line(len, -b / 2, len, b / 2);
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

            Matrix2D trans = Matrix2D.Transformation(1, 1, angle, StartPoint.X, StartPoint.Y);
            items.TransformBy(trans);

            foreach (var item in items)
            {
                Line line = (Line)item;

                renderer.DrawLine(Style.ApplyLayer(Layer), line.StartPoint, line.EndPoint);
            }

        }
    }
}
