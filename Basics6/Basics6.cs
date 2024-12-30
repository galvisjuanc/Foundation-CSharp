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
            var (valor1, valor2, valor3) = (true, false, false);

            bool resultAnd = valor1 && valor2 && valor3;
            Console.WriteLine(resultAnd);

            bool resultOr = valor1 || valor2 || valor3;
            Console.WriteLine(resultOr);

            bool resultAndOr = (valor1 && valor2) || valor3;
            Console.WriteLine(resultAndOr);

            bool resultNot = !valor1;
            Console.WriteLine(resultNot);
        }
    }
}
