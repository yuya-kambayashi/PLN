using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    internal class MainForm : Form
    {
        CADWindow cadWindow1;
        //CADDocument doc;

        public MainForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            cadWindow1 = new CADWindow();

            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1008, 516);
            this.Name = "MainForm";
            this.Text = "BaseCAD Application";
            this.ResumeLayout(false);
            this.BackColor = System.Drawing.Color.Black;
        }
    }
}
