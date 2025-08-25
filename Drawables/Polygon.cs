using BaseCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD.Drawables
{
    public class Polygon : Polyline
    {
        public override bool Closed => true;

        public Polygon() : base() { }
        public Polygon(Point2DCollection pts) : base(pts) { }
        public Polygon(params Point2D[] pts) : base(pts) { }
        public Polygon(PointF[] pts) : base(pts) { }
    }
}
