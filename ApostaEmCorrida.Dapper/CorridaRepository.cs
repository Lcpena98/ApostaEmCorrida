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
        public List<Corrida> BuscarCorridasPorStatus(int status)
        {
            int statusCorrida = status;
            List<Corrida> corridas = new List<Corrida>();
            string sql = @"
                SELECT c.Id_Corrida AS Corrida_Id, 
                       c.Numero_Voltas AS Numero_de_Voltas,
                       c.Percurso,
                       c.DataInicio,
                       c.StatusCorrida AS CorridaStatus
                FROM CORRIDA c
                WHERE c.StatusCorrida = @StatusCorrida";
            corridas = banco.Query<Corrida>(sql, new { StatusCorrida = statusCorrida }).ToList();
            return new List<Corrida>(corridas);
        }
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
                    StatusCorrida = corrida.CorridaStatus
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
                return new RetornoStatus(true, "Corrida agendada com sucesso!");

            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Falha ao cadastrar a corrida");
            }
        }

        public RetornoStatus CadastrarParticipantes(Corrida corrida, List<Cavalo> competidores)
        {
            try
            {
                foreach (Cavalo cavalo in competidores)
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
                return new RetornoStatus(true, "Participantes cadastrados com sucesso!");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Falha ao cadastrar os participantes");
            }
        }
        public RetornoStatus RemoverParticipantes(Corrida corrida, List<Cavalo> competidores)
        {
            try
            {
                foreach (Cavalo cavalo in competidores)
                {
                    string sqlCompetidor = @"DELETE FROM INSCRICAO_CORRIDA WHERE Id_Corrida = @Id_Corrida AND Id_Cavalo = @Numero_Cavalo";
                    banco.Execute(sqlCompetidor, new
                    {
                        Id_Corrida = corrida.Corrida_Id,
                        Numero_Cavalo = cavalo.Numero_Cavalo
                    });
                }
                return new RetornoStatus(true, "Participantes Removidos com sucesso!");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Falha ao remover os participantes");
            }
        }
        public List<Cavalo> BuscarCompetidores(Corrida corrida)
        {
            string sql = @"
                SELECT cav.Numero_Cavalo,
                       cav.Nome,
                       cav.Raca,
                       cav.Altura,
                       cav.Peso,
                       cav.Numero_de_Corridas,
                       cav.Numero_de_Vitorias,
                       cav.Desempenho,
                       cav.StatusCavalo
                FROM INSCRICAO_CORRIDA ic
                JOIN CAVALO cav ON ic.Id_Cavalo = cav.Numero_Cavalo
                WHERE ic.Id_Corrida = @Id_Corrida";
            List<Cavalo> competidores = banco.Query<Cavalo>(sql, new { Id_Corrida = corrida.Corrida_Id }).ToList();
            return new List<Cavalo>(competidores);
        }

        public RetornoStatus AtualizarDadosDaCorrida(Corrida corrida, int Numero_Voltas,double percurso,DateTime dataInicio)
        {
            try
            {
                string sql = @"
                UPDATE CORRIDA
                SET Numero_Voltas = @Numero_Voltas,
                    Percurso = @Percurso,
                    DataInicio = @DataInicio
                WHERE Id_Corrida = @Id_Corrida";
                banco.Execute(sql, new
                {
                    Numero_Voltas = Numero_Voltas,
                    Percurso = percurso,
                    DataInicio = dataInicio,
                    Id_Corrida = corrida.Corrida_Id
                });
                return new RetornoStatus(true, "Dados da corrida atualizados com sucesso!");
            }
            catch (Exception ex) 
            {
                return new RetornoStatus(false, "Não foi possível atualizar os dados da corrida!");
            }
        }

        public RetornoStatus CancelarCorrida(Corrida corrida)
        {
            string sql = @"delete from INSCRICAO_CORRIDA where Id_Corrida = @Corrida_Id";
            banco.Execute(sql, new { Corrida_Id= corrida.Corrida_Id});
            sql = @"delete from CORRIDA where Id_Corrida = @Corrida_Id";
            banco.Execute(sql, new { Corrida_Id = corrida.Corrida_Id });
            return new RetornoStatus(true, "Corrida cancelada com sucesso!");
        }
        public void IniciarCorrida()
        {
            throw new NotImplementedException();
        }
        public void CadastrarFimCorrida()
        {
            throw new NotImplementedException();
        }

        public void FinalizarCorrida()
        {
            throw new NotImplementedException();
        }
    }
}
