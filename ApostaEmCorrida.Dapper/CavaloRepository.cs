using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper
{
    public class CavaloRepository : ICavaloRepository
    {
        protected readonly IConfiguration _config;

        public CavaloRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection DbConnection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public Cavalo BuscarCavaloPorNumero(int numero)
        {
            try
            {
                using IDbConnection dbConnection = DbConnection;
                dbConnection.Open();
                string query = @"SELECT * FROM CAVALO WHERE Numero_Cavalo = @Numero_Cavalo";
                return dbConnection.Query<Cavalo>(query, new { Numero_Cavalo = numero }).FirstOrDefault();
            }
            catch (Exception ex)
            {
            throw new Exception($"Erro ao buscar cavalo por numero: {ex.Message}", ex);
            }
        }

        public List<Cavalo> BuscarTodosCavalos()
        {
            try
            {
                using IDbConnection dbConnection = DbConnection;
                dbConnection.Open();
                string query = @"SELECT * FROM CAVALO";
                return dbConnection.Query<Cavalo>(query).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todos os cavalos: {ex.Message}", ex);
            }
        }

        public int CadastrarNumero(List<Cavalo> cavalosCadastrados)
        {
            throw new NotImplementedException();
        }

        public void CadastrarCavalo(List<Cavalo> ListaCavalos, string nome, double altura, double peso, int numero, double saldo)
        {
            throw new NotImplementedException();
        }
        public void AtualizarDesempenho(List<Cavalo> cavalos, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar)
        {
            throw new NotImplementedException();
        }
    }
}
