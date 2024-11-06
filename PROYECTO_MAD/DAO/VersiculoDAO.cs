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
    public class VersiculoDAO
    {

        public static List<Versiculo> ObtenerVersiculoslibro(string libro)
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Bus_Ver_Lib @texto_busqueda ='"+libro+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosBusquedalibro(string libro, string txtBuscar)
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Busq_Lib_Ref @libro ='"+libro+"', @reference='"+txtBuscar+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosBusquedaTest(string test, string txtBuscar)
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Busq_Test_Ref @test ='"+test+"', @reference='"+txtBuscar+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosBusquedaGeneral(string txtBuscar)
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Busq_Pas_Ref @reference='"+txtBuscar+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosCapitulo(string capitulo)
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Bus_Ver_Cap @texto_busqueda ='" + capitulo + "';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosVersiculo(string versiculoBus)
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Bus_Ver_Ver @texto_busqueda ='" + versiculoBus + "';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosCheckIdiomaEsp()
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Ver_Español;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosCheckIdiomaIng()
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Ver_Ingles;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosCheckNuevoTest()
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Ver_Nuevo_Test;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosCheckAntiguoTest()
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Ver_Antiguo_Test;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosCheckNewTest()
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Ver_New_Test;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerVersiculosCheckOldTest()
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Ver_Old_Test;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);
                }
                return lista;

            }
        }

        public static List<Versiculo> ObtenerFavoritos(int id_usuario)
        {
            List<Versiculo> lista = new List<Versiculo>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Mostrar_Fav @ID ='"+id_usuario+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();
                    versiculo.ID = reader.GetInt32(0);
                    versiculo.Capitulo = reader.GetInt32(1);
                    versiculo.versiculo = reader.GetInt32(2);
                    versiculo.Pasaje = reader.GetString(3);

                    lista.Add(versiculo);

                }
                return lista;

            }
        }

        public static void BorrarFavorito(int id_usuario, int id_pasaje)
        {            

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Eli_Fav @ID ='"+id_usuario+"', @ID_PAS = '"+id_pasaje+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();       

            }
        }

    }

}

