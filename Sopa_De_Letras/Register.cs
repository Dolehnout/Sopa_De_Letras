using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sopa_De_Letras
{
    public partial class Register : MaterialForm
    {
        


        public Register()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan400, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

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
    }
}
