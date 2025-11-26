using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface ICorridaService
    {
        public RetornoStatus AgendarCorrida(Corrida corrida);
        public List<Corrida> BuscarCorridasPorStatus (int status);
        public List<Cavalo> BuscarCompetidores(Corrida corrida);
        public RetornoStatus CadastrarParticipantes(Corrida corrida, List<Cavalo> competidores);
        public RetornoStatus AtualizarDadosDaCorrida(Corrida corrida, int Numero_Voltas, double percurso, DateTime dataInicio);
        public RetornoStatus AlterarStatus(Corrida corrida,int status);
        public void AtualizarStatusCompetidores(Corrida corrida, int statusAtual, int novoStatus);
        public RetornoStatus IniciarCorrida(Corrida corridaSelecionada);
        public RetornoStatus CadastrarFimCorrida(Corrida corrida);
    }
}
