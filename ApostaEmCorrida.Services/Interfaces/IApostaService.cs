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
        public List<Aposta> BuscarApostasPorApostador(Apostador apostador);
        public RetornoStatus RegistrarAposta(Corrida corrida,int numeroCavalo, Apostador apostador, double valorApostado);
        public RetornoStatus AtualizarStatus(Aposta aposta, int novoStatus);
        public List<Aposta> BuscarApostasPorCorrida(Corrida corrida);
    }
}
