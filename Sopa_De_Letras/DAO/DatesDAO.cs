using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sopa_De_Letras.DAO
{
    public class DatesDAO
    {
        private string cadenaConexion = @"Server=localhost; database=LetterSoup; integrated security=true";
        public int guardar(Dates registro)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            string sql = "insert into registro(username) values (@username)";

            SqlCommand comando = new SqlCommand(sql, conexion);

            //Abrir la conexión
            conexion.Open();

            comando.Parameters.Add(new SqlParameter("@username", registro.username));

            //Ejecutar el comando | Se encarga de guardar el registro en la Base de Datos
            int resultado = comando.ExecuteNonQuery();

            //Cerrar la conexión
            conexion.Close();

            return resultado;
        }

        public void buscarRegistro(ComboBox cb)
        {
            //Creo la conexión con el motor de base de datos
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            //Creo el comando que busca el registro
            string sql = "SELECT * FROM registro";



            SqlCommand command = new SqlCommand(sql, conexion);

            conexion.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cb.Items.Add(reader["username"].ToString());
            }


            //declaro un objeto tipo datatable
            DataTable dt = new DataTable();
            //declaro un adaptador de datos
            //SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);
            //agrego el parámetro matricula
            //ad.SelectCommand.Parameters.Add(new SqlParameter("@username", buscar));
            //lleno el datatable dt
            //ad.Fill(dt);
            //retorno el datatable dt
            //return dt;
        }
    }
}
