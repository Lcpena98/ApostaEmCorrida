using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services.Interfaces;

namespace ApostaEmCorrida.Controller
{
    public class ApostadorController
    {
        private readonly IApostadorService _apostadorService;

        public ApostadorController(IApostadorService apostadorService)
        {
            _apostadorService = apostadorService;
        }
        public RetornoDados<Apostador> BuscarApostadorPorNumero(int numero)
        {
            return _apostadorService.BuscarApostadorPorNumero(numero);
        }
        public RetornoDados<Apostador> BuscarApostadorPorEmail(string email)
        {
            return _apostadorService.BuscarApostadorPorEmail(email);
        }
        public RetornoDados<List<Apostador>> BuscarTodosApostadores()
        {
            return _apostadorService.BuscarTodosApostadores();
        }
        public RetornoStatus CadastrarApostador(string nome, string senha, string confirmaSenha, string email, int numero, double saldo)
        {
            return _apostadorService.CadastrarApostador(nome, senha, confirmaSenha, email, numero, saldo);
        }
        public RetornoDados<int> CadastrarNumero()
        {
            return _apostadorService.CadastrarNumero();
        }

        public RetornoStatus TrocarSenhaApostador(string senha, string novaSenha, string confirmaNovaSenha, int numero)
        {
            return _apostadorService.TrocarSenhaApostador(senha, novaSenha, confirmaNovaSenha, numero);
        }
        public RetornoStatus ResetarSenhaApostador(string email, string novaSenha, string confirmaNovaSenha)
        {
            return _apostadorService.ResetarSenhaApostador(email, novaSenha, confirmaNovaSenha);
        }
        public RetornoStatus AlterarDadosApostador(string nome, string email, int numero)
        {
            return _apostadorService.AlterarDadosApostador(nome, email, numero);
        }
        public RetornoStatus AdicionarSaldo(int numero, double valor)
        {
            return _apostadorService.AdicionarSaldo(numero,valor);
        }
        public RetornoStatus RemoverSaldo(int numero, double valor)
        {
            return _apostadorService.RemoverSaldo(numero,valor);
        }
    }
}
