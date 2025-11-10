using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Enumerator;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services
{
    public class CavaloService : ICavaloService
    {
        protected readonly ICavaloRepository _cavaloRepository;
        public CavaloService(CavaloRepository cavaloRepository)
        {
            _cavaloRepository = cavaloRepository;
        }

        //Função que cadastra os participantes
        public RetornoStatus CadastrarCavalo(string nome, string raca, double altura, double peso, int numero)
        {
            return _cavaloRepository.CadastrarCavalo(nome, raca, altura, peso, numero);
        }

        //Função que cria o numero do cavalo e impede que haja 2 cavalos com o mesmo numero
        public RetornoDados<int> CadastrarNumero()
        {
            try
            {
                RetornoDados<List<Cavalo>> buscaCavalos = _cavaloRepository.BuscarTodosCavalos();
                List<Cavalo> cavalosCadastrados = buscaCavalos.Dados;
                List<int> numerosExistentes = cavalosCadastrados.Select(c => c.Numero_Cavalo).ToList();
                Random rnd = new Random();
                int novoNumero;
                do
                {
                    novoNumero = rnd.Next(10, 99);
                } while (numerosExistentes.Contains(novoNumero));

                return new RetornoDados<int>(true, $"Numero Registrado com sucesso", novoNumero);
            }
            catch (Exception ex)
            {
                return new RetornoDados<int>(false, $"Erro ao gerar número: {ex.Message}", -1);
            }
        }
        //Função que acessa o metodo que atualiza os dados dos Cavalos
        public RetornoStatus AtualizarDesempenho(List<Cavalo> cavalos, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar)
        {
            {
                return _cavaloRepository.AtualizarDesempenho(cavalos,primeiroLugar,segundoLugar,terceiroLugar);
            }
        }

        public RetornoDados<List<Cavalo>> BuscarTodosCavalos()
        {
            return _cavaloRepository.BuscarTodosCavalos();
        }

        public RetornoDados<Cavalo> BuscarCavaloPorNumero(int numero)
        {
            return BuscarCavaloPorNumero(numero);
        }

        public List<Cavalo> BuscarCavalosNaoCadastradosEmCorrida(Corrida corrida)
        {
            return _cavaloRepository.BuscarCavalosNaoCadastradosEmCorrida(corrida);
        }

        public RetornoStatus AlterarDadosCavalo(string novoNome, string novaRaca, double novaAltura, double novoPeso, int numero)
        {
            return _cavaloRepository.AlterarDadosCavalo(novoNome, novaRaca, novaAltura, novoPeso, numero);
        }

        public RetornoStatus RemoverCavalo(int numero)
        {
            return _cavaloRepository.RemoverCavalo(numero);
        }
    }
}
