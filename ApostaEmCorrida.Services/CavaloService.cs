using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain.Enumerator;
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
        protected readonly CavaloRepository _cavaloRepository;
        public CavaloService(CavaloRepository cavaloRepository) 
        { 
            _cavaloRepository = cavaloRepository;
        }

        //Função que cadastra os participantes
        public void CadastrarCavalo(string nome, double altura, double peso, int numero)
        {
            _cavaloRepository.CadastrarCavalo(nome, altura, peso, numero);
        }

        //Função que cria o numero do cavalo e impede que haja 2 cavalos com o mesmo numero
        public int CadastrarNumero()
        {
            List<Cavalo> cavalosCadastrados = _cavaloRepository.BuscarTodosCavalos();
            List<int> numerosExistentes = cavalosCadastrados.Select(c => c.Numero_Cavalo).ToList();
            Random rnd = new Random();
            int novoNumero;
            do
            {
                novoNumero = rnd.Next(10, 99);
            } while (numerosExistentes.Contains(novoNumero));

            return novoNumero;
        }
        //Função que acessa o metodo que atualiza os dados dos Cavalos
        public void AtualizarDesempenho(List<Cavalo> cavalos, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar)
        {
            {
                //_cavalo.AtualizarDesempenho(cavalos,primeiroLugar,segundoLugar,terceiroLugar);
            }
        }

        public List<Cavalo> BuscarTodosCavalos()
        {
            throw new NotImplementedException();
        }

        public Cavalo BuscarCavaloPorNumero(int numero)
        {
            throw new NotImplementedException();
        }
    }
}
