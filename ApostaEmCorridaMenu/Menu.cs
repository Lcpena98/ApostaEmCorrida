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
            ;

            Console.WriteLine("Bem-vindo a Casa de Apostas");
            do 
            { 
                do
                {
                    Console.WriteLine("[C] Cadastrar um Cavalo\n[A] Cadastrar um Apostador\n[S]Sair");
                    MenuCadastro = Convert.ToChar(Console.ReadLine());
                    switch (MenuCadastro)
                    {
                        case 'c' or 'C':
                            //A taxa de inscrição está por R$50
                            Cavalo.CadastrarCavalo(casa.Cavalos,casa.Saldo);
                            ; break;
                        case 'a' or 'A':
                            Apostador.CadastrarApostador(casa.Apostadores);
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
                            Casa.CadastrarAposta(casa)
                                ; break;
                        case 'C' or 'c':
                            Cavalo vencedor = Casa.Corrida(casa.Cavalos);
                            Console.WriteLine($"Vencedor:\n[{vencedor.Numero_Cavalo}] - {vencedor.Nome}\n");
                            foreach(var cavalo in casa.Cavalos)
                            {
                                Console.WriteLine($"[{cavalo.Numero_Cavalo}] - {cavalo.Nome}\n{cavalo.Numero_de_Corridas} Corridas realizadas\n{cavalo.Numero_de_Vitorias} Vitórias\nDesempenho de {cavalo.Desempenho}%");
                            }
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