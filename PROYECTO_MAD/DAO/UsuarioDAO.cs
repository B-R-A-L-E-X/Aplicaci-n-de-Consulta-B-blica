using PROYECTO_MAD.Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    public class UsuarioDAO
    {

        public static Usuario usuarioActual { get; set; }

        public static int EditarUsuario(Usuario usuario) {
            int retorno = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC EditarUsuario @correo_electronico = '" + usuario.correoElectronico + "', @contraseña = '" + usuario.contrasena + "', @nombre = '" + usuario.nombre + "', @fecha_nacimiento = '" + usuario.fechaNacimiento.Date.ToString("yyyy-MM-dd") + "', @genero = " + usuario.genero + "; ";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorno = comando.ExecuteNonQuery();
            }

            return retorno;
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM USUARIOS ;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    //Usuario usuario = new Usuario();
                    //usuario.id = reader.GetInt32(0);
                    //usuario.correoElectronico = reader.GetString(1);
                    //usuario.contrasena = reader.GetString(2);
                    //usuario.nombre = reader.GetString(3);
                    //usuario.fechaNacimiento = reader.GetDateTime(4);
                    //usuario.genero = reader.GetInt32(5);
                    //usuario.habilitado = reader.GetInt32(6);
                    //usuario.loggin_attemps = reader.GetInt32(7);
                    //usuario.fecha_Registro = reader.GetDateTime(8);
                    //usuario.fecha_Baja = reader.GetDateTime(9);
                    //usuario.User_Admin = reader.GetInt32(10);

                    //if (variable == usuario.correoElectronico && variable2 == usuario.contrasena)
                    //{
                    //    //Entrar Al Inicio (Dashboard)
                    //}

                    //lista.Add(usuario);

                }
                return lista;

            }

        }

        //
        public static Usuario ObtenerUsuario(string correo, string contra)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Iniciar_Sesion @Correo = '"+correo+"', @Contraseña = '"+contra+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    
                    usuario.id = reader.GetInt32(0);
                    usuario.correoElectronico = reader.GetString(1);
                    usuario.contrasena = reader.GetString(2);
                    usuario.nombre = reader.GetString(3);
                    usuario.fechaNacimiento = reader.GetDateTime(4);
                    usuario.genero = reader.GetBoolean(5);
                    usuario.habilitado = reader.GetBoolean(6);
                    usuario.loggin_attemps = reader.GetBoolean(7);
                    usuario.fecha_Registro = reader.GetDateTime(8);
                    //usuario.fecha_Baja = reader.GetDateTime(9);
                    usuario.User_Admin = reader.GetBoolean(10);

                }
                return usuario;

            }
        }

        public static Usuario ObtenerUsuario(string correo)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Buscar_usu @correo = '"+correo+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    usuario.id = reader.GetInt32(0);
                    usuario.correoElectronico = reader.GetString(1);
                    usuario.contrasena = reader.GetString(2);
                    usuario.nombre = reader.GetString(3);
                    usuario.fechaNacimiento = reader.GetDateTime(4);
                    usuario.genero = reader.GetBoolean(5);
                    usuario.habilitado = reader.GetBoolean(6);
                    usuario.loggin_attemps = reader.GetBoolean(7);
                    usuario.fecha_Registro = reader.GetDateTime(8);
                    //usuario.fecha_Baja = reader.GetDateTime(9);
                    usuario.User_Admin = reader.GetBoolean(10);

                }
                return usuario;

            }
        }

        public static void EditarUsuario(int id, string nombre, string contra, string correo,
                                         bool genero, string fechaNacimiento)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Editar_usuario @ID_usuario = '"+id+"', @Nombre = '"+nombre+"', @Contraseña = '"+contra+"', @Correo = '"+correo+"', @Genero = '"+genero+"', @Fecha_nacimiento = '"+fechaNacimiento+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

            }
        }

        public static void EditarUsuarioSinContra(int id, string nombre, string correo,
                                         bool genero, string fechaNacimiento)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Editar_usuario2 @ID_usuario = '" + id + "', @Nombre = '" + nombre + "', @Correo = '" + correo + "', @Genero = '" + genero + "', @Fecha_nacimiento = '" + fechaNacimiento + "';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

            }
        }

        public static void EliminarUsuario(int id)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Elim_usuario @ID = '" + id+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

            }
        }

        public static void DeshabilitarUsuario(string correo, string contra) 
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Desha_usuario @correo = '"+correo+"',@contraseña = '"+contra+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

            }
        }

        public static void GuardarFavorito(int id_versiculo, int id_usuario)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Agregar_favorito @ID ='"+id_usuario+"', @ID_Pas = '"+id_versiculo+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

            }
        }

    }
}
