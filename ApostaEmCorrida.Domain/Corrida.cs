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
        public List<Cavalo> Competidores { get; set; }
        public Cavalo Primeiro_lugar { get; set; }
        public Cavalo Segundo_lugar { get; set; }
        public Cavalo Terceiro_lugar { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim {  get; set; }
        public TimeSpan Duracao { get; set; }
        public CorridaStatus CorridaStatus { get; set; }
        public Corrida(List<Cavalo> competidores, CorridaStatus corridaStatus)
        {
            Competidores = competidores;
            CorridaStatus = corridaStatus;
        }
    }
}

