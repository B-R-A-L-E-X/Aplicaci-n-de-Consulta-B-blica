using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD
{
    public class BDConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PIA_BIBLIA;Data Source=DESKTOP-4RC0O38\\JOHN");
            
            conexion.Open();
            return conexion;
        }
    }
}
