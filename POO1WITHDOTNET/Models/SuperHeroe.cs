using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1WITHDOTNET.Models
{
    internal class SuperHeroe : Heroe
    {
        public int Id { get; set; }
        public override string Nombre
        {
            get {return _Nombre;}
            set { _Nombre = value.Trim(); }
        }

        public string NombreEIdentidadSecreta 
        {
            get 
            {
                return $"{Nombre} ({IdentidadSecreta})";
            } 
        }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public List<SuperPoder> SuperPoderes { get; set; }
        public bool PuedeVolar { get; set; }
        
        private string _Nombre;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public void UsarSuperPoderes()
        {
            foreach (var itemPoder in SuperPoderes)
            {
                Console.WriteLine($"{NombreEIdentidadSecreta} está usando el super poder {itemPoder.Nombre}");
            }
        }

        public string UsarPoderesSuper()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var superPoder in SuperPoderes)
            {
                stringBuilder.AppendLine($"{NombreEIdentidadSecreta} está usando el super poder {superPoder.Nombre}");
            }

            return stringBuilder.ToString();
        }

        public override string salvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo.";
        }

        public override string SalvarLaTierra()
        {
            return $"El SuperHeroe {NombreEIdentidadSecreta} ha salvado la tierra.";
        }
    }
}
