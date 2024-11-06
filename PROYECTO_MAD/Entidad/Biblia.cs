using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Biblia
    {
        public int id { get; set; }
        public int id_idioma { get; set; }
        public string testamento { get; set; }

        public Biblia() { }

        public Biblia(int id, int id_idioma, string testamento)
        {
            this.id = id;
            this.id_idioma = id_idioma;
            this.testamento = testamento;
        }


    }
}
