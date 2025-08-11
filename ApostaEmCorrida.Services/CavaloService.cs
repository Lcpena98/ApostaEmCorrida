using ApostaEmCorrida.Domain;
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
        protected readonly Cavalo _cavalo;
        public CavaloService(Cavalo cavalo) 
        { 
            _cavalo = cavalo;
        }

        //Função que cadastra os participantes
        public void CadastrarCavalo(List<Cavalo> ListaCavalos, string nome, double altura, double peso, int numero, double saldo)
        {
            ListaCavalos.Add(new Cavalo(numero, nome, altura, peso, 0, 0, 100,StatusCavalo.OnHold));
            saldo += 50;
        }

        //Função que cria o numero do cavalo e impede que haja 2 cavalos com o mesmo numero
        public int CadastrarNumero(List<Cavalo> cavalosCadastrados)
        {
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
                _cavalo.AtualizarDesempenho(cavalos,primeiroLugar,segundoLugar,terceiroLugar);
            }
        }
    }
}
