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

        public StatusCavalo StatusCavalo { get; set; }

        public Cavalo() { }
        public Cavalo(int numero, string nome, string raca ,double altura, double peso, int numero_de_Corridas, int numero_de_Vitorias,StatusCavalo statusCavalo)
        {
            Numero_Cavalo = numero;
            Nome = nome;
            Raca = raca;
            Altura = altura;
            Peso = peso;
            Numero_de_Corridas = numero_de_Corridas;
            Numero_de_Vitorias = numero_de_Vitorias;
            StatusCavalo = statusCavalo;
        }

        public override string ToString()
        {
            return $"{Nome} - {Numero_Cavalo}";
        }
    }
}
