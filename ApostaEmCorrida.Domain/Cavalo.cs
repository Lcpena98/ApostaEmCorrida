using ApostaEmCorrida.Domain.Enumerator;
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
        public int Numero_Cavalo { get; protected set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Numero_de_Corridas { get; protected set; }
        public int Numero_de_Vitorias { get; protected set; }
        public double Desempenho { get; protected set; }

        public StatusCavalo StatusCavalo { get; set; }

        public Cavalo() { }
        public Cavalo(int numero, string nome, string raca ,double altura, double peso, int numero_de_Corridas, int numero_de_Vitorias, double desempenho,StatusCavalo statusCavalo)
        {
            Numero_Cavalo = numero;
            Nome = nome;
            Raca = raca;
            Altura = altura;
            Peso = peso;
            Numero_de_Corridas = numero_de_Corridas;
            Numero_de_Vitorias = numero_de_Vitorias;
            Desempenho = desempenho;
            StatusCavalo = statusCavalo;
        }

        public override string ToString()
        {
            return $"{Nome} - {Numero_Cavalo}";
        }



        //Função que atualiza os dados dos Cavalos
        public void AtualizarDesempenho(List<Cavalo> cavalos, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar)
        {
            {
                foreach (Cavalo cavalo in cavalos)
                {
                    cavalo.Numero_de_Corridas += 1;
                    if (cavalo == primeiroLugar)
                    {
                        cavalo.Numero_de_Vitorias += 1;
                        cavalo.StatusCavalo = StatusCavalo.PrimeiroLugar;
                    }
                    else if (cavalo == segundoLugar)
                    {
                        cavalo.StatusCavalo = StatusCavalo.SegundoLugar;
                    }
                    else if(cavalo == terceiroLugar)
                    {
                        cavalo.StatusCavalo = StatusCavalo.TerceiroLugar;
                    }
                    else
                    {
                        cavalo.StatusCavalo = StatusCavalo.Perdedor;
                    }
                    cavalo.Desempenho = (cavalo.Numero_de_Vitorias * 100) / cavalo.Numero_de_Corridas;
                }
            }
        }

    }
}
