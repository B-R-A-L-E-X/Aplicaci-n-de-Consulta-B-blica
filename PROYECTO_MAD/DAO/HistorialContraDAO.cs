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
    public class HistorialContraDAO
    {
        public static bool RevisarHistorial(int id, string contra)
        {

            Usuario usuario = new Usuario();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC Historialcontra @ID = '"+id+"';";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    usuario.contrasena = reader.GetString(0);
                    if(usuario.contrasena == contra){
                        return true;
                    }

                }
                return false;
            }

            
        }
    }
}
