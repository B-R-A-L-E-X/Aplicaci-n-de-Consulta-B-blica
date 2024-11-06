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
    public class HistorialBusquedaDAO
    {
        public static List<Historial_Busqueda> ObtenerHistorial_Busquedas(int id)
        {
            List<Historial_Busqueda> lista = new List<Historial_Busqueda>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Mostrar_His_Bus @ID ='"+id+"'";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Historial_Busqueda historial = new Historial_Busqueda();
                    //historial.ID = reader.GetInt32(0);
                    //historial.ID_usuario = reader.GetInt32(1);
                    historial.Texto_buscado = reader.GetString(0);
                    historial.Fecha_Busqueda = reader.GetDateTime(1);

                    lista.Add(historial);
                }
                return lista;

            }
        }

        public static void GuardarHistorial(int id, string txtBuscado)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Guardar_busq @ID = '"+id+"', @reference ='"+txtBuscado+"'";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();
            }
        }

        public static void EliminarHistorial(int id)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Borrar_busq @ID ='"+id+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();
            }
        }

    }
}
