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
        public RetornoStatus RegistrarAposta(Corrida corrida, int numeroCavalo, int numeroApostador, double valorApostado)
        {
            try
            {
                string sql = @"INSERT INTO APOSTA (Id_Corrida, CavaloApostado, Apostador, ValorApostado,StatusAposta)
                                VALUES (@CorridaId, @NumeroCavalo, @NumeroApostador, @ValorApostado,0)"; ;
                banco.Execute(sql, new {CorridaId=corrida.Corrida_Id, NumeroCavalo = numeroCavalo, NumeroApostador = numeroApostador, ValorApostado = valorApostado });
                return new RetornoStatus(true, "Aposta registrada com sucesso!");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Erro ao registrar aposta: " + ex.Message);
            }
        }
    }
}
