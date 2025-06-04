using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain.Entities
{
    public enum StatusAposta
    {
        Pending,
        Win,
        Lose,
        Cancel,
        Error
    }
}
