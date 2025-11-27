using ApostaEmCorrida.Domain.Enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Aposta
    {
        public int Aposta_ID { get; protected set; }
        public int Cavalo_Id { get; set; }
        public int Apostador_Id { get; set; }
        public int Corrida_Id { get; set; }
        public Corrida CorridaApostada { get; set; }
        public Cavalo CavaloApostado { get; set; }
        public Apostador Apostador { get; set; }
        public double ValorApostado { get; set; }
        public double ValorPremio { get; set; }
        public StatusAposta Status { get; set; }

        public Aposta() { }
        public Aposta(Cavalo cavalo, Apostador apostador, double valorApostado, Corrida corridaApostada)
        {
            CavaloApostado = cavalo;
            Apostador = apostador;
            ValorApostado = valorApostado;
            Status = StatusAposta.EmEspera;
            CorridaApostada = corridaApostada;
        }
    }
}