using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace ApostaEmCorrida.Domain
{
    public class ResultadoCorrida
    {
        public int Id_Resultado { get; set; }
        public int Id_Cavalo { get; set; }
        public Corrida Corrida { get; set; }
        public Cavalo Corredor { get; set; }
        public int Posicao { get; set; }
        public TimeSpan Duracao { get; set; }
        public ResultadoCorrida() { }
        public ResultadoCorrida(Corrida corrida, Cavalo corredor, TimeSpan duracao)
        {
            Corrida = corrida;
            Corredor = corredor;
            Duracao = duracao;
        }
    }
}