using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using PLN.Drawables;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace PLN
{
    [Docking(DockingBehavior.Ask)]
    public class CADWindow3D : GLControl
    {
        [Browsable(false)]
        public CADDocument Document { get; set; }
        [Browsable(false)]
        public CADView3D View { get; private set; }

        private float rotationX = 30f;
        private float rotationY = -45f;
        private float zoom = -10f;

        public CADWindow3D(CADDocument doc)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.DoubleBuffer, false);
            UpdateStyles();
            DoubleBuffered = false;

            BorderStyle = BorderStyle.Fixed3D;

            Document = doc;
            View = new CADView3D(this, Document);

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

        private Point lastMouse;
        private void CADWindow3D_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rotationY += (e.X - lastMouse.X);
                rotationX += (e.Y - lastMouse.Y);
                Invalidate();
            }
            lastMouse = e.Location;
        }

        private void CADWindow3D_MouseWheel(object sender, MouseEventArgs e)
        {
            zoom += e.Delta * 0.01f;
            Invalidate();
        }
    }
}
