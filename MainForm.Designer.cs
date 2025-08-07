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

            this.cadWindow1 = new CADWindow();
            // 
            // cadWindow1
            // 
            this.cadWindow1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cadWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadWindow1.Location = new System.Drawing.Point(0, 0);
            this.cadWindow1.Name = "cadWindow1";
            this.cadWindow1.Size = new System.Drawing.Size(759, 394);
            this.cadWindow1.TabIndex = 0;

            // 
            // MainForm
            // 
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MainForm";
        }

        private CADWindow cadWindow1;
        #endregion
    }
}