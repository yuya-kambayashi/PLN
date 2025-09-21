using PLN.Elements;
using WeifenLuo.WinFormsUI.Docking;

namespace PLN
{
    public partial class MainForm : Form
    {
        private CheckBox btnShowGrid;
        private CheckBox btnShowAxes;
        private ToolStripControlHost tsShowGrid;
        private ToolStripControlHost tsShowAxes;

        private CADDocument doc;
        private Editor ed;

        public MainForm()
        {
            InitializeComponent();

            doc = cadWindow1.Document;
            ed = doc.Editor;

            doc.DocumentChanged += doc_DocumentChanged;
            doc.SelectionChanged += doc_SelectionChanged;
            cadWindow1.MouseMove += cadWindow1_MouseMove;
            cadWindow2.MouseMove += cadWindow2_MouseMove;

            btnShowGrid = new CheckBox();
            btnShowGrid.Appearance = Appearance.Button;
            btnShowGrid.Image = Properties.Resources.grid;
            btnShowGrid.Text = "Grid";
            btnShowGrid.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsShowGrid = new ToolStripControlHost(btnShowGrid);
            tsShowGrid.Click += btnShowGrid_Click;
            statusStrip1.Items.Add(tsShowGrid);

            btnShowAxes = new CheckBox();
            btnShowAxes.Appearance = Appearance.Button;
            btnShowAxes.Image = Properties.Resources.axis;
            btnShowAxes.Text = "Axes";
            btnShowAxes.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsShowAxes = new ToolStripControlHost(btnShowAxes);
            tsShowAxes.Click += btnShowAxes_Click;
            statusStrip1.Items.Add(tsShowAxes);

            // TreeViewの更新
            treeProjectBrowser.BeginUpdate();

            TreeNode nodeView = new TreeNode("ビュー");
            TreeNode node平面図 = new TreeNode("平面図");
            node平面図.Nodes.Add(new TreeNode("1階"));
            node平面図.Nodes.Add(new TreeNode("2階"));
            node平面図.Nodes.Add(new TreeNode("3階"));
            node平面図.Nodes.Add(new TreeNode("4階"));
            node平面図.Nodes.Add(new TreeNode("5階"));

            TreeNode node立面図 = new TreeNode("立面図");
            node立面図.Nodes.Add(new TreeNode("西"));
            node立面図.Nodes.Add(new TreeNode("東"));
            node立面図.Nodes.Add(new TreeNode("南"));
            node立面図.Nodes.Add(new TreeNode("北"));

            TreeNode node3D = new TreeNode("3D");
            node3D.Nodes.Add(new TreeNode("{3D}"));

            nodeView.Nodes.Add(node平面図);
            nodeView.Nodes.Add(node立面図);
            nodeView.Nodes.Add(node3D);

            TreeNode nodeDrawables = new TreeNode("Drawables");
            nodeDrawables.Nodes.Add(new TreeNode("Line"));
            nodeDrawables.Nodes.Add(new TreeNode("Point"));

            TreeNode nodeElements = new TreeNode("Elements");
            nodeElements.Nodes.Add(new TreeNode("Beam"));
            nodeElements.Nodes.Add(new TreeNode("Column"));
            nodeElements.Nodes.Add(new TreeNode("Room"));

            treeProjectBrowser.Nodes.Add(nodeView);
            treeProjectBrowser.Nodes.Add(nodeDrawables);
            treeProjectBrowser.Nodes.Add(nodeElements);
            treeProjectBrowser.NodeMouseClick += TreeProjectBrowser_NodeMouseClick;
            treeProjectBrowser.EndUpdate();

            UpdateUI();
        }

        private void doc_DocumentChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObjects = ed.PickedSelection.ToArray();
        }

        private void doc_SelectionChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObjects = ed.PickedSelection.ToArray();

            UpdateUI();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            cadWindow1.Refresh();
            cadWindow2.Refresh();
        }

        private void cadWindow1_MouseMove(object sender, MouseEventArgs e)
        {
            statusCoords.Text = cadWindow1.View.CursorLocation.ToString(doc.Settings.NumberFormat);
        }
        private void cadWindow2_MouseMove(object sender, MouseEventArgs e)
        {
            statusCoords.Text = cadWindow2.View.CursorLocation.ToString(doc.Settings.NumberFormat);
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!EnsureDocumentSaved())
                e.Cancel = true;
        }

        private bool EnsureDocumentSaved()
        {
            if (!doc.IsModified)
                return true;

            DialogResult res = MessageBox.Show(
                "Do you want to save the changes to the document?",
                "PLN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Cancel)
                return false;
            else if (res == DialogResult.No)
                return true;
            else
            {
                ed.RunCommand("Document.Save");
                return !doc.IsModified;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (EnsureDocumentSaved())
                ed.RunCommand("Document.New");
            UpdateUI();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (EnsureDocumentSaved())
                ed.RunCommand("Document.Open", SaveFileName);
            UpdateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(doc.FileName))
                ed.RunCommand("Document.SaveAs", SaveFileName);
            else
                ed.RunCommand("Document.Save");
            UpdateUI();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Document.SaveAs", doc.FileName ?? SaveFileName);
            UpdateUI();
        }

        private string SaveFileName
        {
            get
            {
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                return Path.Combine(path, "save.scf");
            }
        }

        private void UpdateUI()
        {
            btnSnap.Checked = doc.Settings.Snap;
            btnSnapEnd.Checked = (doc.Settings.SnapMode & SnapPointType.End) != SnapPointType.None;
            btnSnapMiddle.Checked = (doc.Settings.SnapMode & SnapPointType.Middle) != SnapPointType.None;
            btnSnapCenter.Checked = (doc.Settings.SnapMode & SnapPointType.Center) != SnapPointType.None;
            btnSnapQuadrant.Checked = (doc.Settings.SnapMode & SnapPointType.Quadrant) != SnapPointType.None;
            btnSnapPoint.Checked = (doc.Settings.SnapMode & SnapPointType.Point) != SnapPointType.None;

            btnAngleRadians.Checked = (doc.Settings.AngleMode == AngleMode.Radians);
            btnAngleDegrees.Checked = (doc.Settings.AngleMode == AngleMode.Degrees);
            btnAngleGrads.Checked = (doc.Settings.AngleMode == AngleMode.Grads);
            btnAngleDMS.Checked = (doc.Settings.AngleMode == AngleMode.DegreesMinutesSeconds);
            btnAngleSurveyor.Checked = (doc.Settings.AngleMode == AngleMode.Surveyor);

            btnAngleMode.Text =
                (doc.Settings.AngleMode == AngleMode.Radians ? "Radians" :
                doc.Settings.AngleMode == AngleMode.Degrees ? "Degrees" :
                doc.Settings.AngleMode == AngleMode.Grads ? "Grads" :
                doc.Settings.AngleMode == AngleMode.DegreesMinutesSeconds ? "Degrees/Minutes/Seconds" :
                doc.Settings.AngleMode == AngleMode.Surveyor ? "Surveyor" : "<Unkown>");

            btnSnapMode.Text = "Snap " + (doc.Settings.Snap ? "" : "(Off)") + ":" +
                (doc.Settings.SnapMode == SnapPointType.None ? " None" :
                (((doc.Settings.SnapMode & SnapPointType.End) != SnapPointType.None) ? " E" : "") +
                (((doc.Settings.SnapMode & SnapPointType.Middle) != SnapPointType.None) ? " M" : "") +
                (((doc.Settings.SnapMode & SnapPointType.Center) != SnapPointType.None) ? " C" : "") +
                (((doc.Settings.SnapMode & SnapPointType.Quadrant) != SnapPointType.None) ? " Q" : "") +
                (((doc.Settings.SnapMode & SnapPointType.Point) != SnapPointType.None) ? " P" : ""));

            btnShowGrid.Checked = cadWindow1.View.ShowGrid;
            btnShowAxes.Checked = cadWindow1.View.ShowAxes;

            if (ed.PickedSelection.Count == 0)
                lblSelection.Text = "No selection";
            else if (ed.PickedSelection.Count == 1)
                lblSelection.Text = ed.PickedSelection.First().GetType().Name;
            else
                lblSelection.Text = ed.PickedSelection.Count.ToString() + " selected";
        }

        private void btnDrawPoint_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Point");
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Line");
        }
        private void btnDrawBeam_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Elements.Beam");
        }

        private void btnDrawColumn_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Elements.Column");
        }
        private void btnDrawRoom_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Elements.Room");
        }

        private void btnDrawArc_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Arc");
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Circle");
        }

        private void btnDrawEllipse_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Ellipse");
        }

        private void btnDrawEllipticArc_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Elliptic_Arc");
        }

        private void btnDrawText_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Text");
        }

        private void btnDrawDimension_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Dimension");
        }

        private void btnDrawParabola_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Parabola");
        }

        private void btnDrawPolyline_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Polyline");
        }

        private void btnDrawHatch_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Hatch");
        }

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Rectangle");
        }

        private void btnDrawQuadraticBezier_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Primitives.Quadratic_Bezier");
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Transform.Move");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Transform.Copy");
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Transform.Rotate");
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Transform.Scale");
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Transform.Mirror");
        }

        private void btnStretch_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Transform.MoveControlPoints");
        }

        private void btnRotateCP_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Transform.RotateControlPoints");
        }

        private void btnScaleCP_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Transform.ScaleControlPoints");
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            ed.RunCommand("View.Zoom");
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            ed.RunCommand("View.Pan");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Edit.Delete");
        }

        private void btnCreateComposite_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Composite.Create");
        }
        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            ed.RunCommand("Room.Create");
        }

        private void btnAngleDegrees_Click(object sender, EventArgs e)
        {
            doc.Settings.AngleMode = AngleMode.Degrees;
            UpdateUI();
        }

        private void btnAngleRadians_Click(object sender, EventArgs e)
        {
            doc.Settings.AngleMode = AngleMode.Radians;
            UpdateUI();
        }

        private void btnAngleGrads_Click(object sender, EventArgs e)
        {
            doc.Settings.AngleMode = AngleMode.Grads;
            UpdateUI();
        }

        private void btnAngleDMS_Click(object sender, EventArgs e)
        {
            doc.Settings.AngleMode = AngleMode.DegreesMinutesSeconds;
            UpdateUI();
        }

        private void btnAngleSurveyor_Click(object sender, EventArgs e)
        {
            doc.Settings.AngleMode = AngleMode.Surveyor;
            UpdateUI();
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            doc.Settings.Snap = btnSnap.Checked;
            UpdateUI();
        }

        private void btnSnapEnd_Click(object sender, EventArgs e)
        {
            if (btnSnapEnd.Checked)
                doc.Settings.SnapMode |= SnapPointType.End;
            else
                doc.Settings.SnapMode &= ~SnapPointType.End;
            UpdateUI();
        }

        private void btnSnapMiddle_Click(object sender, EventArgs e)
        {
            if (btnSnapMiddle.Checked)
                doc.Settings.SnapMode |= SnapPointType.Middle;
            else
                doc.Settings.SnapMode &= ~SnapPointType.Middle;
            UpdateUI();
        }

        private void btnSnapCenter_Click(object sender, EventArgs e)
        {
            if (btnSnapCenter.Checked)
                doc.Settings.SnapMode |= SnapPointType.Center;
            else
                doc.Settings.SnapMode &= ~SnapPointType.Center;
            UpdateUI();
        }

        private void btnSnapQuadrant_Click(object sender, EventArgs e)
        {
            if (btnSnapQuadrant.Checked)
                doc.Settings.SnapMode |= SnapPointType.Quadrant;
            else
                doc.Settings.SnapMode &= ~SnapPointType.Quadrant;
            UpdateUI();
        }

        private void btnSnapPoint_Click(object sender, EventArgs e)
        {
            if (btnSnapPoint.Checked)
                doc.Settings.SnapMode |= SnapPointType.Point;
            else
                doc.Settings.SnapMode &= ~SnapPointType.Point;
            UpdateUI();
        }

        private void btnShowGrid_Click(object sender, EventArgs e)
        {
            cadWindow1.View.ShowGrid = !cadWindow1.View.ShowGrid;
            cadWindow1.Focus();
            UpdateUI();
        }

        private void btnShowAxes_Click(object sender, EventArgs e)
        {
            cadWindow1.View.ShowAxes = !cadWindow1.View.ShowAxes;
            cadWindow1.Focus();
            UpdateUI();
        }

        private void TreeProjectBrowser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                return;
            }

            switch (e.Node.Text)
            {
                case "1階":
                    contentViewFloor1F.Show(dockPanel, DockState.Document);
                    break;
                case "2階":
                    contentViewFloor2F.Show(dockPanel, DockState.Document);
                    break;
                case "3階":
                case "4階":
                case "5階":
                    showMain();
                    break;
                case "西":
                case "東":
                case "南":
                case "北":
                case "{3D}":
                    break;
                case "Line":
                    ed.RunCommand("Primitives.Line");
                    break;
                case "Point":
                    ed.RunCommand("Primitives.Point");
                    break;
                case "Beam":
                    ed.RunCommand("Elements.Beam");
                    break;
                case "Column":
                    ed.RunCommand("Elements.Column");
                    break;
                case "Room":
                    ed.RunCommand("Elements.Room");
                    break;

            }
        }
        private void showMain()
        {
        }
    }
}