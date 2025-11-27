using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper.Interfaces
{
    public interface IApostaRepository
    {
        public List<Aposta> BuscarApostasPorApostador(Apostador apostador);
        public RetornoStatus RegistrarAposta(Corrida corrida,int numeroCavalo, int numeroApostador, double valorApostado);
        public RetornoStatus AtualizarStatus(Aposta aposta, int novoStatus);
        public List<Aposta> BuscarApostasPorCorrida(Corrida corrida);
        public void AtualizarPremiacao(Aposta aposta, double valorPremio);
    }
}
