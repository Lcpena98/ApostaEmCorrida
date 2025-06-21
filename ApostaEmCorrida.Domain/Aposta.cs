using ApostaEmCorrida.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Aposta
    {
        public Cavalo CavaloApostado { get; set; }
        public Apostador Apostador { get; set; }
        public double ValorApostado { get; set; }
        public StatusAposta Status { get; set; }

        public Aposta(Cavalo cavalo, Apostador apostador, double valorApostado)
        {
            CavaloApostado = cavalo;
            Apostador = apostador;
            ValorApostado = valorApostado;
            Status= StatusAposta.Pending;
        }

        //metodo para cadastrar a aposta feita
        public static void NovaAposta(Casa casa,Cavalo cavalo, Apostador apostador, double valorApostado)
        {
            casa.Apostas.Add(new Aposta(cavalo, apostador, valorApostado));
        }
    }
}