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
            Control.Load += CADView3D_Load;
            Control.Paint += CadView_Paint;

            Document.DocumentChanged += Document_Changed;
        }
        public void Redraw()
        {
            Control.Invalidate();
        }
        public void Render()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(0, 0, zoom),
                Vector3.Zero,
                Vector3.UnitY);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
            GL.Rotate(rotationX, 1, 0, 0);
            GL.Rotate(rotationY, 0, 1, 0);

            DrawAxes();
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

        private void DrawDocument()
        {
            if (Document == null) return;

            //// Z=0の面
            //GL.Begin(PrimitiveType.Triangles);

            //GL.Color3(Color.LightBlue);

            //// 四角形 (v0, v1, v2, v3)
            //Vector3 v0 = new Vector3(-50, -50, 0);
            //Vector3 v1 = new Vector3(-50, 50, 0);
            //Vector3 v2 = new Vector3(50, 50, 0);
            //Vector3 v3 = new Vector3(50, -50, 0);

            //// 三角形1
            //GL.Vertex3(v0);
            //GL.Vertex3(v1);
            //GL.Vertex3(v2);

            //// 三角形2
            //GL.Vertex3(v0);
            //GL.Vertex3(v2);
            //GL.Vertex3(v3);

            //GL.End();


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
        private void CADView3D_Load(object sender, EventArgs e)
        {
            GL.ClearColor(System.Drawing.Color.Black);
            GL.Enable(EnableCap.DepthTest);
        }
        private void Document_Changed(object sender, EventArgs e)
        {
            Redraw();
        }
        void CadView_Paint(object sender, PaintEventArgs e)
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
