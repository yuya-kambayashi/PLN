using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLN
{
    public sealed class CADView3D
    {
        [Browsable(false)]
        public Control Control { get; private set; }

        [Browsable(false)]
        public CADDocument Document { get; private set; }
        public CADView3D(Control ctrl, CADDocument document)
        {
            Control = ctrl;
            Document = document;

            Redraw();

            Control.Paint += CadView_Paint;

            Document.DocumentChanged += Document_Changed;
        }
        public void Redraw()
        {
            Control.Invalidate();
        }
        private void Document_Changed(object sender, EventArgs e)
        {
            Redraw();
        }
        void CadView_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
