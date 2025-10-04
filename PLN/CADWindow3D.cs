using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using PLN.Drawables;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace PLN
{
    [Docking(DockingBehavior.Ask)]
    public partial class CADWindow3D : GLControl
    {
        private System.Drawing.Color backColor = System.Drawing.Color.FromArgb(33, 40, 48);

        [Browsable(false)]
        public CADDocument Document { get; set; }
        [Browsable(false)]
        public CADView3D View { get; private set; }

        public CADWindow3D(CADDocument doc)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.DoubleBuffer, false);
            UpdateStyles();
            DoubleBuffered = false;

            BorderStyle = BorderStyle.Fixed3D;

            Document = doc;

            View = new CADView3D(this, Document);


            Disposed += CADWindow3D_Disposed;
        }
        private void CADWindow3D_Disposed(object sender, System.EventArgs e)
        {
            if (View != null)
                View.Dispose();
        }
    }
}
