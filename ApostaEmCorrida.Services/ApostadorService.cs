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
    public class ApostadorService : IApostadorService
    {
        protected readonly IApostadorRepository _apostadorRepository;

        public ApostadorService(IApostadorRepository apostadorRepository)
        {
            _apostadorRepository = apostadorRepository;
        }
        public RetornoDados<Apostador> BuscarApostadorPorNumero(int numero)
        {
            return _apostadorRepository.BuscarApostadorPorNumero(numero);
        }
        public RetornoDados<Apostador> BuscarApostadorPorEmail(string email)
        {
            return _apostadorRepository.BuscarApostadorPorEmail(email);
        }
        public RetornoDados<List<Apostador>> BuscarTodosApostadores()
        {
            return _apostadorRepository.BuscarTodosApostadores();
        }
        public RetornoStatus CadastrarApostador(string nome, string senha, string confirmaSenha, string email, int numero, double saldo)
        {
            List<Apostador> apostadoresCadastrados = _apostadorRepository.BuscarTodosApostadores().Dados;
            if (apostadoresCadastrados.Any(a => a.Email == email))
            {
                return new RetornoStatus(false, "Email já cadastrado!");
            }
            else if (senha != confirmaSenha)
            {
                return new RetornoStatus(false, "As senhas não batem!");
            }
            else
            {
                return _apostadorRepository.CadastrarApostador(nome, senha, email, numero, saldo);
            }
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
                return new RetornoDados<int>(false, $"Erro ao cadastrar o numero{ex.Message.ToString()}", -1);
            }
        }
        public RetornoStatus TrocarSenhaApostador(string senha, string novaSenha, string confirmaNovaSenha, int numero)
        {
            if (novaSenha != confirmaNovaSenha)
            {
                return new RetornoStatus(false, "As senhas não batem!");
            }
            else
            {
                return _apostadorRepository.TrocarSenhaApostador(senha, novaSenha, numero);
            }
        }
        public RetornoStatus AlterarDadosApostador(string nome, string email, int numero)
        {
            return _apostadorRepository.AlterarDadosApostador(nome, email, numero);
        }
        public RetornoStatus AdicionarSaldo(Apostador apostador, double valor)
        {
            return _apostadorRepository.AdicionarSaldo(apostador, valor);
        }

        public RetornoStatus RemoverSaldo(Apostador apostador, double valor)
        {
            return _apostadorRepository.RemoverSaldo(apostador, valor);
        }
        public RetornoStatus ResetarSenhaApostador(string email, string novaSenha, string confirmaNovaSenha)
        {
            RetornoDados<Apostador> apostador = _apostadorRepository.BuscarApostadorPorEmail(email);
            if (!apostador.Sucesso)
            {
                return new RetornoStatus(false, "Apostador não encontrado!");
            }
            else if (novaSenha != confirmaNovaSenha)
            {
                return new RetornoStatus(false, "As senhas não batem!");
            }
            else
            {
                return _apostadorRepository.TrocarSenhaApostador(apostador.Dados.Senha, novaSenha, apostador.Dados.Numero);
            }
        }
    }
}
