using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services.Interfaces;
using ApostaEmCorrida.Dapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services
{
    public class ApostadorService: IApostadorService
    {
        protected readonly IApostadorRepository _apostadorRepository;

        public ApostadorService(IApostadorRepository apostadorRepository)
        {
            _apostadorRepository = apostadorRepository;
        }

        public RetornoDados<Apostador> BuscarApostadorPorNumero(int numero)
        {
            throw new NotImplementedException();
        }

        public RetornoDados<List<Apostador>> BuscarTodosApostadores()
        {
            return _apostadorRepository.BuscarTodosApostadores();
        }

        public RetornoStatus CadastrarApostador(string nome, string senha, string confirmaSenha, string email, int numero, double saldo)
        {
            if (senha == confirmaSenha) 
            { 
            return _apostadorRepository.CadastrarApostador(nome, senha, email, numero, saldo);
            }
            else
            {
                return new RetornoStatus(false, "As senhas não batem!");
            }
        }

        public RetornoStatus AlterarDadosApostador(string nome, string email, int numero)
        {
            throw new NotImplementedException();
        }

        public RetornoStatus TrocarSenhaApostador(string senha, string novaSenha, string confirmaNovaSenha, int numero)
        {
            throw new NotImplementedException();
        }

        public RetornoDados<int> CadastrarNumero()
        {
            try
            {
                List<Apostador> apostadoresCadastrados = _apostadorRepository.BuscarTodosApostadores().Dados;
                List<int> numerosCadastrados = apostadoresCadastrados.Select(a => a.Numero).ToList();
                Random rnd = new Random();
                int novaSenha;
                do
                {
                    novaSenha = rnd.Next(10000, 99999);
                } while (numerosCadastrados.Contains(novaSenha));
                return new RetornoDados<int>(true, $"Numero cadastrado com sucesso!", novaSenha);
            }
            catch (Exception ex)
            {
                return new RetornoDados<int>(false,$"Erro ao cadastrar o numero{ex.Message.ToString()}", -1);
            }
        }

        public RetornoStatus AdicionarSaldo(int numero, double valor)
        {
            throw new NotImplementedException();
        }

        public RetornoStatus RemoverApostador(int numero)
        {
            throw new NotImplementedException();
        }
    }
}
