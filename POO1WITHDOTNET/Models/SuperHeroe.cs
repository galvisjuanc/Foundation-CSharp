﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1WITHDOTNET.Models
{
    internal class SuperHeroe
    {
        public int Id { get; set; }
        public string Nombre
        {
            get {return _Nombre;}
            set { _Nombre = value.Trim(); }
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
                Console.WriteLine($"{Nombre} está usando el super poder {itemPoder.Nombre}");
            }
        }

        public string UsarPoderesSuper()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var superPoder in SuperPoderes)
            {
                stringBuilder.AppendLine($"{Nombre} está usando el super poder {superPoder.Nombre}");
            }

            return stringBuilder.ToString();
        }
    }
}