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
using System.Net;

namespace Sopa_De_Letras
{
    public partial class Login : MaterialForm
    {
        public Font ROBOTO_MEDIUM_12;
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
            string tempPath = System.IO.Path.GetTempPath();
            WebClient client = new WebClient();
            string[] urls = { "https://cdn.discordapp.com/attachments/1052651229131571230/1066167495028908112/coollogo_com-154781609.gif",
                "https://cdn.discordapp.com/attachments/1052651229131571230/1066174454322962502/coollogo_com-7921128.gif", 
                "https://cdn.discordapp.com/attachments/1052651229131571230/1066175702128394280/coollogo_com-135373019.gif" };
            Random rnd = new Random();
            var aleatorio = rnd.Next(2)+1;
            client.DownloadFile(urls[aleatorio], tempPath + "image.gif");
            Image image = Image.FromFile(tempPath + "image.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = image;
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

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register = new Register();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }
    }  
}
