using ApostaEmCorrida.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper.Interfaces
{
    public interface IVoltasRepository
    {
        public Voltas RegistrarVolta(Corrida corridaSelecionada, Cavalo cavalo, int nVolta, TimeSpan tempoPercorrido);
        public void RegistrarTempoVolta(Voltas volta, TimeSpan maiorTempoVolta);
        public List<Voltas> BuscarVoltasPorCorridaECompetidor(Corrida corrida, Cavalo cavalo);
        public void CadastrarFimCorrida(ResultadoCorrida resultadoCorrida);
        public void OrdenarCompetidores(Corrida corrida);
        public List<ResultadoCorrida> BuscarResultadoCorrida(Corrida corrida);
    }
}
