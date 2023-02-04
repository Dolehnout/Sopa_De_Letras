using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopa_De_Letras.DAO
{

    public class EstadisticasDAO
    {
        private string cadenaConexion = @"Server=localhost; database=LetterSoup; integrated security=true";

        public int guardar(Estadisticas estadistica)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            string sql = "insert into estadisticas(puntuacion, tiempo, nombre) values (@puntuacion, @tiempo, @nombre)";

            SqlCommand comando = new SqlCommand(sql, conexion);

            //Abrir la conexión
            conexion.Open();

            comando.Parameters.Add(new SqlParameter("@puntuacion", estadistica.puntuacion));
            comando.Parameters.Add(new SqlParameter("@tiempo", estadistica.tiempo));
            comando.Parameters.Add(new SqlParameter("@nombre", estadistica.nombre));

            //Ejecutar el comando | Se encarga de guardar el registro en la Base de Datos
            int resultado = comando.ExecuteNonQuery();

            //Cerrar la conexión
            conexion.Close();

            return resultado;
        }
        public int compararValor(string valor)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = "SELECT COUNT(*) FROM estadisticas WHERE nombre = @value";
                using (SqlCommand command = new SqlCommand(sql, conexion))
                {
                    command.Parameters.AddWithValue("@value", valor);
                    int result = (int)command.ExecuteScalar();

                    return result;
                }
            }
        }
        public int actualizarEstadisticas(Estadisticas estadisticas)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = "UPDATE estadisticas SET puntuacion=@puntuacion, tiempo=@tiempo WHERE nombre=@nombre";
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@puntuacion", estadisticas.puntuacion);
                    comando.Parameters.AddWithValue("@tiempo", estadisticas.tiempo);
                    comando.Parameters.AddWithValue("@nombre", estadisticas.nombre);
                    int result = (int)comando.ExecuteNonQuery();

                    return result;
                }
            }
        }
        public Array ranking()
        {
            string sql = "SELECT puntuacion, tiempo, nombre FROM estadisticas ORDER BY puntuacion DESC";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var result = new List<(int score, string time, string name)>();
                        while (reader.Read())
                        {
                            result.Add((score: reader.GetInt32(0), time: reader.GetString(1), name: reader.GetString(2)));
                        }
                        return result.ToArray();
                    }
                }
            }
        }
    }
}
