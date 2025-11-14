using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services.Interfaces;

namespace ApostaEmCorrida.Controller
{
    public class CorridaController
    {

        protected readonly ICorridaService _corridaService;
        public CorridaController(ICorridaService corridaService)
        {
            _corridaService = corridaService;
        }

        public List<Corrida> BuscarCorridasPorStatus(int status)
        {
            return _corridaService.BuscarCorridasPorStatus(status);
        }

        public RetornoStatus AgendarCorrida(Corrida corrida)
        {
            return _corridaService.AgendarCorrida(corrida);
        }
        public List<Cavalo> BuscarCompetidores(Corrida corrida)
        {
            return _corridaService.BuscarCompetidores(corrida);
        }
        public RetornoStatus CadastrarParticipantes(Corrida corrida, List<Cavalo> competidores)
        {
            return _corridaService.CadastrarParticipantes(corrida, competidores);
        }
        public RetornoStatus AtualizarDadosDaCorrida(Corrida corrida, int Numero_Voltas, double percurso, DateTime dataInicio)
        {
            return _corridaService.AtualizarDadosDaCorrida(corrida, Numero_Voltas, percurso, dataInicio);
        }
        public RetornoStatus AlterarStatus(Corrida corrida, int status)
        {
            return _corridaService.AlterarStatus(corrida, status);
        }
        public void AtualizarStatusCompetidores(Corrida corrida, int statusAtual, int novoStatus)
        {
            _corridaService.AtualizarStatusCompetidores(corrida, statusAtual,novoStatus);
        }
        public RetornoStatus IniciarCorrida(Corrida corridaSelecionada)
        {
            return _corridaService.IniciarCorrida(corridaSelecionada);
        }
        public void CadastrarFimCorrida()
        {
            _corridaService.CadastrarFimCorrida();
        }
        public void FinalizarCorrida()
        {
            _corridaService.FinalizarCorrida();
        }
    }
}

