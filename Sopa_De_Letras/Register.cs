using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sopa_De_Letras
{
    public partial class Register : MaterialForm
    {
        WebClient client = new WebClient();


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

        private void Register_Load(object sender, EventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();
            
            client.DownloadFile("https://media0.giphy.com/media/cXytzXMNWD7UhQUydT/giphy.gif?cid=790b7611281b1ec8ee2f553cdf441806523d31a934793f82&rid=giphy.gif&ct=s", tempPath + "register.gif");
            Image image = Image.FromFile(tempPath + "register.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.Image = image;
            client.Dispose();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * 
                            FALTA: Verificar si se ingresó un usuario y si el usuario ya existe
                 *
                 *
                */
                Sopa_De_Letras.DAO.Dates register = new Sopa_De_Letras.DAO.Dates();
                register.username = this.txtRegistro.Text;

                Sopa_De_Letras.DAO.DatesDAO registerTwo = new Sopa_De_Letras.DAO.DatesDAO();
                
                int x = registerTwo.guardar(register);
                DialogResult dialog = MessageBox.Show(x > 0 ? "Tu nombre ha sido registrado correctamente." : "Tu nombre no ha sido registrado, inténtalo nuevamente.");

                if (dialog == DialogResult.OK)
                {
                    this.Hide();
                    var login = new Login();
                    login.Closed += (s, args) => this.Close();
                    login.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Dispose();
            }
        }
    }
}
