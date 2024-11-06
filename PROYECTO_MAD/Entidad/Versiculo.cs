using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Versiculo
    {
        public int ID { get; set; }
        public int Capitulo { get; set; }
        public int versiculo { get; set; }
        public string Pasaje { get; set; }

        public Versiculo() { }

        public Versiculo(int ID, int ID_Pasaje,int versiculo, string Pasaje)
        {
            this.ID = ID;
            this.Capitulo = Capitulo;
            this.versiculo = versiculo;
            this.Pasaje = Pasaje;
        }
    }
}
