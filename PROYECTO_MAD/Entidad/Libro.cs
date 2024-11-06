using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Libro
    {
        public int id { get; set; }
        public int id_biblia { get; set; }
        public string libro { get; set; }

        public Libro() { }

        public Libro(int id, int id_biblia, string libro)
        {
            this.id = id;
            this.id_biblia = id_biblia;
            this.libro = libro;
        }
    }
}
