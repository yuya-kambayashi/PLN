using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            renderer.DrawRectangle(
                Style.ApplyLayer(Layer),
                StartPoint.Transform(new Matrix2D(1, 0, 1, 0, 50, 0)),
                EndPoint.Transform(new Matrix2D(1, 0, 1, 0, 0, -50))
                );
        }
    }
}
