using WeifenLuo.WinFormsUI.Docking;

namespace PLN
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            statusCoords = new ToolStripStatusLabel();
            btnAngleMode = new ToolStripDropDownButton();
            btnAngleDegrees = new ToolStripMenuItem();
            btnAngleRadians = new ToolStripMenuItem();
            btnAngleGrads = new ToolStripMenuItem();
            btnAngleSurveyor = new ToolStripMenuItem();
            btnAngleDMS = new ToolStripMenuItem();
            btnSnapMode = new ToolStripDropDownButton();
            btnSnap = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            btnSnapEnd = new ToolStripMenuItem();
            btnSnapMiddle = new ToolStripMenuItem();
            btnSnapCenter = new ToolStripMenuItem();
            btnSnapQuadrant = new ToolStripMenuItem();
            btnSnapPoint = new ToolStripMenuItem();
            treeProjectBrowser = new TreeView();
            CADDocument doc = new CADDocument();
            cadWindow1 = new CADWindow(doc);
            cadWindow2 = new CADWindow(doc);
            cadWindow3 = new CADWindow(doc);
            cadWindow4 = new CADWindow(doc);
            cadWindow5 = new CADWindow(doc);
            cadWindow3D = new CADWindow3D(doc);
            lblSelection = new Label();
            propertyGrid1 = new PropertyGrid();
            tsStandard = new ToolStrip();
            btnNew = new ToolStripButton();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnSaveAs = new ToolStripButton();
            tsTransform = new ToolStrip();
            btnMove = new ToolStripButton();
            btnCopy = new ToolStripButton();
            btnRotate = new ToolStripButton();
            btnScale = new ToolStripButton();
            btnMirror = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnStretch = new ToolStripButton();
            btnRotateCP = new ToolStripButton();
            btnScaleCP = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            tsPrimitives = new ToolStrip();
            btnDrawPoint = new ToolStripButton();
            btnDrawLine = new ToolStripButton();
            btnDrawBeam = new ToolStripButton();
            btnDrawColumn = new ToolStripButton();
            btnDrawRoom = new ToolStripButton();
            btnDrawCircle = new ToolStripButton();
            btnDrawEllipse = new ToolStripButton();
            btnDrawArc = new ToolStripButton();
            btnDrawEllipticArc = new ToolStripButton();
            btnDrawText = new ToolStripButton();
            btnDrawDimension = new ToolStripButton();
            btnDrawParabola = new ToolStripButton();
            btnDrawPolyline = new ToolStripButton();
            btnDrawRectangle = new ToolStripButton();
            btnDrawHatch = new ToolStripButton();
            btnDrawQuadraticBezier = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCreateComposite = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            btnZoom = new ToolStripButton();
            btnPan = new ToolStripButton();
            dockPanel = new DockPanel();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            dockPanel.SuspendLayout();
            tsStandard.SuspendLayout();
            tsTransform.SuspendLayout();
            tsPrimitives.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(dockPanel);
            toolStripContainer1.ContentPanel.Margin = new Padding(4, 5, 4, 5);
            toolStripContainer1.ContentPanel.Size = new Size(1344, 687);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Margin = new Padding(4, 5, 4, 5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1344, 794);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(tsStandard);
            toolStripContainer1.TopToolStripPanel.Controls.Add(tsTransform);
            //toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            //toolStripContainer1.TopToolStripPanel.Controls.Add(tsPrimitives);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel, statusCoords, btnAngleMode, btnSnapMode });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1344, 26);
            statusStrip1.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(1033, 20);
            statusLabel.Spring = true;
            statusLabel.Text = "Ready";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusCoords
            // 
            statusCoords.Image = Properties.Resources.coordinates;
            statusCoords.Name = "statusCoords";
            statusCoords.Size = new Size(52, 20);
            statusCoords.Text = "0, 0";
            // 
            // btnAngleMode
            // 
            btnAngleMode.DropDownItems.AddRange(new ToolStripItem[] { btnAngleDegrees, btnAngleRadians, btnAngleGrads, btnAngleSurveyor, btnAngleDMS });
            btnAngleMode.Image = Properties.Resources.angle;
            btnAngleMode.ImageTransparentColor = Color.Magenta;
            btnAngleMode.Name = "btnAngleMode";
            btnAngleMode.Size = new Size(125, 24);
            btnAngleMode.Text = "Angle Mode";
            // 
            // btnAngleDegrees
            // 
            btnAngleDegrees.CheckOnClick = true;
            btnAngleDegrees.Name = "btnAngleDegrees";
            btnAngleDegrees.Size = new Size(266, 26);
            btnAngleDegrees.Text = "Degrees";
            btnAngleDegrees.Click += btnAngleDegrees_Click;
            // 
            // btnAngleRadians
            // 
            btnAngleRadians.CheckOnClick = true;
            btnAngleRadians.Name = "btnAngleRadians";
            btnAngleRadians.Size = new Size(266, 26);
            btnAngleRadians.Text = "Radians";
            btnAngleRadians.Click += btnAngleRadians_Click;
            // 
            // btnAngleGrads
            // 
            btnAngleGrads.CheckOnClick = true;
            btnAngleGrads.Name = "btnAngleGrads";
            btnAngleGrads.Size = new Size(266, 26);
            btnAngleGrads.Text = "Grads";
            btnAngleGrads.Click += btnAngleGrads_Click;
            // 
            // btnAngleSurveyor
            // 
            btnAngleSurveyor.CheckOnClick = true;
            btnAngleSurveyor.Name = "btnAngleSurveyor";
            btnAngleSurveyor.Size = new Size(266, 26);
            btnAngleSurveyor.Text = "Surveyor";
            btnAngleSurveyor.Click += btnAngleSurveyor_Click;
            // 
            // btnAngleDMS
            // 
            btnAngleDMS.CheckOnClick = true;
            btnAngleDMS.Name = "btnAngleDMS";
            btnAngleDMS.Size = new Size(266, 26);
            btnAngleDMS.Text = "Degrees/Minutes/Seconds";
            btnAngleDMS.Click += btnAngleDMS_Click;
            // 
            // btnSnapMode
            // 
            btnSnapMode.DropDownItems.AddRange(new ToolStripItem[] { btnSnap, toolStripMenuItem1, btnSnapEnd, btnSnapMiddle, btnSnapCenter, btnSnapQuadrant, btnSnapPoint });
            btnSnapMode.Image = Properties.Resources.snap;
            btnSnapMode.Name = "btnSnapMode";
            btnSnapMode.Size = new Size(119, 24);
            btnSnapMode.Text = "Snap Mode";
            // 
            // btnSnap
            // 
            btnSnap.CheckOnClick = true;
            btnSnap.Name = "btnSnap";
            btnSnap.Size = new Size(154, 26);
            btnSnap.Text = "Snap";
            btnSnap.Click += btnSnap_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(151, 6);
            // 
            // btnSnapEnd
            // 
            btnSnapEnd.CheckOnClick = true;
            btnSnapEnd.Name = "btnSnapEnd";
            btnSnapEnd.Size = new Size(154, 26);
            btnSnapEnd.Text = "End";
            btnSnapEnd.Click += btnSnapEnd_Click;
            // 
            // btnSnapMiddle
            // 
            btnSnapMiddle.CheckOnClick = true;
            btnSnapMiddle.Name = "btnSnapMiddle";
            btnSnapMiddle.Size = new Size(154, 26);
            btnSnapMiddle.Text = "Middle";
            btnSnapMiddle.Click += btnSnapMiddle_Click;
            // 
            // btnSnapCenter
            // 
            btnSnapCenter.CheckOnClick = true;
            btnSnapCenter.Name = "btnSnapCenter";
            btnSnapCenter.Size = new Size(154, 26);
            btnSnapCenter.Text = "Center";
            btnSnapCenter.Click += btnSnapCenter_Click;
            // 
            // btnSnapQuadrant
            // 
            btnSnapQuadrant.CheckOnClick = true;
            btnSnapQuadrant.Name = "btnSnapQuadrant";
            btnSnapQuadrant.Size = new Size(154, 26);
            btnSnapQuadrant.Text = "Quadrant";
            btnSnapQuadrant.Click += btnSnapQuadrant_Click;
            // 
            // btnSnapPoint
            // 
            btnSnapPoint.CheckOnClick = true;
            btnSnapPoint.Name = "btnSnapPoint";
            btnSnapPoint.Size = new Size(154, 26);
            btnSnapPoint.Text = "Point";
            btnSnapPoint.Click += btnSnapPoint_Click;
            // 
            // treeProjectBrowser
            // 
            treeProjectBrowser.Dock = DockStyle.Fill;
            treeProjectBrowser.Location = new Point(0, 0);
            treeProjectBrowser.Name = "treeProjectBrowser";
            treeProjectBrowser.Size = new Size(198, 687);
            treeProjectBrowser.TabIndex = 0;
            // 
            // dockPanel
            // 
            dockPanel.Theme = new VS2015LightTheme();
            dockPanel.Dock = DockStyle.Fill;
            dockPanel.Name = "dockPanel1";
            dockPanel.TabIndex = 0;
            contentProjectBrowser = new MainDockContent("プロジェクト ブラウザ", treeProjectBrowser);
            contentProperties = new MainDockContent("Properties", propertyGrid1);
            contentViewFloor1F = new MainDockContent("1階平面図", cadWindow1);
            contentViewFloor2F = new MainDockContent("2階平面図", cadWindow2);
            contentViewFloor3F = new MainDockContent("3階平面図", cadWindow3);
            contentViewFloor4F = new MainDockContent("4階平面図", cadWindow4);
            contentViewFloor5F = new MainDockContent("5階平面図", cadWindow5);
            contentViewFloor3D = new MainDockContent("3D", cadWindow3D);
            contentProjectBrowser.Show(dockPanel, DockState.DockLeft);
            contentProperties.Show(dockPanel, DockState.DockRight);
            contentViewFloor1F.Show(dockPanel, DockState.Document);
            //contentViewFloor3D.Show(dockPanel, DockState.Document);
            //contentViewFloor3D.Show(contentViewFloor1F.Pane, DockAlignment.Right, 0.5);
            // 
            // cadWindow1
            // 
            cadWindow1.BorderStyle = BorderStyle.Fixed3D;
            cadWindow1.Dock = DockStyle.Fill;
            cadWindow1.Location = new Point(0, 0);
            cadWindow1.Margin = new Padding(5, 8, 5, 8);
            cadWindow1.Name = "cadWindow1";
            cadWindow1.TabIndex = 0;
            cadWindow1.View.Level = 1;
            // 
            // cadWindow2
            // 
            cadWindow2.BorderStyle = BorderStyle.Fixed3D;
            cadWindow2.Dock = DockStyle.Fill;
            cadWindow2.Location = new Point(0, 0);
            cadWindow2.Margin = new Padding(5, 8, 5, 8);
            cadWindow2.Name = "cadWindow2";
            cadWindow2.TabIndex = 0;
            cadWindow2.View.Level = 2;
            // 
            // cadWindow3
            // 
            cadWindow3.BorderStyle = BorderStyle.Fixed3D;
            cadWindow3.Dock = DockStyle.Fill;
            cadWindow3.Location = new Point(0, 0);
            cadWindow3.Margin = new Padding(5, 8, 5, 8);
            cadWindow3.Name = "cadWindow3";
            cadWindow3.TabIndex = 0;
            cadWindow3.View.Level = 3;
            // 
            // cadWindow4
            // 
            cadWindow4.BorderStyle = BorderStyle.Fixed3D;
            cadWindow4.Dock = DockStyle.Fill;
            cadWindow4.Location = new Point(0, 0);
            cadWindow4.Margin = new Padding(5, 8, 5, 8);
            cadWindow4.Name = "cadWindow4";
            cadWindow4.TabIndex = 0;
            cadWindow4.View.Level = 4;
            // 
            // cadWindow5
            // 
            cadWindow5.BorderStyle = BorderStyle.Fixed3D;
            cadWindow5.Dock = DockStyle.Fill;
            cadWindow5.Location = new Point(0, 0);
            cadWindow5.Margin = new Padding(5, 8, 5, 8);
            cadWindow5.Name = "cadWindow5";
            cadWindow5.TabIndex = 0;
            cadWindow5.View.Level = 5;
            // 
            // cadWindow3D
            // 
            cadWindow3D.BorderStyle = BorderStyle.Fixed3D;
            cadWindow3D.Dock = DockStyle.Fill;
            cadWindow3D.Location = new Point(0, 0);
            cadWindow3D.Margin = new Padding(5, 8, 5, 8);
            cadWindow3D.Name = "cadWindow3D";
            cadWindow3D.TabIndex = 0;
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Location = new Point(5, 14);
            lblSelection.Margin = new Padding(4, 0, 4, 0);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(50, 20);
            lblSelection.TabIndex = 2;
            lblSelection.Text = "label1";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            propertyGrid1.Location = new Point(0, 43);
            propertyGrid1.Margin = new Padding(4, 5, 4, 5);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(327, 604);
            propertyGrid1.TabIndex = 1;
            propertyGrid1.PropertyValueChanged += propertyGrid1_PropertyValueChanged;
            // 
            // tsStandard
            // 
            tsStandard.Dock = DockStyle.None;
            tsStandard.GripStyle = ToolStripGripStyle.Hidden;
            tsStandard.ImageScalingSize = new Size(20, 20);
            tsStandard.Items.AddRange(new ToolStripItem[] { btnNew, btnOpen, btnSave, btnSaveAs });
            tsStandard.Location = new Point(4, 0);
            tsStandard.Name = "tsStandard";
            tsStandard.Size = new Size(174, 27);
            tsStandard.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNew.Image = Properties.Resources.page_white;
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(29, 24);
            btnNew.Text = "New";
            btnNew.Click += btnNew_Click;
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = Properties.Resources.folder;
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(29, 24);
            btnOpen.Text = "Open";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources.disk;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 24);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Image = Properties.Resources.disk_multiple;
            btnSaveAs.ImageTransparentColor = Color.Magenta;
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(84, 24);
            btnSaveAs.Text = "Save As";
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // tsTransform
            // 
            tsTransform.Dock = DockStyle.None;
            tsTransform.GripStyle = ToolStripGripStyle.Hidden;
            tsTransform.ImageScalingSize = new Size(20, 20);
            tsTransform.Items.AddRange(new ToolStripItem[] { btnMove, btnCopy, btnRotate, btnScale, btnMirror, toolStripSeparator1, btnStretch, btnRotateCP, btnScaleCP, toolStripSeparator3, btnDelete, toolStripSeparator4, btnZoom, btnPan });
            tsTransform.Location = new Point(4, 27);
            tsTransform.Name = "tsTransform";
            tsTransform.Size = new Size(595, 27);
            tsTransform.TabIndex = 2;
            // 
            // btnMove
            // 
            btnMove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMove.Image = Properties.Resources.shape_move_backwards;
            btnMove.ImageTransparentColor = Color.Magenta;
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(29, 24);
            btnMove.Text = "Move";
            btnMove.Click += btnMove_Click;
            // 
            // btnCopy
            // 
            btnCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopy.Image = Properties.Resources.shape_copy;
            btnCopy.ImageTransparentColor = Color.Magenta;
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(29, 24);
            btnCopy.Text = "Copy";
            btnCopy.Click += btnCopy_Click;
            // 
            // btnRotate
            // 
            btnRotate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRotate.Image = Properties.Resources.shape_rotate_clockwise;
            btnRotate.ImageTransparentColor = Color.Magenta;
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(29, 24);
            btnRotate.Text = "Rotate";
            btnRotate.Click += btnRotate_Click;
            // 
            // btnScale
            // 
            btnScale.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnScale.Image = Properties.Resources.shape_scale;
            btnScale.ImageTransparentColor = Color.Magenta;
            btnScale.Name = "btnScale";
            btnScale.Size = new Size(29, 24);
            btnScale.Text = "Scale";
            btnScale.Click += btnScale_Click;
            // 
            // btnMirror
            // 
            btnMirror.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMirror.Image = Properties.Resources.shape_flip_horizontal;
            btnMirror.ImageTransparentColor = Color.Magenta;
            btnMirror.Name = "btnMirror";
            btnMirror.Size = new Size(29, 24);
            btnMirror.Text = "Mirror";
            btnMirror.Click += btnMirror_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnStretch
            // 
            btnStretch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnStretch.Image = (Image)resources.GetObject("btnStretch.Image");
            btnStretch.ImageTransparentColor = Color.Magenta;
            btnStretch.Name = "btnStretch";
            btnStretch.Size = new Size(59, 24);
            btnStretch.Text = "Stretch";
            btnStretch.Click += btnStretch_Click;
            // 
            // btnRotateCP
            // 
            btnRotateCP.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRotateCP.Image = (Image)resources.GetObject("btnRotateCP.Image");
            btnRotateCP.ImageTransparentColor = Color.Magenta;
            btnRotateCP.Name = "btnRotateCP";
            btnRotateCP.Size = new Size(154, 24);
            btnRotateCP.Text = "Rotate Control Points";
            btnRotateCP.Click += btnRotateCP_Click;
            // 
            // btnScaleCP
            // 
            btnScaleCP.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnScaleCP.Image = (Image)resources.GetObject("btnScaleCP.Image");
            btnScaleCP.ImageTransparentColor = Color.Magenta;
            btnScaleCP.Name = "btnScaleCP";
            btnScaleCP.Size = new Size(145, 24);
            btnScaleCP.Text = "Scale Control Points";
            btnScaleCP.Click += btnScaleCP_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.cross;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 24);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // tsPrimitives
            // 
            tsPrimitives.Dock = DockStyle.None;
            tsPrimitives.GripStyle = ToolStripGripStyle.Hidden;
            tsPrimitives.ImageScalingSize = new Size(20, 20);
            tsPrimitives.Items.AddRange(new ToolStripItem[] { btnDrawPoint, btnDrawLine, btnDrawBeam, btnDrawColumn, btnDrawRoom, btnDrawCircle, btnDrawEllipse, btnDrawArc, btnDrawEllipticArc, btnDrawText, btnDrawDimension, btnDrawParabola, btnDrawPolyline, btnDrawRectangle, btnDrawHatch, btnDrawQuadraticBezier, toolStripSeparator2, btnCreateComposite });
            tsPrimitives.Location = new Point(65, 54);
            tsPrimitives.Name = "tsPrimitives";
            tsPrimitives.Size = new Size(1235, 27);
            tsPrimitives.TabIndex = 0;
            tsPrimitives.Visible = false;
            // 
            // btnDrawPoint
            // 
            btnDrawPoint.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawPoint.Image = (Image)resources.GetObject("btnDrawPoint.Image");
            btnDrawPoint.ImageTransparentColor = Color.Magenta;
            btnDrawPoint.Name = "btnDrawPoint";
            btnDrawPoint.Size = new Size(47, 24);
            btnDrawPoint.Text = "Point";
            btnDrawPoint.Click += btnDrawPoint_Click;
            // 
            // btnDrawLine
            // 
            btnDrawLine.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawLine.Image = (Image)resources.GetObject("btnDrawLine.Image");
            btnDrawLine.ImageTransparentColor = Color.Magenta;
            btnDrawLine.Name = "btnDrawLine";
            btnDrawLine.Size = new Size(40, 24);
            btnDrawLine.Text = "Line";
            btnDrawLine.ToolTipText = "Draw Line";
            btnDrawLine.Click += btnDrawLine_Click;
            // 
            // btnDrawBeam
            // 
            btnDrawBeam.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawBeam.ImageTransparentColor = Color.Magenta;
            btnDrawBeam.Name = "btnDrawBeam";
            btnDrawBeam.Size = new Size(51, 24);
            btnDrawBeam.Text = "Beam";
            btnDrawBeam.ToolTipText = "Draw Beam";
            btnDrawBeam.Click += btnDrawBeam_Click;
            // 
            // btnDrawColumn
            // 
            btnDrawColumn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawColumn.ImageTransparentColor = Color.Magenta;
            btnDrawColumn.Name = "btnDrawColumn";
            btnDrawColumn.Size = new Size(64, 24);
            btnDrawColumn.Text = "Column";
            btnDrawColumn.Click += btnDrawColumn_Click;
            // 
            // btnDrawRoom
            // 
            btnDrawRoom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawRoom.ImageTransparentColor = Color.Magenta;
            btnDrawRoom.Name = "btnDrawRoom";
            btnDrawRoom.Size = new Size(53, 24);
            btnDrawRoom.Text = "Room";
            btnDrawRoom.ToolTipText = "Draw Room";
            btnDrawRoom.Click += btnDrawRoom_Click;
            // 
            // btnDrawCircle
            // 
            btnDrawCircle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawCircle.Image = (Image)resources.GetObject("btnDrawCircle.Image");
            btnDrawCircle.ImageTransparentColor = Color.Magenta;
            btnDrawCircle.Name = "btnDrawCircle";
            btnDrawCircle.Size = new Size(50, 24);
            btnDrawCircle.Text = "Circle";
            btnDrawCircle.Click += btnDrawCircle_Click;
            // 
            // btnDrawEllipse
            // 
            btnDrawEllipse.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawEllipse.Image = (Image)resources.GetObject("btnDrawEllipse.Image");
            btnDrawEllipse.ImageTransparentColor = Color.Magenta;
            btnDrawEllipse.Name = "btnDrawEllipse";
            btnDrawEllipse.Size = new Size(56, 24);
            btnDrawEllipse.Text = "Ellipse";
            btnDrawEllipse.Click += btnDrawEllipse_Click;
            // 
            // btnDrawArc
            // 
            btnDrawArc.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawArc.Image = (Image)resources.GetObject("btnDrawArc.Image");
            btnDrawArc.ImageTransparentColor = Color.Magenta;
            btnDrawArc.Name = "btnDrawArc";
            btnDrawArc.Size = new Size(35, 24);
            btnDrawArc.Text = "Arc";
            btnDrawArc.Click += btnDrawArc_Click;
            // 
            // btnDrawEllipticArc
            // 
            btnDrawEllipticArc.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawEllipticArc.Image = (Image)resources.GetObject("btnDrawEllipticArc.Image");
            btnDrawEllipticArc.ImageTransparentColor = Color.Magenta;
            btnDrawEllipticArc.Name = "btnDrawEllipticArc";
            btnDrawEllipticArc.Size = new Size(84, 24);
            btnDrawEllipticArc.Text = "Elliptic Arc";
            btnDrawEllipticArc.Click += btnDrawEllipticArc_Click;
            // 
            // btnDrawText
            // 
            btnDrawText.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawText.Image = (Image)resources.GetObject("btnDrawText.Image");
            btnDrawText.ImageTransparentColor = Color.Magenta;
            btnDrawText.Name = "btnDrawText";
            btnDrawText.Size = new Size(39, 24);
            btnDrawText.Text = "Text";
            btnDrawText.Click += btnDrawText_Click;
            // 
            // btnDrawDimension
            // 
            btnDrawDimension.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawDimension.Image = (Image)resources.GetObject("btnDrawDimension.Image");
            btnDrawDimension.ImageTransparentColor = Color.Magenta;
            btnDrawDimension.Name = "btnDrawDimension";
            btnDrawDimension.Size = new Size(84, 24);
            btnDrawDimension.Text = "Dimension";
            btnDrawDimension.Click += btnDrawDimension_Click;
            // 
            // btnDrawParabola
            // 
            btnDrawParabola.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawParabola.Image = (Image)resources.GetObject("btnDrawParabola.Image");
            btnDrawParabola.ImageTransparentColor = Color.Magenta;
            btnDrawParabola.Name = "btnDrawParabola";
            btnDrawParabola.Size = new Size(72, 24);
            btnDrawParabola.Text = "Parabola";
            btnDrawParabola.Click += btnDrawParabola_Click;
            // 
            // btnDrawPolyline
            // 
            btnDrawPolyline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawPolyline.Image = (Image)resources.GetObject("btnDrawPolyline.Image");
            btnDrawPolyline.ImageTransparentColor = Color.Magenta;
            btnDrawPolyline.Name = "btnDrawPolyline";
            btnDrawPolyline.Size = new Size(65, 24);
            btnDrawPolyline.Text = "Polyline";
            btnDrawPolyline.Click += btnDrawPolyline_Click;
            // 
            // btnDrawRectangle
            // 
            btnDrawRectangle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawRectangle.Image = (Image)resources.GetObject("btnDrawRectangle.Image");
            btnDrawRectangle.ImageTransparentColor = Color.Magenta;
            btnDrawRectangle.Name = "btnDrawRectangle";
            btnDrawRectangle.Size = new Size(79, 24);
            btnDrawRectangle.Text = "Rectangle";
            btnDrawRectangle.Click += btnDrawRectangle_Click;
            // 
            // btnDrawHatch
            // 
            btnDrawHatch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawHatch.Image = (Image)resources.GetObject("btnDrawHatch.Image");
            btnDrawHatch.ImageTransparentColor = Color.Magenta;
            btnDrawHatch.Name = "btnDrawHatch";
            btnDrawHatch.Size = new Size(52, 24);
            btnDrawHatch.Text = "Hatch";
            btnDrawHatch.Click += btnDrawHatch_Click;
            // 
            // btnDrawQuadraticBezier
            // 
            btnDrawQuadraticBezier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDrawQuadraticBezier.Image = (Image)resources.GetObject("btnDrawQuadraticBezier.Image");
            btnDrawQuadraticBezier.ImageTransparentColor = Color.Magenta;
            btnDrawQuadraticBezier.Name = "btnDrawQuadraticBezier";
            btnDrawQuadraticBezier.Size = new Size(123, 24);
            btnDrawQuadraticBezier.Text = "Quadratic Bezier";
            btnDrawQuadraticBezier.Click += btnDrawQuadraticBezier_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnCreateComposite
            // 
            btnCreateComposite.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCreateComposite.Image = (Image)resources.GetObject("btnCreateComposite.Image");
            btnCreateComposite.ImageTransparentColor = Color.Magenta;
            btnCreateComposite.Name = "btnCreateComposite";
            btnCreateComposite.Size = new Size(132, 24);
            btnCreateComposite.Text = "Create Composite";
            btnCreateComposite.Click += btnCreateComposite_Click;
            // 
            // toolStrip1
            // 
            //toolStrip1.Dock = DockStyle.None;
            //toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            //toolStrip1.ImageScalingSize = new Size(20, 20);
            //toolStrip1.Items.AddRange(new ToolStripItem[] { btnZoom, btnPan });
            //toolStrip1.Location = new Point(4, 54);
            //toolStrip1.Name = "toolStrip1";
            //toolStrip1.Size = new Size(61, 27);
            //toolStrip1.TabIndex = 4;
            // 
            // btnZoom
            // 
            btnZoom.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnZoom.Image = Properties.Resources.zoom;
            btnZoom.ImageTransparentColor = Color.Magenta;
            btnZoom.Name = "btnZoom";
            btnZoom.Size = new Size(29, 24);
            btnZoom.Text = "Zoom";
            btnZoom.Click += btnZoom_Click;
            // 
            // btnPan
            // 
            btnPan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPan.Image = Properties.Resources.arrow_all;
            btnPan.ImageTransparentColor = Color.Magenta;
            btnPan.Name = "btnPan";
            btnPan.Size = new Size(29, 24);
            btnPan.Text = "Pan";
            btnPan.Click += btnPan_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 794);
            Controls.Add(toolStripContainer1);
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "PLN";
            FormClosing += mainForm_FormClosing;
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            dockPanel.ResumeLayout(false);
            dockPanel.PerformLayout();
            tsStandard.ResumeLayout(false);
            tsStandard.PerformLayout();
            tsTransform.ResumeLayout(false);
            tsTransform.PerformLayout();
            tsPrimitives.ResumeLayout(false);
            tsPrimitives.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip tsPrimitives;
        private System.Windows.Forms.ToolStripButton btnDrawLine;
        private System.Windows.Forms.ToolStripButton btnDrawBeam;
        private System.Windows.Forms.ToolStripButton btnDrawColumn;
        private System.Windows.Forms.ToolStripButton btnDrawRoom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton btnDrawArc;
        private System.Windows.Forms.ToolStripButton btnDrawCircle;
        private System.Windows.Forms.ToolStripButton btnDrawEllipse;
        private System.Windows.Forms.ToolStripStatusLabel statusCoords;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripButton btnDrawEllipticArc;
        private System.Windows.Forms.ToolStripButton btnDrawText;
        private System.Windows.Forms.ToolStripButton btnDrawDimension;
        private System.Windows.Forms.ToolStripButton btnDrawParabola;
        private System.Windows.Forms.ToolStripButton btnDrawPolyline;
        private System.Windows.Forms.ToolStripButton btnDrawRectangle;
        private System.Windows.Forms.ToolStrip tsStandard;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStrip tsTransform;
        private System.Windows.Forms.ToolStripButton btnMove;
        private System.Windows.Forms.ToolStripButton btnRotate;
        private System.Windows.Forms.ToolStripButton btnScale;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnDrawHatch;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnMirror;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnZoom;
        private System.Windows.Forms.ToolStripButton btnPan;
        private System.Windows.Forms.ToolStripButton btnDrawPoint;
        private System.Windows.Forms.ToolStripButton btnStretch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRotateCP;
        private System.Windows.Forms.ToolStripButton btnScaleCP;
        private System.Windows.Forms.ToolStripButton btnDrawQuadraticBezier;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ToolStripDropDownButton btnAngleMode;
        private System.Windows.Forms.ToolStripMenuItem btnAngleDegrees;
        private System.Windows.Forms.ToolStripMenuItem btnAngleRadians;
        private System.Windows.Forms.ToolStripMenuItem btnAngleGrads;
        private System.Windows.Forms.ToolStripMenuItem btnAngleDMS;
        private System.Windows.Forms.ToolStripMenuItem btnAngleSurveyor;
        private System.Windows.Forms.ToolStripDropDownButton btnSnapMode;
        private System.Windows.Forms.ToolStripMenuItem btnSnapEnd;
        private System.Windows.Forms.ToolStripMenuItem btnSnapMiddle;
        private System.Windows.Forms.ToolStripMenuItem btnSnapCenter;
        private System.Windows.Forms.ToolStripMenuItem btnSnapQuadrant;
        private System.Windows.Forms.ToolStripMenuItem btnSnapPoint;
        private System.Windows.Forms.ToolStripMenuItem btnSnap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCreateComposite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.TreeView treeProjectBrowser;
        private System.Windows.Forms.TreeNode nodeView;
        private System.Windows.Forms.TreeNode nodeDrawables;
        private System.Windows.Forms.TreeNode nodeElements;

        private DockPanel dockPanel;
        private MainDockContent contentProjectBrowser;
        private MainDockContent contentProperties;
        private MainDockContent contentViewFloor1F;
        private MainDockContent contentViewFloor2F;
        private MainDockContent contentViewFloor3F;
        private MainDockContent contentViewFloor4F;
        private MainDockContent contentViewFloor5F;
        private MainDockContent contentViewFloor3D;
        private CADWindow cadWindow1;
        private CADWindow cadWindow2;
        private CADWindow cadWindow3;
        private CADWindow cadWindow4;
        private CADWindow cadWindow5;
        private CADWindow3D cadWindow3D;
    }
    public class MainDockContent : DockContent
    {
        public MainDockContent(string title, Control control)
        {
            this.Text = title;
            //this.ClientSize = new System.Drawing.Size(300, 200);

            //// 中身を適当に追加（例えばラベル）
            //var lbl = new Label();
            //lbl.Text = "内容: " + title;
            //lbl.Dock = DockStyle.Fill;
            //lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(control);
        }
    }
}