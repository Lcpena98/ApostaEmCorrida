using System;
using ApostaEmCorrida;
using ApostaEmCorrida.Domain;

namespace ApostaEmCorrida.Menu
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            char MenuCadastro,MenuAposta;
            double taxaCadastro, taxaAposta;
            Casa casa = Casa.CadastrarCasa();
            Console.WriteLine("Taxa de cadastro do cavalo");
            taxaCadastro= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Taxa de valor apostado");
            taxaAposta = Convert.ToDouble(Console.ReadLine());
            /*bool aposta=false;
            int numeroCavalos, escolha=0;
            double dinheiro_Da_Casa = 1000,valor=0*/
            ;

            Console.WriteLine("Bem-vindo a Casa de Apostas");
            do { 
            do
            {
                Console.WriteLine("[C] Cadastrar um Cavalo\n[A] Cadastrar um Apostador\n[S]Sair");
                MenuCadastro = Convert.ToChar(Console.ReadLine());
                switch (MenuCadastro)
                {
                    case 'c' or 'C':
                        casa.Cavalos.Add(Cavalo.CadastrarCavalo(casa.Cavalos));
                        casa = Casa.DepositoDeSaldo(casa, taxaCadastro);
                        ; break;
                    case 'a' or 'A':
                        casa.Apostadores.Add(Apostador.CadastrarApostador(casa.Apostadores));
                            ; break;
                    case 's' or 'S':
                        break;
                    default:
                        Console.WriteLine("Opção Inválida")
                            ; break;
                }
            } while (MenuCadastro != 's' && MenuCadastro != 'S');

            do
            {
                Console.WriteLine("[A]Cadastrar uma aposta\n[C]Corrida\n[V] Voltar ao menu de cadastro\n[Q] Sair ");
                MenuAposta = Convert.ToChar(Console.ReadLine());
                switch (MenuAposta)
                {
                    case 'A' or 'a':
                        Console.WriteLine("Opção em Desenvolvimento")
                            ; break;
                    case 'C' or 'c':
                        Console.WriteLine("Opção em Desenvolvimento")
                            ; break;
                    case 'V' or 'v':
                        Console.WriteLine("Cadastro:")
                            ; break;
                    case 'Q' or 'q':
                        Console.WriteLine("Até a próxima!")
                            ; break;
                    default:
                        Console.WriteLine("Opção Inválida")
                            ; break;
                }
            } while (MenuAposta != 'V' && MenuAposta != 'v' && MenuAposta != 'q' && MenuAposta != 'Q');

          } while (MenuAposta != 'q' && MenuAposta != 'Q');
        }
    }
}