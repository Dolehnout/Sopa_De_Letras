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
using MaterialSkin.Controls;
using MaterialSkin;

namespace Sopa_De_Letras
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange300, Primary.DeepOrange400, Primary.DeepOrange800, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.materialLabel1.Font = new Font("Unispace", 14F, FontStyle.Underline);
        }
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            if (materialSkinManager.Theme == MaterialSkinManager.Themes.LIGHT)
            {
                pictureBoxDark.Image = global::Sopa_De_Letras.Properties.Resources.moon;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                pictureBoxDark.Image = global::Sopa_De_Letras.Properties.Resources.sun;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void materialLabel3_MouseEnter(object sender, EventArgs e)
        {
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel);
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }
    }  
}
