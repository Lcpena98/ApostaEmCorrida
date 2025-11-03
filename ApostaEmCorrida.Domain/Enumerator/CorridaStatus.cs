using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain.Enumerator
{
    public enum CorridaStatus: int
    {
        Agendada=0,
        EmAndamento=1,
        Finalizada=2
    }
}
