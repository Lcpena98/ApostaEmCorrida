using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Entities;

namespace ApostaEmCorrida.Domain
{
    public class Casa
    {
        public double Saldo { get; private set; }
        public List<Cavalo> Cavalos { get; private set; }
        public List<Pessoa> Apostadores { get; private set; }
        public List<Aposta> Apostas { get; private set; }
        public List<Corrida> Corridas { get; private set; }
        public double ValorEmAposta { get; private set; }


        public Casa(double saldo, List<Cavalo> cavalos, List<Pessoa> apostadores, List<Aposta> apostas, List<Corrida> corridas, double valorEmAposta)
        {
            Saldo = saldo;
            Cavalos = cavalos;
            Apostadores = apostadores;
            Corridas = corridas;
            Apostas = apostas;
            ValorEmAposta = valorEmAposta;
        }

        public static Casa CadastrarCasa()
        {
            List<Cavalo> cavalos = new List<Cavalo>();
            List<Pessoa> apostadores = new List<Pessoa>();
            List<Aposta> apostas = new List<Aposta>();
            List<Corrida> corridas = new List<Corrida>();
            Casa casa = new Casa(0, cavalos, apostadores, apostas, corridas, 0);
            return casa;
        }
        //Função que valida o resultado da aposta e separa as pessoas que venceram
        public static List<Aposta> ValidarAposta(Cavalo resultado, List<Aposta> apostas)
        {
            List<Aposta> vencedores = new List<Aposta>();
            foreach (var aposta in apostas)
            {
                if (aposta.CavaloApostado == resultado)
                {
                    aposta.Status = StatusAposta.Win;
                    vencedores.Add(aposta);
                }
                else
                {
                    aposta.Status = StatusAposta.Lose;
                }
            }
            return vencedores;
        }
        //Função que faz o calculo do valor apostado, transfere o valor para os vencedores baseado na quantia apostada ou para a conta da casa caso não haja vencedor.
        //Falha lógica, erro no valor retornado


        //PARA TESTAR
        public static void Calculo_de_aposta(Casa casa, Cavalo vencedor)
        {
            try
            {
                List<Aposta> vencedores = Casa.ValidarAposta(vencedor, casa.Apostas);
                if (vencedores.Count > 0)
                {
                    double somaApostaVencedora = 0;
                    Console.WriteLine("Vencedores:");
                    foreach (var aposta in vencedores)
                    {
                        Console.WriteLine($"[{aposta.Apostador.Senha}]{aposta.Apostador.Nome}");
                        somaApostaVencedora += aposta.ValorApostado;
                    }
                    foreach (var apostador in vencedores)
                    {
                        {
                            double proporcao = Math.Round(apostador.ValorApostado / somaApostaVencedora, 2);
                            double valorRecebido = Math.Round(casa.ValorEmAposta * proporcao, 2);
                            Console.WriteLine($"{apostador.Apostador.Nome} recebeu R$ {valorRecebido:F2}");
                            Pessoa pessoaEncontrada = casa.Apostadores.Find(a => a is Apostador ap && ap.Senha == apostador.Apostador.Senha);
                            Apostador.AdicionarSaldo(pessoaEncontrada as Apostador, valorRecebido);
                            casa.ValorEmAposta -= valorRecebido;
                        }
                    }
                    if (casa.ValorEmAposta > 0)
                    {
                        casa.Saldo += casa.ValorEmAposta;
                        casa.ValorEmAposta = 0;
                    }
                    casa.Apostas.Clear();
                }
                else
                {
                    Console.WriteLine("Ninguém venceu");
                    casa.Saldo += casa.ValorEmAposta;
                    casa.ValorEmAposta = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar resultados!");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}