using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valor1 = true;
            bool valor2 = false;
            bool valor3 = true;

            bool resultAnd = valor1 && valor2 && valor3;
            Console.WriteLine(resultAnd);

            bool resultOr = valor1 || valor2 || valor3;
            Console.WriteLine(resultOr);

            bool resultAndOr = (valor1 && valor2) || valor3;
            Console.WriteLine(resultAndOr);
        }
    }
}
