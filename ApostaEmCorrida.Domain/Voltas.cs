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
        public TimeOnly TempoVolta { get; set; }
        public int PosicaoNoFimVolta { get; set; }
        public double DistanciaPercorrida { get; set; }

        public Voltas(Corrida corrida, Cavalo competidor, int numeroVolta, TimeOnly tempoVolta, int posicaoNoFimVolta, double distanciaPercorrida)
        {
            CorridaRegistrada = corrida;
            Competidor = competidor;
            NumeroVolta = numeroVolta;
            TempoVolta = tempoVolta;
            PosicaoNoFimVolta = posicaoNoFimVolta;
            DistanciaPercorrida = distanciaPercorrida;
        }
    }
}