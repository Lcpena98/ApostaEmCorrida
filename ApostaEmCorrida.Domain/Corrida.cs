using ApostaEmCorrida.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApostaEmCorrida.Domain.Enumerator;

namespace ApostaEmCorrida.Domain
{
    public class Corrida
    {
        public int Corrida_Id { get; set; }
        public List<Cavalo> Competidores { get; set; } = new List<Cavalo>();
        public int Numero_de_Voltas { get; set; }
        public List<Voltas> Voltas { get; set; } = new List<Voltas>();
        public double Percurso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim {  get; set; }
        public TimeSpan Duracao { get; set; }
        public CorridaStatus CorridaStatus { get; set; }
        public double ValorApostado { get; set; }

        public Corrida() { }
        public Corrida(List<Cavalo> competidores,int numero_de_voltas, double percurso, DateTime dataInicio)
        {
            Competidores = competidores;
            Numero_de_Voltas = numero_de_voltas;
            Percurso = percurso;
            DataInicio = dataInicio;
        }
    }
}

