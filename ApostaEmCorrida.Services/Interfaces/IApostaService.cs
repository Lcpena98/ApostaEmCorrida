using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface IApostaService
    {
        public RetornoStatus RegistrarAposta(int numeroCavalo, int numeroApostador, double valorApostado);
    }
}
