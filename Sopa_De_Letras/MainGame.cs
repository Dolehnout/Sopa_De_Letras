using MaterialSkin.Controls;
using MetroSet_UI.Forms;
using Sopa_De_Letras.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public TimeSpan duracion;
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
        public int puntuación = 0;
        private int contador = 0;
        public string tiempo;
        private DataGridViewCell ultimaCeldaSelecionada;


        public MainGame()
        {
            InitializeComponent();

            if (Categories.animales_Clicked)
            {
                Categorias.Animales.generarSopa(Sopa, juegoAni, letras);
            }
            else if (Categories.bebidas_Clicked)
            {
                Categorias.Bebidas.generarSopa(Sopa, juegoBebi, letras);
            }
            else if (Categories.colores_Clicked)
            {
                Categorias.Colores.generarSopa(Sopa, juegoColor, letras);
            }
            else if (Categories.empresas_Clicked)
            {
                Categorias.Empresas.generarSopa(Sopa, juegoEmpresa, letras);
            }
            else if (Categories.frutas_Clicked)
            {
                Categorias.Frutas.generarSopa(Sopa, juegoFrutas, letras);
            }
            else if (Categories.nombres_Clicked)
            {
                Categorias.Nombres.generarSopa(Sopa, juegoNombres, letras);
            }
            else if (Categories.objetos_Clicked)
            {
                Categorias.Objetos.generarSopa(Sopa, juegoObjetos, letras);
            }
            else if (Categories.paises_Clicked)
            {
                Categorias.Países.generarSopa(Sopa, juegoPaises, letras);
            }
            else if (Categories.redesSociales_Clicked)
            {
                Categorias.RedesSociales.generarSopa(Sopa, juegoSocialMedia, letras);
            }
            else if (Categories.vegetales_Clicked)
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

            lblNombre.Text += Environment.NewLine + Login.usernameSeleccionado;

        }
        /// <summary>
        /// Función para hacer operaciones con el tiempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer1_Tick_1(object sender, EventArgs e)
        {
            duracion = DateTime.Now - startTime;
            

            //Aquí se actualiza el texto del label
            TimeSpan elapsed = DateTime.Now - startTime;
            label1.Text = "Tiempo transcurrido: " + elapsed.ToString("h\\:mm\\:ss");
        }

        private void metroRegresar_Click(object sender, EventArgs e)
        {
            Categories.animales_Clicked = false;
            Categories.bebidas_Clicked = false;
            Categories.colores_Clicked = false;
            Categories.empresas_Clicked = false;
            Categories.nombres_Clicked = false;
            Categories.frutas_Clicked = false;
            Categories.objetos_Clicked = false;
            Categories.paises_Clicked = false;
            Categories.redesSociales_Clicked = false;
            Categories.vegetales_Clicked = false;

            this.Hide();
            var categories = new Categories();
            categories.Closed += (s, args) => this.Close();
            categories.Show();
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
            try
            {
                if (contador == 9)
                {
                    Sopa.Enabled = false;
                    pictureBox1.Enabled = true;
                    pictureBox1.Visible = true;
                    lblGanaste.Enabled = true;
                    lblGanaste.BringToFront();
                    lblGanaste.Visible = true;
                    lblPalabrasBuscar.Visible = false;
                    timer1.Stop();



                    Console.WriteLine(tiempo);
                    puntuación = duracion.TotalMinutes < 1 ? puntuación *= 5 : puntuación;
                    puntuación = duracion.TotalMinutes >= 1 && duracion.TotalMinutes < 2 ? puntuación *= 4 : puntuación;
                    puntuación = duracion.TotalMinutes >= 2 && duracion.TotalMinutes < 3 ? puntuación *= 3 : puntuación;
                    puntuación = duracion.TotalMinutes >= 3 && duracion.TotalMinutes < 4 ? puntuación *= 2 : puntuación;
                    tiempo = duracion.ToString("h\\:mm\\:ss");

                    lblPuntuacionTotal.Enabled = true;
                    lblPuntuacionTotal.Visible = true;
                    lblPuntuacionTotal.Text += Environment.NewLine + puntuación.ToString();
                    lblPuntuacionTotal.BringToFront();

                    lblTiempoTotal.Enabled = true;
                    lblTiempoTotal.Visible = true;
                    lblTiempoTotal.Text += Environment.NewLine + tiempo;
                    lblTiempoTotal.BringToFront();

                    Console.WriteLine(puntuación);

                    DAO.Estadisticas estadisticas = new DAO.Estadisticas();
                    estadisticas.puntuacion = puntuación;
                    estadisticas.tiempo = tiempo;
                    estadisticas.nombre = Login.usernameSeleccionado;

                    DAO.EstadisticasDAO dAO = new DAO.EstadisticasDAO();
                    int y = dAO.compararValor(estadisticas.nombre);
                    if (y > 0)
                    {
                        dAO.actualizarEstadisticas(estadisticas);
                    }
                    else
                    {
                        dAO.guardar(estadisticas);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No puedes registrar puntuaciones con el usuario Predeterminado");
            }
        }
    }
}
