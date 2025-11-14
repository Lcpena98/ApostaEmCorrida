using ApostaEmCorrida.Services;
using ApostaEmCorrida.Services.Interfaces;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Domain;

namespace ApostaEmCorrida.Controller
{
    public class ApostaController
    {
        protected readonly IApostaService _apostaService;
        public ApostaController(IApostaService apostaService)
        {
            _apostaService = apostaService;
        }
        public RetornoStatus RegistrarAposta(Corrida corrida,int numeroCavalo, int numeroApostador, double valorApostado)
        {
            return _apostaService.RegistrarAposta(corrida, numeroCavalo, numeroApostador, valorApostado);
        }
    }
}
