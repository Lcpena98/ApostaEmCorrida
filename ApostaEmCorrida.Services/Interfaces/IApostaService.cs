using ApostaEmCorrida.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface IApostaService
    {
        public void NovaAposta(Casa casa, Cavalo cavalo, Apostador apostador, double valorApostado);
    }
}
