using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class POO1
    {
        static void Main(string[] args)
        {
            SuperHeroe superHeroe = new SuperHeroe();
            var poderVolar = new SuperPoder();
            poderVolar.Nombre = "Volar";
            poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
            poderVolar.Nivel = NivelPoder.NivelDos;

            superHeroe.Id = 1;
            superHeroe.Nombre = "Spiderman";
            superHeroe.IdentidadSecreta = "Peter Parker";
            superHeroe.Ciudad = "New York";
            superHeroe.PuedeVolar = false;
            superHeroe.SuperPoderes = new[] { "Lanzar telaraña", "Super fuerza" };
        }
    }
}
