using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Sopa_De_Letras
{
    public partial class Login : Form
    {
        #region "Customize Controls - Personalizar Controles"

        private void CustomizeComponents()
        {
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle myRectangle = btnLogin.ClientRectangle;
            myRectangle.Inflate(0, 30);
            buttonPath.AddEllipse(myRectangle);
            btnLogin.Region = new Region(buttonPath);
        }

        #endregion

        #region "Close and Minimize Form - Cerrar y Minimizar Formulario"

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region "Drag Form - Arrastrar/ mover Formulario"

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        public Login()
        {
            InitializeComponent();
            /*
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "SOPA DE LETRA";
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            PrivateFontCollection pfc = new PrivateFontCollection();
            string fontPath = "C:\\Users\\USER\\source\\repos\\Sopa_De_Letras\\Sopa_De_Letras\\Fonts\\SpicyChicken.otf";
            pfc.AddFontFile(fontPath);
            label3.Font = new System.Drawing.Font(pfc.Families[0], 30);
           */
        }

        private void test_Load(object sender, EventArgs e)
        {
            CustomizeComponents();
        }

        private void btnLogin_Click(object sender, PaintEventArgs e)
        {
            
        }

        private void test_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
