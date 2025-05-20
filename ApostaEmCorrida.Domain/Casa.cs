using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApostaEmCorrida.Domain;

namespace ApostaEmCorrida.Domain
{
    public class Casa
    {
        public List<Cavalo> Cavalos { get; private set; }
        public List<Apostador> Apostadores { get; private set; }
        private double Saldo { get; set; }
        private double ValorEmAposta { get; set; }

        public Casa(List<Cavalo> cavalos, List<Apostador> apostadores, double saldo, double valorEmAposta)
        {
            Cavalos = cavalos;
            Apostadores = apostadores;
            saldo = saldo;
            ValorEmAposta = valorEmAposta;
        }

        public static Casa CadastrarCasa()
        {
            List<Cavalo> cavalos=new List<Cavalo>();
            List<Apostador> apostadores = new List<Apostador>();
            Casa casa = new Casa(cavalos,apostadores,0,0);
            return casa;
        }
        public static List<Cavalo> NovoCavalo(List<Cavalo>cavalos)
        {
            cavalos.Add(Cavalo.CadastrarCavalo(cavalos));
            return cavalos;
        }
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