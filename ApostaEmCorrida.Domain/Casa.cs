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
        public double Saldo { get; private set; }
        public List<Cavalo> Cavalos { get; private set; }
        public List<Apostador> Apostadores { get; private set; }
        public List<Aposta> Apostas { get; private set; }
        public double ValorEmAposta { get; private set; }


        public Casa(double saldo, List<Cavalo> cavalos, List<Apostador> apostadores, List<Aposta> apostas, double valorEmAposta)
        {
            Saldo = saldo;
            Cavalos = cavalos;
            Apostadores = apostadores;
            Apostas = apostas;
            ValorEmAposta = valorEmAposta;
        }

        public static Casa CadastrarCasa()
        {
            while (true)
            {
                try
                {
                    List<Cavalo> cavalos = new List<Cavalo>();
                    List<Apostador> apostadores = new List<Apostador>();
                    List<Aposta> apostas = new List<Aposta>();
                    Casa casa = new Casa(0, cavalos, apostadores, apostas, 0);
                    return casa;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }
        }
        //Função que gera o resultado da Corrida
        public static Cavalo Corrida(List<Cavalo> cavalos)
        {
            Random corrida = new Random();
            Cavalo vencedor = cavalos[corrida.Next(cavalos.Count)];
            Cavalo.AtualizarDesempenho(cavalos, vencedor);
            return vencedor;
        }
        //Função que atualiza a aposta e o saldo
        public static void CadastrarAposta(Casa casa)
        {
            Console.WriteLine("Digite o valor Apostado.");
            double valorApostado = Convert.ToDouble(Console.ReadLine());
            double taxaAposta = (valorApostado * 10) / 100;
            casa.Saldo += taxaAposta;
            valorApostado -= taxaAposta;
            casa.ValorEmAposta += valorApostado;
            Aposta.NovaAposta(casa, valorApostado);
        }
        //Função que valida o resultado da aposta e separa as pessoas que venceram
        public static List<Aposta> ValidarAposta(Cavalo resultado, List<Aposta> apostas)
        {
            List<Aposta> vencedores = new List<Aposta>();
            foreach (var aposta in apostas)
            {
                if (aposta.CavaloApostado == resultado)
                {
                    vencedores.Add(aposta);
                }
            }
            return vencedores;
        }
        //Função que faz o calculo do valor apostado, transfere o valor para os vencedores baseado na quantia apostada ou para a conta da casa caso não haja vencedor.
        //PARA TESTAR
        public static void calculo_de_aposta(Casa casa, List<Aposta> vencedores)
        {
            if (vencedores.Count > 0)
            {
                double somaApostaVencedora = 0;
                Console.WriteLine("Vencedores:");
                foreach (var aposta in vencedores)
                {
                    Console.WriteLine($"[{aposta.Apostador.Senha}]{aposta.Apostador.Nome}");
                    somaApostaVencedora += aposta.ValorApostado;
                }
                foreach (var apostador in casa.Apostadores)
                {
                    foreach (var aposta in vencedores)
                    {
                        if (vencedores.Any(a => a.Apostador.Senha == apostador.Senha))
                        {
                            double porcentagemApostada = 100 * aposta.ValorApostado / somaApostaVencedora;
                            double lucro = casa.ValorEmAposta * porcentagemApostada / 100;
                            Apostador.AdicionarSaldo(apostador, lucro);
                            casa.ValorEmAposta -= lucro;
                        }
                    }
                }
            }
            else 
            {
                Console.WriteLine("Ninguém venceu");
                casa.Saldo += casa.ValorEmAposta;
                casa.ValorEmAposta = 0;
            }
        }
    }
}