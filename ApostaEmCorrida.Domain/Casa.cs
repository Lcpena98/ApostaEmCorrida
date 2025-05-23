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
        public double Saldo { get;private set; }
        public List<Cavalo> Cavalos { get; private set; }
        public List<Apostador> Apostadores { get; private set; }
        public List<Aposta> Apostas { get; private set; }
        

        public Casa(double saldo, List<Cavalo> cavalos, List<Apostador> apostadores, List<Aposta> apostas)
        {
            Saldo = saldo;
            Cavalos = cavalos;
            Apostadores = apostadores;
            Apostas = apostas;
        }

        public static Casa CadastrarCasa()
        {
            List<Cavalo> cavalos=new List<Cavalo>();
            List<Apostador> apostadores = new List<Apostador>();
            List<Aposta> apostas= new List<Aposta>();
            Casa casa = new Casa(0,cavalos,apostadores,apostas);
            return casa;
        }
        //Função que gera o resultado da Corrida
        public static Cavalo Corrida(Cavalo[] cavalos)
        {
            Random corrida = new Random();
            return  cavalos[corrida.Next(cavalos.Length)];
        }
        //Função que atualiza a aposta e o saldo
        public static void CadastrarAposta(Casa casa)
        {
            Console.WriteLine("Digite o valor Apostado.");
            double valorApostado = Convert.ToDouble(Console.ReadLine());
            double taxaAposta = (valorApostado* 10)/100;
            casa.Saldo += taxaAposta;
            valorApostado -= taxaAposta;
            casa.Apostas.Add(Aposta.NovaAposta(casa,valorApostado));
        }
        //Função que valida o resultado da aposta e cadastra a aposta
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