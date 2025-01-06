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

            var superFuerza = new SuperPoder();
            superFuerza.Nombre = "Super Fuerza";
            superFuerza.Descripcion = "Habilidad para vencer facil";
            superFuerza.Nivel = NivelPoder.NivelTres;

            var superSentido = new SuperPoder();
            superSentido.Nombre = "Super Sentido";
            superSentido.Descripcion = "Habilidad para detectar ataques enemigos";
            superSentido.Nivel = NivelPoder.NivelUno;

            superHeroe.Id = 2;
            superHeroe.Nombre = "Spiderman";
            superHeroe.IdentidadSecreta = "Peter Parker";
            superHeroe.Ciudad = "New York";
            superHeroe.PuedeVolar = false;

            List<SuperPoder> poderesSpiderman = new List<SuperPoder>();
            poderesSpiderman.Add(superFuerza);
            poderesSpiderman.Add(superSentido);
            superHeroe.SuperPoderes = poderesSpiderman;

            superHeroe.UsarSuperPoderes();

            string resultSuperPoderes = superHeroe.UsarPoderesSuper();
            Console.WriteLine(resultSuperPoderes);
        }
    }
}
