﻿using System.ComponentModel;
using Color = PLN.Graphics.Color;


namespace PLN
{
    [Docking(DockingBehavior.Ask)]
    public partial class CADWindow : UserControl
    {
        private System.Drawing.Color backColor = System.Drawing.Color.FromArgb(33, 40, 48);
        private bool interactive = true;
        private bool showGrid = true;
        private bool showAxes = true;
        private bool showCursor = true;

        [Browsable(false)]
        public CADDocument Document { get; set; }

        [Browsable(false)]
        public CADView View { get; private set; }
        public override System.Drawing.Color BackColor
        {
            get => backColor;
            set
            {
                backColor = value;
                Document.Settings.BackColor = Color.FromArgb((uint)value.ToArgb());
            }
        }

        private int level;
        public int Level { get => level; set { level = value; } }

        [Category("Behavior"), DefaultValue(true), Description("Indicates whether the control responds to interactive user input.")]
        public bool Interactive { get => interactive; set { interactive = value; View.Interactive = value; } }

        [Category("Appearance"), DefaultValue(true), Description("Determines whether the cartesian grid is shown.")]
        public bool ShowGrid { get => showGrid; set { showGrid = value; View.ShowGrid = value; } }

        [Category("Appearance"), DefaultValue(true), Description("Determines whether the X and Y axes are shown.")]
        public bool ShowAxes { get => showAxes; set { showAxes = value; View.ShowAxes = value; } }

        [Category("Appearance"), DefaultValue(true), Description("Determines whether the cursor is shown.")]
        public bool ShowCursor { get => showCursor; set { showCursor = value; View.ShowCursor = value; } }

        public CADWindow(CADDocument doc)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.DoubleBuffer, false);
            UpdateStyles();
            DoubleBuffered = false;

            BorderStyle = BorderStyle.Fixed3D;

            Document = doc;

            Document.Settings.BackColor = Color.FromArgb((uint)backColor.ToArgb());

            View = new CADView(this, Document);
            Document.ActiveView = View;
            View.Interactive = interactive;
            View.ShowAxes = showAxes;
            View.ShowGrid = showGrid;
            View.ShowCursor = showCursor;

            Disposed += CADWindow_Disposed;

        }
        private void CADWindow_Disposed(object sender, System.EventArgs e)
        {
            Document.ActiveView = null;
            if (View != null)
                View.Dispose();
        }
        protected override bool IsInputKey(Keys keyData)
        {
            if ((keyData & Keys.Tab) == Keys.Tab)
                return true;
            else if ((keyData & Keys.Escape) == Keys.Escape)
                return true;
            else if ((keyData & Keys.Return) == Keys.Return)
                return true;
            else if ((keyData & Keys.Enter) == Keys.Enter)
                return true;
            else
                return base.IsInputKey(keyData);
        }
    }
}
