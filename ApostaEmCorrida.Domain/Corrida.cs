using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Corrida
    {
        public List<Cavalo> Competidores { get; set; }
        public Cavalo Primeiro_lugar { get; set; }
        public Cavalo Segundo_lugar { get; set; }
        public Cavalo Terceiro_lugar { get; set; }

        public Corrida(List<Cavalo> competidores, Cavalo primeiro_lugar, Cavalo segundo_lugar, Cavalo terceiro_lugar)
        {
            Competidores = competidores;
            Primeiro_lugar = primeiro_lugar;
            Segundo_lugar = segundo_lugar;
            Terceiro_lugar = terceiro_lugar;
        }
        public static Cavalo novaCorrida(Casa casa)
        {
            try
            {
                Cavalo primeiro, segundo, terceiro;
                Random corrida = new Random();
                primeiro = casa.Cavalos[corrida.Next(casa.Cavalos.Count)];
                do
                {
                    segundo = casa.Cavalos[corrida.Next(casa.Cavalos.Count)];
                }
                while (segundo == primeiro);

                do
                {
                    terceiro = casa.Cavalos[corrida.Next(casa.Cavalos.Count)];
                }
                while (terceiro == primeiro || terceiro == segundo);
                Cavalo.AtualizarDesempenho(casa.Cavalos, primeiro);
                casa.Corridas.Add(new Corrida(casa.Cavalos, primeiro, segundo, terceiro));
                Casa.Calculo_de_aposta(casa, primeiro);
                return primeiro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

