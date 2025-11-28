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
        public List<Aposta> BuscarApostasPorApostador(Apostador apostador)
        {
            return _apostaService.BuscarApostasPorApostador(apostador);
        }
        public RetornoStatus RegistrarAposta(Corrida corrida, int numeroCavalo, Apostador apostador, double valorApostado)
        {
            return _apostaService.RegistrarAposta(corrida, numeroCavalo, apostador, valorApostado);
        }
        public RetornoStatus AtualizarStatus(Aposta aposta, int novoStatus)
        {
            return _apostaService.AtualizarStatus(aposta, novoStatus);
        }
        public List<Aposta> BuscarApostasPorCorrida(Corrida corrida)
        {
            return _apostaService.BuscarApostasPorCorrida(corrida);
        }
    }
}
