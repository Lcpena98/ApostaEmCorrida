using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApostaEmCorrida.Domain
{
    public class Cavalo
    {
        public int Numero_Cavalo { get;private set; }
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Numero_de_Corridas { get;private set; }
        public int Numero_de_Vitorias { get; private set; }
        public double Desempenho { get; private set; }

        public Cavalo(int numero, string nome, double altura, double peso, int numero_de_Corridas, int numero_de_Vitorias, double desempenho)
        {
            Numero_Cavalo = numero;
            Nome = nome;
            Altura = altura;
            Peso = peso;
            Numero_de_Corridas = numero_de_Corridas;
            Numero_de_Vitorias = numero_de_Vitorias;
            Desempenho = desempenho;
        }

        //Função que cadastra os participantes
        public static void CadastrarCavalo(List<Cavalo> ListaCavalos,double saldo)
        {
            try 
            { 
            int numero=CadastrarNumero(ListaCavalos);
                Console.WriteLine("Digite o nome do cavalo");
                string nome = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite a altura do cavalo");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Peso do cavalo");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Cavalo cadastrado com sucesso");
                Console.WriteLine($"[{numero}] - {nome}");
                ListaCavalos.Add(new Cavalo(numero, nome, altura, peso, 0, 0, 100));
                saldo += 50;
            }
            catch (ApplicationException ex) 
            {
                Console.WriteLine("Erro! Não foi possível realizar o cadastro do cavalo!"); 
            }


        }

        //Função que cria o numero do cavalo e impede que haja 2 cavalos com o mesmo numero
        public static int CadastrarNumero(List<Cavalo> cavalosCadastrados)
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
        //Função que atualiza os dados dos Cavalos
        public static void AtualizarDesempenho(List<Cavalo> cavalos, Cavalo resultado)
        {
            {
                foreach (Cavalo cavalo in cavalos)
                {
                    cavalo.Numero_de_Corridas += 1;
                    if (cavalo == resultado)
                    {
                        cavalo.Numero_de_Vitorias += 1;
                        Console.WriteLine($"O Vencedor da corrida é o {cavalo.Nome}");
                    }
                    cavalo.Desempenho = (cavalo.Numero_de_Vitorias * 100) / cavalo.Numero_de_Corridas;
                }
            }
        }
    }
}
