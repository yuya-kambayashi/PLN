namespace BaseCAD
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

            this.statusCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.cadWindow1 = new CADWindow();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            // 
            // statusCoords
            // 
            this.statusCoords.Name = "statusCoords";
            this.statusCoords.Size = new System.Drawing.Size(25, 17);
            this.statusCoords.Text = "0, 0";
            // 
            // cadWindow1
            // 
            this.cadWindow1.BackColor = System.Drawing.Color.White;
            this.cadWindow1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cadWindow1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cadWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadWindow1.Location = new System.Drawing.Point(0, 0);
            this.cadWindow1.Name = "cadWindow1";
            this.cadWindow1.Size = new System.Drawing.Size(759, 469);
            this.cadWindow1.TabIndex = 0;
            this.cadWindow1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cadWindow1_MouseClick);
            this.cadWindow1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cadWindow1_MouseMove);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(245, 469);
            this.propertyGrid1.TabIndex = 1;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);

            // 
            // MainForm
            // 
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MainForm";

        }

        private CADWindow cadWindow1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;

        private System.Windows.Forms.ToolStripStatusLabel statusCoords;
        private System.Windows.Forms.PropertyGrid propertyGrid1;


        #endregion
    }
}