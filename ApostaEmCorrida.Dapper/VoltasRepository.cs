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
    public class VoltasRepository : Conexao, IVoltasRepository
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
            return new Voltas(corridaSelecionada, cavalo, nVolta, tempoPercorrido, distanciaPercorrida);
        }
        public List<Voltas> BuscarVoltasPorCorridaECompetidor(Corrida corrida, Cavalo cavalo)
        {
            string sql = @"
                SELECT *
                FROM VOLTA
                WHERE Id_Corrida = @Id_Corrida AND Id_Cavalo = @Id_Cavalo
                ORDER BY NumeroVolta ASC";
            var voltas = banco.Query<Voltas>(sql, new
            {
                Id_Corrida = corrida.Corrida_Id,
                Id_Cavalo = cavalo.Numero_Cavalo
            }).ToList();
            return voltas;
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
        public void CadastrarFimCorrida(ResultadoCorrida resultadoCorrida)
        {
            string sql = @"
                INSERT INTO RESULTADO_CORRIDA (Id_Corrida, Id_Cavalo, Duracao)
                VALUES (@Id_Corrida, @Id_Cavalo, @TempoTotalCavalo)";
            banco.Execute(sql, new
            {
                Id_Corrida = resultadoCorrida.Corrida.Corrida_Id,
                Id_Cavalo = resultadoCorrida.Corredor.Numero_Cavalo,
                TempoTotalCavalo = resultadoCorrida.Duracao
            });
        }
        public void OrdenarCompetidores(Corrida corrida)
        {
            string sql = @"WITH Ordered AS (
                          SELECT 
	                       Id_Resultado,
                           ROW_NUMBER() OVER (ORDER BY Duracao ASC) AS NovaPosicao
                           FROM RESULTADO_CORRIDA
                           WHERE Id_Corrida = @Id_Corrida
                           )
                           UPDATE R
                           SET R.Posicao = O.NovaPosicao
                           FROM RESULTADO_CORRIDA R
                           JOIN Ordered O ON R.Id_Resultado = O.Id_Resultado;";
            banco.Execute(sql, new
            {
                Id_Corrida = corrida.Corrida_Id
            });
        }
        public List<ResultadoCorrida> BuscarResultadoCorrida(Corrida corrida)
        {
            new List<ResultadoCorrida>();
            string sql = @"
                SELECT *
                FROM RESULTADO_CORRIDA
                WHERE Id_Corrida = @Id_Corrida
                ORDER BY Posicao ASC";

            var resultados = banco.Query<ResultadoCorrida>(sql, new { Id_Corrida = corrida.Corrida_Id }).ToList();
            if (resultados.Any())
            {
                string sqlCavalos = @"SELECT *
                           FROM CAVALO cav
                           WHERE cav.Numero_Cavalo IN(
                           SELECT Id_Cavalo
                           FROM RESULTADO_CORRIDA ins
                           LEFT JOIN CAVALO cav
                           ON ins.Id_Cavalo = cav.Numero_Cavalo and Id_Corrida = @Id_Corrida)";
                var cavalos = banco.Query<Cavalo>(sqlCavalos, new { Id_Corrida = corrida.Corrida_Id }).ToList();
                foreach (var resultado in resultados)
                {
                    resultado.Corrida = corrida;
                    resultado.Corredor = cavalos.FirstOrDefault(c => c.Numero_Cavalo == resultado.Id_Cavalo);
                }

            }

         
            return resultados;
        }
    }
}