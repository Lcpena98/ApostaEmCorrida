using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain.Enumerator
{
    public enum CorridaStatus: int
    {
        Waiting=0,
        InProgress=1,
        Finished=2
    }
}
