using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Voltas
    {
        public int Id_Volta { get; set; }
        public Corrida CorridaRegistrada { get; set; }
        public Cavalo Competidor { get; set; }
        public int NumeroVolta { get; set; }
        public TimeSpan TempoVolta { get; set; }
        public double DistanciaPercorrida { get; set; }
        public Voltas() { }
        public Voltas(Corrida corrida, Cavalo competidor, int numeroVolta, TimeSpan tempoVolta, double distanciaPercorrida)
        {
            CorridaRegistrada = corrida;
            Competidor = competidor;
            NumeroVolta = numeroVolta;
            TempoVolta = tempoVolta;
            DistanciaPercorrida = distanciaPercorrida;
        }
    }
}