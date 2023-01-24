using MaterialSkin.Controls;
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
        public string palabraSeleccionada = "";
        private int puntuación = 0;
        private int contador = 0;
        Categories categories = new Categories();

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
                Categorias.Animales.VerificarPalabra(lblPuntuacion, juegoAni, ref palabraSeleccionada, ref puntuación, ref contador);
            }
            else if (Categories.bebidas_Clicked)
            {
                Categorias.Bebidas.VerificarPalabra(lblPuntuacion, juegoBebi, ref palabraSeleccionada, ref puntuación, ref contador);
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
            }
            
        }

    }
}
