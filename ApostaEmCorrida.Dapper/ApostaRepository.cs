using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ApostaEmCorrida.Dapper
{
    public class ApostaRepository : Conexao, IApostaRepository
    {
        public RetornoStatus AtualizarStatus(Aposta aposta, int novoStatus)
        {
            string sql = @"UPDATE APOSTA
                           SET StatusAposta = @NovoStatus
                           WHERE Id_Corrida = @CorridaId AND CavaloApostado = @CavaloId AND Apostador = @ApostadorId";
            try
            {
                banco.Execute(sql, new { NovoStatus = novoStatus, CorridaId = aposta.Corrida_Id, CavaloId = aposta.Cavalo_Id, ApostadorId = aposta.Apostador_Id });
                return new RetornoStatus(true, "Status da aposta atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Erro ao atualizar status da aposta: " + ex.Message);
            }
        }
        public List<Aposta> BuscarApostasPorApostador(Apostador apostador)
        {
            try
            {
                List<Aposta> apostas = new List<Aposta>();
                string sqlAposta = @"SELECT Id_Corrida AS Corrida_Id,
                             CavaloApostado AS Cavalo_Id,
                             Apostador AS Apostador_Id,
                             ValorApostado,
                             StatusAposta AS Status,
                             valorPremio AS ValorPremio
                             FROM APOSTA
                             WHERE Apostador = @NumeroApostador";

                string sqlCorrida = @"SELECT c.Id_Corrida AS Corrida_Id, 
                       c.Numero_Voltas AS Numero_de_Voltas,
                       c.Percurso,
                       c.DataInicio,
                       c.DataFim,
                       c.StatusCorrida AS CorridaStatus,
					   ValorApostado
                FROM CORRIDA c
                WHERE c.Id_Corrida = @corridaId";

                string sqlCavalo = @"SELECT * FROM CAVALO WHERE Numero_Cavalo = @Numero_Cavalo";
                apostas = banco.Query<Aposta>(sqlAposta, new { NumeroApostador = apostador.Numero }).ToList();
                foreach (Aposta aposta in apostas)
                {
                    aposta.CorridaApostada = banco.QueryFirstOrDefault<Corrida>(sqlCorrida, new { CorridaId = aposta.Corrida_Id });
                    aposta.CavaloApostado = banco.QueryFirstOrDefault<Cavalo>(sqlCavalo, new { Numero_Cavalo = aposta.Cavalo_Id });
                    aposta.Apostador = apostador;
                }
                return apostas;
            }
            catch (Exception)
            {
                return new List<Aposta>();
            }
        }
        public RetornoStatus RegistrarAposta(Corrida corrida, int numeroCavalo, int numeroApostador, double valorApostado)
        {
            try
            {
                string sql = @"INSERT INTO APOSTA (Id_Corrida, CavaloApostado, Apostador, ValorApostado,StatusAposta)
                                VALUES (@CorridaId, @NumeroCavalo, @NumeroApostador, @ValorApostado,0)"; ;
                banco.Execute(sql, new { CorridaId = corrida.Corrida_Id, NumeroCavalo = numeroCavalo, NumeroApostador = numeroApostador, ValorApostado = valorApostado });
                return new RetornoStatus(true, "Aposta registrada com sucesso!");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Erro ao registrar aposta: " + ex.Message);
            }
        }
        public List<Aposta> BuscarApostasPorCorrida(Corrida corrida)
        {
            try
            {
                List<Aposta> apostas = new List<Aposta>();
                string sqlAposta = @"SELECT Id_Corrida AS Corrida_Id,
                             CavaloApostado AS Cavalo_Id,
                             Apostador AS Apostador_Id,
                             ValorApostado,
                             StatusAposta AS Status,
                             valorPremio AS ValorPremio
                             FROM APOSTA
                             WHERE Id_Corrida = @Id_Corrida";

                string sqlApostador = @"SELECT * FROM APOSTADOR WHERE NUMERO = @Numero";

                string sqlCavalo = @"SELECT * FROM CAVALO WHERE Numero_Cavalo = @Numero_Cavalo";
                apostas = banco.Query<Aposta>(sqlAposta, new { Id_Corrida = corrida.Corrida_Id }).ToList();
                foreach (Aposta aposta in apostas)
                {
                    aposta.Apostador = banco.QueryFirstOrDefault<Apostador>(sqlApostador, new { Numero = aposta.Apostador_Id });
                    aposta.CavaloApostado = banco.QueryFirstOrDefault<Cavalo>(sqlCavalo, new { Numero_Cavalo = aposta.Cavalo_Id });
                    aposta.CorridaApostada = corrida;
                }
                return apostas;
            }
            catch (Exception)
            {
                return new List<Aposta>();
            }
        }
        public void AtualizarPremiacao(Aposta aposta, double valorPremio)
        {
            string sql = @"UPDATE APOSTA
                           SET valorPremio = @ValorPremio
                           WHERE Id_Corrida = @CorridaId AND CavaloApostado = @CavaloId AND Apostador = @ApostadorId";
            banco.Execute(sql, new { ValorPremio = valorPremio, CorridaId = aposta.Corrida_Id, CavaloId = aposta.Cavalo_Id, ApostadorId = aposta.Apostador_Id });
        }
    }
}
