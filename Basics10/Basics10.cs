using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics10
{
    internal class Basics10
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Elige una letra de las siguientes para recibir un mensaje: a, b, c, d");
            letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case 'a':
                    Console.WriteLine("Eres una chimbita");
                    break;
                case 'b':
                    Console.WriteLine("Pasala bien con tu familia");
                    break;
                case 'c':
                    Console.WriteLine("Cuida a los que más quieres");
                    break;
                case 'd':
                    Console.WriteLine("Sigue tus sueños");
                    break;
                default:
                    Console.WriteLine("Letra errada");
                    break;
            }
        }
    }
}
