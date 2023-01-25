using MaterialSkin.Controls;
using MetroSet_UI.Forms;
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
    public partial class Categories : MetroSetForm
    {
        public static bool animales_Clicked = false;
        public static bool bebidas_Clicked = false;
        public static bool colores_Clicked = false;
        public static bool empresas_Clicked = false;
        public static bool frutas_Clicked = false;
        public static bool nombres_Clicked = false;
        public static bool objetos_Clicked = false;
        public static bool paises_Clicked = false;
        public static bool redesSociales_Clicked = false;
        public static bool vegetales_Clicked = false;

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
        }

        private void dibujarContorno(object sender, EventArgs e)
        {
            // Obtener una referencia al control PictureBox
            PictureBox pictureBox = (PictureBox)sender;

            pictureBox.BringToFront();

            // Crear un objeto Graphics a partir del control
            Graphics g = pictureBox.CreateGraphics();

            // Establecer el color y el ancho del contorno
            Pen pen = new Pen(Color.White, 3);

            // Dibujar el contorno en torno al control
            g.DrawRectangle(pen, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
        }

        private void eliminarContorno(object sender, EventArgs e)
        {
            // Obtener una referencia al control PictureBox
            PictureBox pictureBox = (PictureBox)sender;

            // Invalidar el área del control para redibujarlo
            pictureBox.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            animales_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bebidas_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colores_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            empresas_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frutas_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            nombres_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            objetos_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            paises_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            redesSociales_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frutas_Clicked = true;
            this.Hide();
            var game = new MainGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }
    }
}
