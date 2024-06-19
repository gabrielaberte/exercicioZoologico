using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Zoologico
    {
        internal string ConsultarAnimal(IAnimal animal)
        {
            if (animal.TipoAnimal == "ave") return "sou uma ave.";
            if (animal.TipoAnimal == "peixe") return "sou um peixe.";
            return "Não sei o que sou :(";
        }
    }
}
