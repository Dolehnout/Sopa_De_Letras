using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        //public static string[] palabrasOcultas = new string[] { "Conejo", "Capibara", "Avestruz", "Manul", "Gato", "Perro", "Conejo", 

        //"Morsa"};

        public MainGame()
        {

            InitializeComponent();

            
            generarSopa();
            timer1.Interval = 1000;
            startTime = DateTime.Now;
            timer1.Tick += timer1_Tick_1;
            
        }

        private void Sopa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Green)
            {
                Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Sopa.DefaultCellStyle.BackColor;
            }
            else
            {
                Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //aqui se actualiza el texto del label
            TimeSpan elapsed = DateTime.Now - startTime;
            label1.Text = "Tiempo transcurrido: " + elapsed.ToString("h\\:mm\\:ss");
        }

        public void generarSopa()
        {
            Sopa.RowCount = 15;
            Sopa.ColumnCount = 15;

            Juego miJuego = new Juego();
            miJuego.agregarPalabraOculta("conejo");
            miJuego.agregarPalabraOculta("capibara");
            miJuego.agregarPalabraOculta("avestruz");
            miJuego.agregarPalabraOculta("manul");
            miJuego.agregarPalabraOculta("gato");
            miJuego.agregarPalabraOculta("perro");
            miJuego.agregarPalabraOculta("serval");
            miJuego.agregarPalabraOculta("bobcat");
            miJuego.agregarPalabraOculta("hipopotamo");

            foreach (string palabra in miJuego.palabrasOcultas)
            {
                bool palabraColocada = false;
                while (!palabraColocada)
                {
                    //Generate random position
                    int fila = letras.Next(0, Sopa.RowCount);
                    int columna = letras.Next(0, Sopa.ColumnCount);
                    int direccion = letras.Next(0, 4); // 0 = up, 1 = down, 2 = right, 3 = left

                    //Validate if the direction and the length of the word is valid
                    if (direccion == 0 && fila - palabra.Length < 0) continue; //up
                    if (direccion == 1 && fila + palabra.Length >= Sopa.RowCount) continue; //down
                    if (direccion == 2 && columna + palabra.Length >= Sopa.ColumnCount) continue; //right
                    if (direccion == 3 && columna - palabra.Length < 0) continue; //left

                    //Place the word in the DataGridView
                    palabraColocada = true;
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (direccion == 0) // arriba
                        {
                            if (fila - i >= 0 && Sopa[columna, fila - i].Value == null)
                            {
                                Sopa[columna, fila - i].Value = palabra[i];
                            }
                            else
                            {
                                palabraColocada = false;
                                break;
                            }
                        }
                        else if (direccion == 1) // abajo
                        {
                            if (fila + i < Sopa.RowCount && Sopa[columna, fila + i].Value == null)
                            {
                                Sopa[columna, fila + i].Value = palabra[i];
                            }
                            else
                            {
                                palabraColocada = false;
                                break;
                            }
                        }
                        else if (direccion == 2) // derecha
                        {
                            if (columna + i < Sopa.ColumnCount && Sopa[columna + i, fila].Value == null)
                            {
                                Sopa[columna + i, fila].Value = palabra[i];
                            }
                            else
                            {
                                palabraColocada = false;
                                break;
                            }
                        }
                        else // izquierda
                        {
                            if (columna - i >= 0 && Sopa[columna - i, fila].Value == null)
                            {
                                Sopa[columna - i, fila].Value = palabra[i];
                            }
                            else
                            {
                                palabraColocada = false;
                                break;
                            }
                        }
                    }

                }
            }
            
            for (int i = 0; i < Sopa.RowCount; i++)
                for (int j = 0; j < Sopa.ColumnCount; j++)
                {
                    if (Sopa[j, i].Value == null)
                    {
                        Sopa[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                    }
                    Sopa.Columns[i].Width = 30;
                }
        }
        class Juego
        {
            public List<string> palabrasOcultas = new List<string>();
            public void agregarPalabraOculta(string palabra)
            {
                palabrasOcultas.Add(palabra);
            }
            public bool esPalabraOculta(string palabra)
            {
                return palabrasOcultas.Contains(palabra);
            }
        }

    }
}
