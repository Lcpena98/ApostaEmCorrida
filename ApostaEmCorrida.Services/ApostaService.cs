using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services
{
    public class ApostaService:IApostaService
    {
        //metodo para cadastrar a aposta feita
        public void NovaAposta(Casa casa, Cavalo cavalo, Apostador apostador, double valorApostado)
        {
            casa.Apostas.Add(new Aposta(cavalo, apostador, valorApostado));
        }
    }
}
