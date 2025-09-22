using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using PLN.Drawables;
using System;
using System.Windows.Forms;

namespace PLN
{
    public class CADWindow3D : GLControl
    {
        public CADDocument Document { get; set; }

        private float rotationX = 30f;
        private float rotationY = -45f;
        private float zoom = -10f;

        public CADWindow3D()
            : base(new GraphicsMode(32, 24, 0, 4))
        {
            this.Dock = DockStyle.Fill;
            this.Load += CADWindow3D_Load;
            this.Paint += CADWindow3D_Paint;
            this.Resize += CADWindow3D_Resize;
            this.MouseMove += CADWindow3D_MouseMove;
            this.MouseWheel += CADWindow3D_MouseWheel;
        }

        private void CADWindow3D_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.Enable(EnableCap.DepthTest);
        }

        private void CADWindow3D_Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4, (float)Width / Height, 1.0f, 1000.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        private void CADWindow3D_Paint(object sender, PaintEventArgs e)
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

            this.SwapBuffers();
        }

        private void DrawAxes()
        {
            GL.Begin(PrimitiveType.Lines);

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

            // サンプル: Document 内の Line を描画するイメージ
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Lines);

            //foreach (var entity in Document.Entities)
            //{
            //    if (entity is Line ln)
            //    {
            //        GL.Vertex3(ln.Start.X, ln.Start.Y, ln.Start.Z);
            //        GL.Vertex3(ln.End.X, ln.End.Y, ln.End.Z);
            //    }
            //}

            GL.End();
        }

        //private Point lastMouse;
        private void CADWindow3D_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    rotationY += (e.X - lastMouse.X);
            //    rotationX += (e.Y - lastMouse.Y);
            //    Invalidate();
            //}
            //lastMouse = e.Location;
        }

        private void CADWindow3D_MouseWheel(object sender, MouseEventArgs e)
        {
            zoom += e.Delta * 0.01f;
            Invalidate();
        }
    }
}
