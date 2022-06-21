using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Entidades
{
    public static class UsuarioDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static UsuarioDAO()
        {
            cadenaConexion = "Server=.;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer() 
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = "SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS";
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string usser = reader.GetString(0);
                    int codigoUsuario = reader.GetInt32(3);

                    Usuario usuario=new Usuario(usser,codigoUsuario);
                    usuarios.Add(usuario);

                }
            }

            return usuarios;
        }

    }
}
