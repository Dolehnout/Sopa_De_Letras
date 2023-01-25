using MaterialSkin.Controls;
using MetroSet_UI.Forms;
using Sopa_De_Letras.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sopa_De_Letras
{
    public partial class MainGame : Form
    {
        public int fila, columna, direccion;
        private DateTime startTime;
        Random letras = new Random();
        Animales.Juego juegoAni = new Animales.Juego();
        Bebidas.Juego juegoBebi = new Bebidas.Juego();
        Colores.Juego juegoColor = new Colores.Juego();
        Empresas.Juego juegoEmpresa = new Empresas.Juego();
        Frutas.Juego juegoFrutas = new Frutas.Juego();
        Nombres.Juego juegoNombres = new Nombres.Juego();
        Objetos.Juego juegoObjetos = new Objetos.Juego();
        Países.Juego juegoPaises = new Países.Juego();
        RedesSociales.Juego juegoSocialMedia = new RedesSociales.Juego();
        Vegetales.Juego juegoVegetales = new Vegetales.Juego();
        public string palabraSeleccionada = "";
        private int puntuación = 0;
        private int contador = 0;
        Categories categories = new Categories();
        private DataGridViewCell ultimaCeldaSelecionada;


        public MainGame()
        {
            InitializeComponent();

            if (Categories.animales_Clicked == true)
            {
                Categorias.Animales.generarSopa(Sopa, juegoAni, letras);
            }
            else if (Categories.bebidas_Clicked == true)
            {
                Categorias.Bebidas.generarSopa(Sopa, juegoBebi, letras);
            }
            else if (Categories.colores_Clicked == true)
            {
                Categorias.Colores.generarSopa(Sopa, juegoColor, letras);
            }
            else if (Categories.empresas_Clicked == true)
            {
                Categorias.Empresas.generarSopa(Sopa, juegoEmpresa, letras);
            }
            else if (Categories.frutas_Clicked == true)
            {
                Categorias.Frutas.generarSopa(Sopa, juegoFrutas, letras);
            }
            else if (Categories.nombres_Clicked == true)
            {
                Categorias.Nombres.generarSopa(Sopa, juegoNombres, letras);
            }
            else if (Categories.objetos_Clicked == true)
            {
                Categorias.Objetos.generarSopa(Sopa, juegoObjetos, letras);
            }
            else if (Categories.paises_Clicked == true)
            {
                Categorias.Países.generarSopa(Sopa, juegoPaises, letras);
            }
            else if (Categories.redesSociales_Clicked == true)
            {
                Categorias.RedesSociales.generarSopa(Sopa, juegoSocialMedia, letras);
            }
            else if (Categories.vegetales_Clicked == true)
            {
                Categorias.Vegetales.generarSopa(Sopa, juegoVegetales, letras);
            }
            
            
            timer1.Interval = 1000;
            startTime = DateTime.Now;
            timer1.Tick += timer1_Tick_1;

            
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (Categories.animales_Clicked)
            {
                foreach (string palabra in juegoAni.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.bebidas_Clicked)
            {
                foreach (string palabra in juegoBebi.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.colores_Clicked == true)
            {
                foreach (string palabra in juegoColor.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.empresas_Clicked == true)
            {
                foreach (string palabra in juegoEmpresa.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.frutas_Clicked == true)
            {
                foreach (string palabra in juegoFrutas.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.nombres_Clicked == true)
            {
                foreach (string palabra in juegoNombres.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.objetos_Clicked == true)
            {
                foreach (string palabra in juegoObjetos.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.paises_Clicked == true)
            {
                foreach (string palabra in juegoPaises.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.redesSociales_Clicked == true)
            {
                foreach (string palabra in juegoSocialMedia.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }
            else if (Categories.vegetales_Clicked== true)
            {
                foreach (string palabra in juegoVegetales.palabrasOcultas)
                {
                    lblPalabrasBuscar.Text += Environment.NewLine + palabra;
                }
            }


        }
        public void timer1_Tick_1(object sender, EventArgs e)
        {
            //Aquí se actualiza el texto del label
            TimeSpan elapsed = DateTime.Now - startTime;
            label1.Text = "Tiempo transcurrido: " + elapsed.ToString("h\\:mm\\:ss");
        }

        private void Sopa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Guardamos la letra de la celda seleccionada en una variable temporal
            string temporal = Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            // Verificamos si la celda seleccionada está en una posición contigua a la última celda seleccionada
            if (ultimaCeldaSelecionada != null)
            {
                if (e.RowIndex != ultimaCeldaSelecionada.RowIndex && e.ColumnIndex != ultimaCeldaSelecionada.ColumnIndex)
                {
                    MessageBox.Show("¡No puede hacer eso, tramposo!");
                    return;
                }
            }

            ultimaCeldaSelecionada = Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex];

            Console.WriteLine(palabraSeleccionada);

            // Si la celda seleccionada es verde, la deseleccionamos y quitamos la letra temporal del string palabraSeleccionada
            if (Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Green)
            {
                Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Sopa.DefaultCellStyle.BackColor;
                palabraSeleccionada = palabraSeleccionada.Remove(palabraSeleccionada.Length - temporal.Length);
            }
            //Si la celda seleccionada no es verde, la seleccionamos y agregamos la letra temporal al string palabraSeleccionada
            else
            {
                Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                palabraSeleccionada += temporal;
            }
            // Verificamos si la palabra seleccionada coincide con alguna de las palabras ocultas
            if (Categories.animales_Clicked == true)
            {
                Categorias.Animales.VerificarPalabra(lblPuntuacion, juegoAni, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.bebidas_Clicked)
            {
                Categorias.Bebidas.VerificarPalabra(lblPuntuacion, juegoBebi, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.colores_Clicked)
            {
                Categorias.Colores.VerificarPalabra(lblPuntuacion, juegoColor, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.empresas_Clicked)
            {
                Categorias.Empresas.VerificarPalabra(lblPuntuacion, juegoEmpresa, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.frutas_Clicked)
            {
                Categorias.Frutas.VerificarPalabra(lblPuntuacion, juegoFrutas, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.nombres_Clicked)
            {
                Categorias.Nombres.VerificarPalabra(lblPuntuacion, juegoNombres, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.objetos_Clicked)
            {
                Categorias.Objetos.VerificarPalabra(lblPuntuacion, juegoObjetos, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.redesSociales_Clicked)
            {
                Categorias.RedesSociales.VerificarPalabra(lblPuntuacion, juegoSocialMedia, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.paises_Clicked)
            {
                Categorias.Países.VerificarPalabra(lblPuntuacion, juegoPaises, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            else if (Categories.vegetales_Clicked)
            {
                Categorias.Vegetales.VerificarPalabra(lblPuntuacion, juegoVegetales, ref palabraSeleccionada, ref puntuación, ref contador, ref ultimaCeldaSelecionada);
            }
            Ganar();

        }

        private void Ganar()
        {
            if (contador == 9)
            {
                Sopa.Enabled = false;
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                label2.Enabled = true;
                label2.BringToFront();
                label2.Visible = true;
                lblPalabrasBuscar.Visible = false;
                timer1.Stop();
            }
            
        }

    }
}
