﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics4
{
    internal class Basics4
    {
        static void Main(string[] args)
        {
            var radio = 0.0;
            var resultado = 0d;
            const double Pi = 3.141591;

            Console.WriteLine("Bienvenido, Calculemos circulos");
            Console.WriteLine("Ingrese el valor del radio: ");

            radio = Convert.ToDouble(Console.ReadLine());

            resultado = Pi * Math.Pow(radio,2);

            Console.WriteLine("El área de tu circulo es de: " + resultado);
        }
    }
}