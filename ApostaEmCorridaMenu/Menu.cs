using System;
using ApostaEmCorrida;
using ApostaEmCorrida.Domain;

namespace ApostaEmCorrida.Menu
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            char MenuCadastro, MenuAposta;
            double taxaCadastro, taxaAposta;
            Casa casa = Casa.CadastrarCasa();


            Console.WriteLine("Bem-vindo a Casa de Apostas");
            do
            {
                do
                {
                    Console.WriteLine("[C]Corrida");
                    MenuAposta = Convert.ToChar(Console.ReadLine());
                    switch (MenuAposta)
                    {
                        case 'C' or 'c':
                            Cavalo vencedor = Casa.Corrida(casa.Cavalos);
                            Console.WriteLine($"Vencedor:\n[{vencedor.Numero_Cavalo}] - {vencedor.Nome}\n");
                            foreach (var cavalo in casa.Cavalos)
                            {
                                Console.WriteLine($"[{cavalo.Numero_Cavalo}] - {cavalo.Nome}\n{cavalo.Numero_de_Corridas} Corridas realizadas\n{cavalo.Numero_de_Vitorias} Vitórias\nDesempenho de {cavalo.Desempenho}%");
                            }
                            Casa.Calculo_de_aposta(casa, vencedor);
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