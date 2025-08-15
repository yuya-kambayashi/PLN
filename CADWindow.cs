using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseCAD
{
    [Docking(DockingBehavior.Ask)]
    public partial class CADWindow : UserControl
    {
        private CADDocument doc;

        private bool panning;
        private Point lastMouse;
        private Drawable mouseDownItem;


        [Browsable(false)]
        public CADView View { get; private set; }
        [Browsable(false)]
        public CADDocument Document
        {
            get
            {
                return doc;
            }
            set
            {
                doc = value;
                if (View != null) View.Detach();
                View = new CADView(doc);
                View.Attach(this);
            }
        }
        [Browsable(false)]
        public float DrawingScale { get { return View.ZoomFactor; } }
        public bool AllowZoomAndPan { get; set; } = true;
        [Category("Behavior"), DefaultValue(true), Description("Indicates whether the control allows selecting items using the mouse.")]
        public bool AllowSelect { get; set; } = true;
        [Category("Behavior"), DefaultValue(4), Description("Determines the size of the pick box around the selection cursor.")]
        public int PickBoxSize { get; set; } = 4;

        public CADWindow()
        {
            InitializeComponent();

            DoubleBuffered = true;

            BorderStyle = BorderStyle.Fixed3D;
            BackColor = Color.FromArgb(33, 40, 48);
            Cursor = Cursors.Cross;

            Document = new CADDocument();
        }
    }
}
