using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Getting access to Marshall class:
//  *Marshall
using System.Runtime.InteropServices;
// Getting access to OpenGl classes:
//  *Gl
//  *Glu
using Tao.OpenGl;
// Getting access to OpenGl classes:
//  *Wgl
//  *GDI
//  *User
using Tao.Platform.Windows;

namespace MeshGridDrawer
{
    public partial class Form1 : Form
    {
        private IntPtr Handle3D;
        private IntPtr HDC3D;
        private IntPtr HRC3D;

        // Initeal position of the viewer
        private float r = 10;
        private float phi = 30;
        private float psi = 30;

        // true - рисование с освещением
        // false - рисование без освещения
        private bool lightningState = true;

        // Using fonts
        private int Font3D = 0;

        // Texture
        // uint Texture = LoadTexture(@"D:\Programing\C#\OpenGl\Practive2\OpenGlForm\OpenGlForm\Grani2.bmp");
        private uint Texture = 0;

        // Name of the opening file
        private string fileName;

        // Storage of function values
        private GRDContainer valueContainer;
        public Form1()
        {
            InitializeComponent();

            // Use Form to draw in it
            Handle3D = Handle;
            HDC3D = User.GetDC(Handle3D);
            Gdi.PIXELFORMATDESCRIPTOR PFD = new Gdi.PIXELFORMATDESCRIPTOR();
            PFD.nVersion = 1;
            PFD.nSize = (short)Marshal.SizeOf(PFD);
            PFD.dwFlags =
                Gdi.PFD_DRAW_TO_WINDOW |
                Gdi.PFD_SUPPORT_OPENGL |
                Gdi.PFD_DOUBLEBUFFER;
            PFD.iPixelType = Gdi.PFD_TYPE_RGBA;
            PFD.cColorBits = 24;
            PFD.cDepthBits = 32;
            PFD.iLayerType = Gdi.PFD_MAIN_PLANE;

            int nPixelFormat = Gdi.ChoosePixelFormat(HDC3D, ref PFD);
            Gdi.SetPixelFormat(HDC3D, nPixelFormat, ref PFD);

            HRC3D = Wgl.wglCreateContext(HDC3D);
            Wgl.wglMakeCurrent(HDC3D, HRC3D);

            Gl.glEnable(Gl.GL_DEPTH_TEST);

            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //CreateFont3D(Font);

            //Texture = LoadTexture("Grani2.bmp");
            Form1_Resize(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }
        }

        private void ParseOpenedFile_Click(object sender, EventArgs e)
        {
            valueContainer = GRDParser.ParseFile(fileName);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            // Properties of the WinForm
            int w = ClientRectangle.Width - UIpanel.Width;
            int h = ClientRectangle.Height;

            Glu.gluPerspective(30, (double)w / h, 2, 20000);
            Gl.glViewport(0, 0, w, h);
        }

        private void InvalidateRect()
        {
            GLSettings.InvalidateRect(Handle, IntPtr.Zero, false);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 1); // Dummy zeros
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0, 0, -r);
            Gl.glRotatef(phi, 1f, 0, 0);
            Gl.glRotatef(psi, 0, 1f, 0);

            drawCoordinateSystem(); // Dummy

            Gl.glFinish();
            Gdi.SwapBuffers(HDC3D);
        }

        /// ----------- Draw things part ----------- ///
        private void drawCoordinateSystem()
        {
            // ----------- Начало координат -----------
            Gl.glPointSize(10);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);

            Gl.glBegin(Gl.GL_POINTS);
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glVertex3d(0.0, 0.0, 0.0);
            Gl.glEnd();
            // ----------------------------------------

            //// ------------ Оси координат -------------
            Gl.glLineWidth(1);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex3d(0, 0, 0); // Ось х
            Gl.glVertex3d(2, 0, 0);

            Gl.glColor3f(0, 1, 0);
            Gl.glVertex3d(0, 0, 0); // Ось у
            Gl.glVertex3d(0, 2, 0);

            Gl.glColor3f(0, 0, 1);
            Gl.glVertex3d(0, 0, 0); // Ось z
            Gl.glVertex3d(0, 0, 2);
            Gl.glEnd();

            //outText3D(2, 0, 0, "x");
            //outText3D(0, 2, 0, "y");
            //outText3D(0, 0, 2, "z");
            //// ----------------------------------------
        }

        private void trackBarTheta_Scroll(object sender, EventArgs e)
        {
            this.phi = trackBarR.Value;
            InvalidateRect();
        }

        private void trackBarPsi_Scroll(object sender, EventArgs e)
        {
            this.psi = trackBarR.Value;
            InvalidateRect();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            this.r = trackBarR.Value / 10.0f;
            InvalidateRect();
        }
        /// ----------- Draw things part ----------- ///
    }
}
