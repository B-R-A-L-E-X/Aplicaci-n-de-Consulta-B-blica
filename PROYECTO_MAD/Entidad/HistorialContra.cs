using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class HistorialContra
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public string contraseña { get; set; }

        public HistorialContra() { }
        public HistorialContra(int id, int id_usuario, string contraseña)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.contraseña = contraseña;
        }
    }
}
