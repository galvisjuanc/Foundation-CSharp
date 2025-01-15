using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO1WITHDOTNET.Interfaces;

namespace POO1WITHDOTNET
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"ID: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
            Console.WriteLine($"Identidad Secreta: {superHeroe.IdentidadSecreta}");
        }
    }
}
