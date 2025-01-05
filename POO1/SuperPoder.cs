using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class SuperPoder {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public NivelPoder Nivel { get; set; }

        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
        }
    }

    enum NivelPoder {
        NivelUno,
        NivelDos,
        NivelTres
    }
}
