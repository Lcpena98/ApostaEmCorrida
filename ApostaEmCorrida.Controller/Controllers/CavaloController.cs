using ApostaEmCorrida.Services;
using ApostaEmCorrida.Services.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;

namespace ApostaEmCorrida.Controller
{
    public class CavaloController
    {
        private readonly ICavaloService _cavaloService;

        public CavaloController(ICavaloService cavaloService)
        {
            _cavaloService = cavaloService;
        }
        public RetornoDados<Cavalo> BuscarCavaloPorNumero(int numero)
        {
            return _cavaloService.BuscarCavaloPorNumero(numero);
        }
        public RetornoDados<List<Cavalo>> BuscarTodosCavalos()
        {
            return _cavaloService.BuscarTodosCavalos();
        }
        public List<Cavalo> BuscarCavalosNaoCadastradosEmCorrida(Corrida corrida)
        {
            return _cavaloService.BuscarCavalosNaoCadastradosEmCorrida(corrida);
        }
        public RetornoStatus CadastrarCavalo(string nome, string raca, double altura, double peso, int numero)
        {
            return _cavaloService.CadastrarCavalo(nome, raca, altura, peso, numero);
        }
        public RetornoDados<int> CadastrarNumero()
        {
            return _cavaloService.CadastrarNumero();
        }
        public RetornoStatus AlterarDadosCavalo(string novoNome, string novaRaca, double novaAltura, double novoPeso, int numero)
        {
            return _cavaloService.AlterarDadosCavalo(novoNome, novaRaca, novaAltura, novoPeso, numero);
        }
        public RetornoStatus RemoverCavalo(int numero)
        {
            return _cavaloService.RemoverCavalo(numero);
        }
    }
}
