using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain.Enumerator
{
    public enum StatusCavalo : int
    {
        OnHold=0,
        FirstPlace=1,
        SecondPlace=2,
        ThirdPlace=3,
        Lose=4
    }
}
