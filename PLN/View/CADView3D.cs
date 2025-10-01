using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using PLN.Elements;
using PLN.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace PLN
{
    public sealed class CADView3D : IDisposable
    {

        private float rotationX = 30f;
        private float rotationY = -45f;
        private float zoom = -10f;

        [Browsable(false)]
        public CADWindow3D Control { get; private set; }

        [Browsable(false)]
        public CADDocument Document { get; private set; }

        public CADView3D(CADWindow3D ctrl, CADDocument document)
        {
            Control = ctrl;
            Document = document;

            Redraw();

            Control.Dock = DockStyle.Fill;
            Control.Load += CadView3D_Load;
            Control.Paint += CadView3D_Paint;
            Control.Resize += CadView3D_Resize;
            Control.MouseMove += CadView3D_MouseMove;
            Control.MouseWheel += CadView3D_MouseWheel;

            Document.DocumentChanged += Document_Changed;
        }
        public void Redraw()
        {
            Control.Invalidate();
        }
        private void CadView3D_Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, Control.Width, Control.Height);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4, (float)Control.Width / Control.Height, 1.0f, 1000.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }
        public void Render()
        {
            // Start drawing
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(0, 0, zoom),
                Vector3.Zero,
                Vector3.UnitY);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
            GL.Rotate(rotationX, 1, 0, 0);
            GL.Rotate(rotationY, 0, 1, 0);

            // Axes
            DrawAxes();

            // Render drawing objects
            //DrawDocumentSample();
            DrawDocument();

            Control.SwapBuffers();
        }
        private void DrawAxes()
        {
            GL.Begin(PrimitiveType.Lines);
            GL.LineWidth(10.0f);

            // X軸 (赤)
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(10, 0, 0);

            // Y軸 (緑)
            GL.Color3(Color.Green);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 10, 0);

            // Z軸 (青)
            GL.Color3(Color.Blue);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, 10);

            GL.End();
        }

        private void DrawDocumentSample()
        {
            if (Document == null) return;

            // さいころ

            GL.Begin(PrimitiveType.Lines);

            GL.Color3(Color.White);

            // 面1
            GL.Vertex3(10, 20, 10);
            GL.Vertex3(10, 10, 10);

            GL.Vertex3(10, 10, 10);
            GL.Vertex3(20, 10, 10);

            GL.Vertex3(20, 10, 10);
            GL.Vertex3(20, 20, 10);

            GL.Vertex3(10, 20, 10);
            GL.Vertex3(20, 20, 10);

            GL.Vertex3(20, 20, 10);
            GL.Vertex3(10, 20, 10);

            // 面2
            GL.Vertex3(10, 20, 20);
            GL.Vertex3(10, 10, 20);

            GL.Vertex3(10, 10, 20);
            GL.Vertex3(20, 10, 20);

            GL.Vertex3(20, 10, 20);
            GL.Vertex3(20, 20, 20);

            GL.Vertex3(10, 20, 20);
            GL.Vertex3(20, 20, 20);

            GL.Vertex3(20, 20, 20);
            GL.Vertex3(10, 20, 20);

            // 面1と面2の間
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, 10, 20);

            GL.Vertex3(20, 10, 10);
            GL.Vertex3(20, 10, 20);

            GL.Vertex3(20, 20, 10);
            GL.Vertex3(20, 20, 20);

            GL.Vertex3(10, 20, 10);
            GL.Vertex3(10, 20, 20);


            GL.End();
        }
        private void DrawDocument()
        {
            if (Document == null) return;

            foreach (var element in Document.Model.OfType<Element>())
            {
                element.Draw3D();

            }
        }
        private void CadView3D_Load(object sender, EventArgs e)
        {
            GL.ClearColor(System.Drawing.Color.Black);
            GL.Enable(EnableCap.DepthTest);
        }
        private void Document_Changed(object sender, EventArgs e)
        {
            Redraw();
        }
        void CadView3D_Paint(object sender, PaintEventArgs e)
        {
            Render();
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
                Control.Paint -= CadView3D_Paint;
                //Control.MouseEnter -= CadView_MouseEnter;
                //Control.MouseLeave -= CadView_MouseLeave;
                Control.Load -= CadView3D_Load;
                Control.Paint -= CadView3D_Paint;
                Control.Resize -= CadView3D_Resize;
                Control.MouseMove -= CadView3D_MouseMove;
                Control.MouseWheel -= CadView3D_MouseWheel;
            }

            //if (renderer != null)
            //{
            //    renderer.Dispose();
            //    renderer = null;
            //}
        }
        private Point lastMouse;
        private void CadView3D_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rotationY += (e.X - lastMouse.X);
                rotationX += (e.Y - lastMouse.Y);
                Control.Invalidate();
            }
            lastMouse = e.Location;
        }

        private void CadView3D_MouseWheel(object sender, MouseEventArgs e)
        {
            zoom += e.Delta * 0.01f;
            Control.Invalidate();
        }
    }
}
