using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics7
{
    internal class Basics7
    {
        static void Main(string[] args)
        {
            var (valor1, valor2, valor3) = (10,4,8);
            Console.WriteLine("Los valores son: " + valor1 + ", " + valor2 + ", " + valor3);

            bool resultado1 = valor1 == valor2;
            Console.WriteLine("EL resultado de la comparación valor1 == valor2 es: " + resultado1);

            bool resultado2 = valor1 != valor2;
            Console.WriteLine("EL resultado de la comparación valor1 != valor2 es: " + resultado2);

            bool resultado3 = valor1 < valor2;
            Console.WriteLine("EL resultado de la comparación valor1 < valor2 es: " + resultado3);

            bool resultado4 = valor1 > valor2;
            Console.WriteLine("EL resultado de la comparación valor1 > valor2 es: " + resultado4);
        }
    }
}
