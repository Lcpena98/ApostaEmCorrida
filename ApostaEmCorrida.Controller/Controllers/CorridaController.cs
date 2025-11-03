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

        public RetornoStatus AgendarCorrida(Corrida corrida)
        {
           return _corridaService.AgendarCorrida(corrida);
        }
        public void IniciarCorrida()
        {
            _corridaService.IniciarCorrida();
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

