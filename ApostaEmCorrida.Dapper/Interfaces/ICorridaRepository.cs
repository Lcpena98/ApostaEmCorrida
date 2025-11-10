using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper.Interfaces
{
    public interface ICorridaRepository
    {
        public RetornoStatus AgendarCorrida(Corrida corrida);
        public List<Corrida> BuscarCorridasPorStatus(int status);
        public List<Cavalo> BuscarCompetidores(Corrida corrida);
        public RetornoStatus CadastrarParticipantes(Corrida corrida, List<Cavalo> competidores);
        public RetornoStatus RemoverParticipantes(Corrida corrida, List<Cavalo> competidores);
        public RetornoStatus AtualizarDadosDaCorrida(Corrida corrida, int Numero_Voltas, double percurso, DateTime dataInicio);

        public RetornoStatus CancelarCorrida(Corrida corrida);
        public void IniciarCorrida();
        public void CadastrarFimCorrida();
        public void FinalizarCorrida();
    }
}
