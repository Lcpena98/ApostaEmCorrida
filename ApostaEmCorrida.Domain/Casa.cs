using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Casa
    {
        public int Id_Casa { get; set; }
        public double Saldo { get; set; }
        public List<Cavalo> Cavalos { get; private set; }
        public double ValorEmAposta { get; set; }


        //Função que gera o resultado da Corrida
        public static Cavalo Corrida(Cavalo[] cavalos)
        {
            Random corrida = new Random();
            return  cavalos[corrida.Next(cavalos.Length)];
        }


        //Função que valida a aposta
        public static double ValidarAposta(Cavalo resultado, Cavalo escolha, double dinheiro, double valor)
        {

            if (resultado == escolha)
            {
                Console.WriteLine("Parabéns! Você ganhou");
                return dinheiro = 0;
            }
            else
            {
                Console.WriteLine("Que pena! Você perdeu");
                return dinheiro -= valor;
            }
        }
    }
}