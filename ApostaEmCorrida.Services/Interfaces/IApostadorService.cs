using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface IApostadorService
    {
        public RetornoDados<Apostador> BuscarApostadorPorNumero(int numero);
        public RetornoDados<List<Apostador>> BuscarTodosApostadores();
        public RetornoStatus CadastrarApostador(string nome, string senha, string confirmaSenha, string email, int numero, double saldo);
        public RetornoStatus AlterarDadosApostador(string nome, string email, int numero);
        public RetornoStatus TrocarSenhaApostador(string senha, string novaSenha, string confirmaNovaSenha, int numero);
        public RetornoDados<int> CadastrarNumero();
        public RetornoStatus AdicionarSaldo(int numero, double valor);
        public RetornoStatus RemoverApostador(int numero);
    }
}
