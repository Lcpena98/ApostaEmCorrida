using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain.Enumerator
{
    public enum StatusCavalo : int
    {
        EmEspera=0,
        Correndo=1,
        PrimeiroLugar=2,
        SegundoLugar=3,
        TerceiroLugar=4,
        Perdedor=5
    }
}
