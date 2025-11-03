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
    public class CorridaRepository : Conexao, ICorridaRepository
    {
        public RetornoStatus AgendarCorrida(Corrida corrida)
        {
            try
            {
                string sql = @"
                INSERT INTO CORRIDA (Numero_Voltas,Percurso, DataInicio, StatusCorrida)
                OUTPUT INSERTED.Id_Corrida
                VALUES (@NumeroVoltas,@Percurso, @DataHoraInicio, @StatusCorrida)";
                int novaCorridaId = banco.ExecuteScalar<int>(sql, new
                {
                    NumeroVoltas = corrida.Numero_de_Voltas,
                    Percurso = corrida.Percurso,
                    DataHoraInicio = corrida.DataInicio,
                    StatusCorrida=corrida.CorridaStatus
                });
                string sqlParticipantes = @"
                    INSERT INTO INSCRICAO_CORRIDA (Id_Corrida, Id_Cavalo)
                    VALUES (@Id_Corrida, @Numero_Cavalo)";
                foreach (var cavalo in corrida.Competidores)
                    {
                    banco.Execute(sqlParticipantes, new
                    {
                        Id_Corrida = novaCorridaId,
                        Numero_Cavalo = cavalo.Numero_Cavalo
                    });
                }
                return new RetornoStatus(true,"Corrida agendada com sucesso!");
               
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Falha ao cadastrar a corrida");
            }
        }

        public void CadastrarParticipantes(Corrida corrida,List<Cavalo> competidores)
        {
            foreach (var cavalo in competidores)
            {
                string sqlCompetidor = @"
                    INSERT INTO INSCRICAO_CORRIDA (Id_Corrida, Id_Cavalo)
                    VALUES (@Id_Corrida, @Numero_Cavalo)";
                banco.Execute(sqlCompetidor, new
                {
                    Id_Corrida = corrida.Corrida_Id,
                    Numero_Cavalo = cavalo.Numero_Cavalo
                });
            }
        }
        public void CadastrarFimCorrida()
        {
            throw new NotImplementedException();
        }

        public void FinalizarCorrida()
        {
            throw new NotImplementedException();
        }

        public void IniciarCorrida()
        {
            throw new NotImplementedException();
        }
    }
}
