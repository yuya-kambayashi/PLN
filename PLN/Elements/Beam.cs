using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PLN.Elements
{
    internal class Beam : Line
    {
        private float height;
        private float width;
        public float Height { get => height; set { height = value; } }
        public float Width { get => width; set { width = value; } }
        
        public Beam(Line line, float height, float width)
            : this(line.StartPoint, line.EndPoint, height, width)
        { }
        public Beam(Point2D p1, Point2D p2, float height, float width)
        {
            StartPoint = p1;
            EndPoint = p2;

            this.height = height;
            this.width = width;
        }
        public override void Draw(Renderer renderer)
        {

            Vector2D dir = EndPoint - StartPoint;
            float angle = dir.Angle;
            float len = dir.Length;

            Composite items = new Composite();

            float Offset = 0.4f;

            float tickSize = 0.5f * 100;

            // 始点側の底
            Line tick1 = new Line(0, -tickSize + Offset, 0, tickSize + Offset);
            tick1.Style = Style.ApplyLayer(Layer);
            items.Add(tick1);

            // 終点側の底
            Line tick2 = new Line(len, -tickSize + Offset, len, tickSize + Offset);
            tick2.Style = Style.ApplyLayer(Layer);
            items.Add(tick2);

            // 始点から終点
            Line tick3 = new Line(tick1.StartPoint, tick2.StartPoint);
            tick3.Style = Style.ApplyLayer(Layer);
            items.Add(tick3);

            // 終点から始点
            Line tick4 = new Line(tick1.EndPoint, tick2.EndPoint);
            tick4.Style = Style.ApplyLayer(Layer);
            items.Add(tick4);

            Matrix2D trans = Matrix2D.Transformation(1, 1, angle, StartPoint.X, StartPoint.Y);
            items.TransformBy(trans);

            foreach(var item in items)
            {
                Line line = (Line)item;

                renderer.DrawLine(Style.ApplyLayer(Layer), line.StartPoint, line.EndPoint);
            }

        }
    }
}
