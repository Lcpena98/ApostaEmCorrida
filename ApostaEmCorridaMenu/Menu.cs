using System;
using ApostaEmCorrida;
using ApostaEmCorrida.Domain;

namespace ApostaEmCorrida.Menu
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            char opcao;
            bool aposta=false;
            int numeroCavalos, escolha=0;
            double dinheiro_Da_Casa = 1000,valor=0;

            Console.WriteLine("Digite o numero de cavalos participantes");
            numeroCavalos = Convert.ToInt32(Console.ReadLine());
            Cavalo[] cavalos = new Cavalo[numeroCavalos];
            for (int i = 0; i < numeroCavalos; i++)
            {
                cavalos[i] = CadastrarCavalo();
                Console.WriteLine(cavalos[i].Nome);
            }

            do
            {
                Console.WriteLine("[d] Depositar\n[s] Sacar\n[e] Extrato\n[a] fazer uma aposta\n[c]Corrida\n[q] Sair ");
                opcao = Convert.ToChar(Console.ReadLine());
                switch (opcao)
                {
                    case 'd':
                        Console.WriteLine("Opção em Desenvolvimento")
                            ; break;
                    case 's':
                        Console.WriteLine("Opção em Desenvolvimento")
                            ; break;
                    case 'e':
                        Console.WriteLine("Opção em Desenvolvimento")
                            ; break;
                    case 'a':
                        Console.WriteLine("Selecione o valor a apostar");
                        valor = Convert.ToDouble(Console.ReadLine());
                        escolha = Escolha(cavalos);
                        aposta = true;
                        ; break;
                    case 'c':
                        int corrida = Corrida(cavalos);
                        cavalos = AtualizarDesempenho(cavalos, corrida);
                        if (aposta) dinheiro_Da_Casa = ValidarAposta(corrida, escolha, dinheiro_Da_Casa, valor);
                        valor = 0;
                        aposta = false;
                        ; break;
                    case 'q':
                        Console.WriteLine("Até a próxima!")
                            ; break;
                    default:
                        Console.WriteLine("Opção Inválida")
                            ; break;
                }
            } while (opcao != 'q');
        }
    }
}