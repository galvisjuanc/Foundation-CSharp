using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1WITHDOTNET.Interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string IdentidadSecreta { get; set; }
    }
}
