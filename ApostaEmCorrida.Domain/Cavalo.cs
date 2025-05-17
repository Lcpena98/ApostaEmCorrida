using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Cavalo
    {
        public int Id_Cavalo { get; set; }
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Numero_de_Corridas { get;private set; }
        public int Numero_de_Vitorias { get; private set; }
        public double Desempenho { get; private set; }
    }
    //Função que cadastra os participantes
    public static Cavalo CadastrarCavalo(List<Cavalo> ListaCavalos)
    {
        Cavalo cavalo = new Cavalo();
        if (ListaCavalos.Count() == 0)
        {
            cavalo.Id_Cavalo = 1;
        }
        else
        {
            cavalo.Id_Cavalo = (ListaCavalos.Max().Id_Cavalo + 1);
        }
        {
            Console.WriteLine("Digite o nome do cavalo");
            cavalo.Nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a altura do cavalo");
            cavalo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o Peso do cavalo");
            cavalo.Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cavalo cadastrado com sucesso");
            cavalo.Numero_de_Corridas = 0;
            cavalo.Numero_de_Vitorias = 0;
            cavalo.Desempenho = 100;
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
