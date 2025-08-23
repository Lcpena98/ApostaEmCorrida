using ApostaEmCorrida.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface ICasaService
    {
        public Casa CadastrarCasa();
        public void ValidarAposta(Corrida resultado, List<Aposta> apostas);
        public double SomaDeValoresApostados(List<Aposta> apostas);
        public void Calculo_de_aposta(Casa casa);
    }
}
