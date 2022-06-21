using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Entidades
{
    public static class JuegoDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static JuegoDAO() 
        {
            cadenaConexion = "Server=.;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static void Eliminar(int codigoJuego) 
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @nombre, PRECIO = @precio, GENERO = @genero WHERE CODIGO_JUEGO = {juego.CodigoJuego}";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@precio", juego.Precio);

                comando.ExecuteNonQuery();

            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Guardar(Juego juego) 
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO JUEGOS (NOMBRE,PRECIO,GENERO,CODIGO_USUARIO) VALUES (@nombre,@precio,@genero,@codigoUsuario)";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@codigoUsuario", juego.CodigoUsuario);

                comando.ExecuteNonQuery();

            }
            finally
            {
                conexion.Close();
            }
        }
        public static List<Biblioteca> Leer() 
        {
            List<Biblioteca> bibliotecas = new List<Biblioteca>();
            
            string query = "SELECT JUEGOS.NOMBRE as juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, USUARIOS.USERNAME as usuario " +
                    $"FROM JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string usuario = reader.GetString(0);
                    string genero = reader.GetString(1);
                    string juego = reader.GetString(2);
                    int codigoJuego = reader.GetInt32(3);

                    Biblioteca biblioteca = new Biblioteca(usuario,genero,juego,codigoJuego);
                    bibliotecas.Add(biblioteca);
                    
                }
            }

            return bibliotecas;
        }
        public static Juego LeerPorId(int codigoJuego) 
        {
           
            Juego juego = null;

            string query = $"SELECT* FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("CODIGO_JUEGO", codigoJuego);
                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    string nombre = reader.GetString(0);
                    string genero = reader.GetString(1);
                    double precio = reader.GetDouble(2);
                    int codigoUsuario = reader.GetInt32(3);
                    juego = new Juego(nombre, precio, genero, codigoUsuario);
                    

                }
            }

            return juego;
        }
    }
}
