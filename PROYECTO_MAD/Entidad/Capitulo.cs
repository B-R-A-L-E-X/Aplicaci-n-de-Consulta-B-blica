using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Capitulo
    {
        public int id { get; set; }
        public int id_libro { get; set; }
        public string capitulo { get; set; }

        public Capitulo() { }

        public Capitulo(int id, int id_libro, string capitulo)
        {
            this.id = id;
            this.id_libro = id_libro;
            this.capitulo = capitulo;
        }
    }
}
