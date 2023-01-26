using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sopa_De_Letras.Categorias
{
    public class Países
    {
        public int fila, columna, direccion;

        public static void VerificarPalabra(Label lblPuntuacion, Juego miJuego, ref string palabraSeleccionada, ref int puntuación, ref int contador, ref DataGridViewCell ultimaCeldaSelecionada)
        {
            // Recorremos las palabras ocultas
            foreach (string palabraOculta in miJuego.palabrasOcultas)
            {
                // Verificamos si la palabra seleccionada es igual a la palabra oculta
                if (palabraSeleccionada.Equals(palabraOculta))
                {
                    MessageBox.Show("Palabra encontrada!");
                    // Resetemos la palabra seleccionada para buscar otras
                    palabraSeleccionada = "";
                    puntuación += 100;
                    contador += 1;
                    lblPuntuacion.Text = "Su puntuacion: " + puntuación.ToString();
                    ultimaCeldaSelecionada = null;
                    return;
                }
                else
                {
                    // Generamos todas las permutaciones de la palabra seleccionada
                    List<string> permutations = PermuteString(palabraSeleccionada);
                    // Recorremos cada permutacion
                    foreach (string permutation in permutations)
                    {
                        // Comparamos la permutacion con la palabra oculta actual
                        if (permutation.Equals(palabraOculta))
                        {
                            MessageBox.Show("Palabra encontrada!");
                            // Resetemos la palabra seleccionada para buscar otras
                            palabraSeleccionada = "";
                            puntuación += 100;
                            contador += 1;
                            lblPuntuacion.Text = "Su puntuacion: " + puntuación.ToString();
                            ultimaCeldaSelecionada = null;
                            return;
                        }
                    }
                }
            }
        }
        public static List<string> PermuteString(string str)
        {
            List<string> permutations = new List<string>();
            // Caso base: si la cadena es vacía o tiene un solo caracter, solo hay una permutación
            if (str.Length == 0)
            {
                permutations.Add("");
                return permutations;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string prefix = str.Substring(i, 1);
                    string remaining = str.Substring(0, i) + str.Substring(i + 1);
                    List<string> subPermutations = PermuteString(remaining);
                    foreach (string subPermutation in subPermutations)
                    {
                        permutations.Add(prefix + subPermutation);
                    }
                }
                return permutations;
            }
        }

        public static void generarSopa(DataGridView Sopa, Juego miJuego, Random letras)
        {
            Sopa.RowCount = 15;
            Sopa.ColumnCount = 15;

            miJuego.agregarPalabraOculta("SUECIA");
            miJuego.agregarPalabraOculta("DINAMARCA");
            miJuego.agregarPalabraOculta("FINLANDIA");
            miJuego.agregarPalabraOculta("ECUADOR");
            miJuego.agregarPalabraOculta("TURQUIA");
            miJuego.agregarPalabraOculta("AUSTRALIA");
            miJuego.agregarPalabraOculta("GALES");
            miJuego.agregarPalabraOculta("ISLANDIA");
            miJuego.agregarPalabraOculta("BELGICA");


            foreach (string palabra in miJuego.palabrasOcultas)
            {
                bool palabraColocada = false;
                while (!palabraColocada)
                {
                    //Generar posición aleatoria
                    int fila = letras.Next(0, Sopa.RowCount);
                    int columna = letras.Next(0, Sopa.ColumnCount);
                    int direccion = letras.Next(0, 4); // 0 = arriba, 1 = abajo, 2 = derecha, 3 = izquierda

                    //Validar si la dirección y la longitud de la palabra es válida
                    if (direccion == 0 && fila - palabra.Length < 0) continue; //arriba
                    if (direccion == 1 && fila + palabra.Length >= Sopa.RowCount) continue; //abajo
                    if (direccion == 2 && columna + palabra.Length >= Sopa.ColumnCount) continue; //derecha
                    if (direccion == 3 && columna - palabra.Length < 0) continue; //izquierda

                    //Coloca la palabra en el DataGridView
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
        public class Juego
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


