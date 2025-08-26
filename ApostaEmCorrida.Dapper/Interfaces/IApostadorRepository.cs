using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper.Interfaces
{
    public interface IApostadorRepository
    {
        public RetornoDados<Apostador> BuscarApostadorPorNumero(int numero);
        public RetornoDados<List<Apostador>> BuscarTodosApostadores();
        public RetornoStatus CadastrarApostador(string nome, string senha, string email, int numero, double saldo);
        public RetornoStatus AlterarDadosApostador(string nome, string email, int numero);
        public RetornoStatus TrocarSenhaApostador(string senha, string novaSenha, int numero);
        public RetornoStatus AdicionarSaldo(int numero, double valor);
        public RetornoStatus RemoverApostador(int numero);
    }
}
