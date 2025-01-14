using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1WITHDOTNET.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiHeroe(string accion)
        {
            return $"El AntiHeroe está realizando la accion: {accion}";
        }
    }
}
