using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    internal class CADWindow : UserControl
    {
        public CADWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CADWindow
            // 
            this.Name = "CADWindow";
            this.Size = new System.Drawing.Size(683, 424);
            this.ResumeLayout(false);
        }
    }
}
