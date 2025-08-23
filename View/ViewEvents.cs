using BaseCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    public delegate void CursorEventHandler(object sender, CursorEventArgs e);

    public class CursorEventArgs : EventArgs
    {
        public MouseButtons Button { get; private set; }
        public Point2D Location { get; private set; }
        public int Clicks { get; private set; }
        public int Delta { get; private set; }

        public float X { get { return Location.X; } }
        public float Y { get { return Location.Y; } }

        public CursorEventArgs(MouseButtons button, int clicks, Point2D location, int delta)
        {
            Button = button;
            Location = location;
            Clicks = clicks;
            Delta = delta;
        }

        public CursorEventArgs(MouseButtons button, int clicks, float x, float y, int delta)
            : this(button, clicks, new Point2D(x, y), delta)
        {
        }
    }
}
