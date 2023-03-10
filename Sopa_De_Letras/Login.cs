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
using Sopa_De_Letras.DAO;
using System.IO;

namespace Sopa_De_Letras
{
    public partial class Login : MaterialForm
    {
        public static string usernameSeleccionado;
        public bool BaseDatos = true;
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
            string imagePath = tempPath + "image.gif";
            if (!File.Exists(imagePath))
            {
                
                WebClient client = new WebClient();
                string[] urls = { "https://cdn.discordapp.com/attachments/1052651229131571230/1066167495028908112/coollogo_com-154781609.gif",
                "https://cdn.discordapp.com/attachments/1052651229131571230/1066174454322962502/coollogo_com-7921128.gif",
                "https://cdn.discordapp.com/attachments/1052651229131571230/1066175702128394280/coollogo_com-135373019.gif" };
                Random rnd = new Random();
                var aleatorio = rnd.Next(2) + 1;

                client.DownloadFile(urls[aleatorio], tempPath + "image.gif");
                client.Dispose();
            }
            Image image = Image.FromFile(tempPath + "image.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = image;

            DatesDAO dao = new DatesDAO();
            //materialComboBox1.DataSource = dao.buscarRegistro("");
            //materialComboBox1.DisplayMember = "username";
            try
            {
                dao.buscarRegistro(materialComboBox1);
            }
            catch (Exception)
            {
                MessageBox.Show("Parece que no se ha encontrado una base de" +
                    " datos a la cual conectarse, solo se activará el usuario Predeterminado");
                BaseDatos = false;
            }
            if (BaseDatos == false)
            {
                materialButton3.Enabled = false;
            }
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

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            usernameSeleccionado = materialComboBox1.SelectedItem.ToString();
            Console.WriteLine( materialComboBox1.SelectedItem.ToString());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var categories = new Categories();
            categories.Closed += (s, args) => this.Close();
            categories.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var categories = new TopPlayers();
            categories.Closed += (s, args) => this.Close();
            categories.Show();
        }
    }  
}
