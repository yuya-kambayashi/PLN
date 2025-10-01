using PLN.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLN
{
    public sealed class CADView3D : IDisposable
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
        public void Dispose()
        {
            if (Document != null)
            {
                Document.DocumentChanged -= Document_Changed;
                //Document.TransientsChanged -= Document_TransientsChanged;
                //Document.SelectionChanged -= Document_SelectionChanged;
                //Document.Editor.Prompt -= Editor_Prompt;
                //Document.Editor.Error -= Editor_Error;
            }

            if (Control != null)
            {
                //Control.Resize -= CadView_Resize;
                //Control.MouseDown -= CadView_MouseDown;
                //Control.MouseUp -= CadView_MouseUp;
                //Control.MouseMove -= CadView_MouseMove;
                //Control.MouseClick -= CadView_MouseClick;
                //Control.MouseDoubleClick -= CadView_MouseDoubleClick;
                //Control.MouseWheel -= CadView_MouseWheel;
                //Control.KeyDown -= CadView_KeyDown;
                //Control.KeyPress -= CadView_KeyPress;
                Control.Paint -= CadView_Paint;
                //Control.MouseEnter -= CadView_MouseEnter;
                //Control.MouseLeave -= CadView_MouseLeave;
            }

            //if (renderer != null)
            //{
            //    renderer.Dispose();
            //    renderer = null;
            //}
        }
    }
}
