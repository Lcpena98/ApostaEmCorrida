using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Cavalo
    {
        private int Id_Cavalo { get; set; }
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Numero_de_Corridas { get;private set; }
        public int Numero_de_Vitorias { get; private set; }
        public double Desempenho { get; private set; }

        public Cavalo(int id_Cavalo, string nome, double altura, double peso, int numero_de_Corridas, int numero_de_Vitorias, double desempenho)
        {
            Id_Cavalo = id_Cavalo;
            Nome = nome;
            Altura = altura;
            Peso = peso;
            Numero_de_Corridas = numero_de_Corridas;
            Numero_de_Vitorias = numero_de_Vitorias;
            Desempenho = desempenho;
        }



        //Função que cadastra os participantes
        public static Cavalo CadastrarCavalo(List<Cavalo> ListaCavalos)
        {
            int idCavalo;
            if (ListaCavalos.Count() == 0)
            {
               idCavalo = 1;
            }
            else
            {
                idCavalo = (ListaCavalos.Max(c => c.Id_Cavalo) + 1);
            }
            {
                Console.WriteLine("Digite o nome do cavalo");
                string nome = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite a altura do cavalo");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o Peso do cavalo");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Cavalo cadastrado com sucesso");

                Cavalo cavalo = new Cavalo(idCavalo, nome, altura, peso, 0, 0, 100);
                return cavalo;
            }
        }
        //Função que atualiza os dados dos Cavalos
        public static Cavalo[] AtualizarDesempenho(Cavalo[] cavalos, Cavalo resultado)
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
                return cavalos;
            }
        }
    }
}
