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
        public Corrida Corrida { get; set; }
        public Cavalo Corredor { get; set; }
        public int Posicao { get; set; }
        public TimeOnly Duracao { get; set; }
    }
}