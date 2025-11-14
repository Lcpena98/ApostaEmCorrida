using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper
{
    public class VoltasRepository :Conexao, IVoltasRepository
    {
        public Voltas RegistrarVolta(Corrida corridaSelecionada, Cavalo cavalo, int nVolta, TimeSpan tempoPercorrido)
        {
            double distanciaPercorrida = (corridaSelecionada.Percurso) * nVolta;
            string sql = @"
                INSERT INTO VOLTA (Id_Corrida,Id_Cavalo,NumeroVolta, TempoVolta,DistanciaPercorrida)
                VALUES (@Id_Corrida, @Id_Cavalo, @Numero_Volta, @Tempo_Volta,@DistanciaPercorrida)";
            banco.Execute(sql, new
            {
                Id_Corrida = corridaSelecionada.Corrida_Id,
                Id_Cavalo = cavalo.Numero_Cavalo,
                Numero_Volta = nVolta,
                Tempo_Volta = tempoPercorrido,
                DistanciaPercorrida = distanciaPercorrida
            });
            return new Voltas(corridaSelecionada,cavalo, nVolta, tempoPercorrido, distanciaPercorrida);
        }
        public void RegistrarTempoVolta(Voltas volta, TimeSpan maiorTempoVolta)
        {
            string sql = @"
                UPDATE VOLTA
                SET TempoVolta = @Tempo_Volta
                WHERE Id_Volta = @Id_Volta";
            banco.Execute(sql, new
                {
                Tempo_Volta = maiorTempoVolta,
                Id_Volta = volta.Id_Volta
            });
        }
    }
}
