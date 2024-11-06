using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Historial_Busqueda
    {
        public int ID { get; set; }
        public int ID_usuario { get; set; }
        public string Texto_buscado { get; set; }
        public DateTime Fecha_Busqueda { get; set; }

        public Historial_Busqueda() { }

        public Historial_Busqueda(int ID, int ID_usuario, string Texto_buscado,DateTime Fecha_Busqueda)
        {
            this.ID = ID;
            this.ID_usuario = ID_usuario;
            this.Texto_buscado = Texto_buscado;
            this.Fecha_Busqueda = Fecha_Busqueda;
        }

    }
}
