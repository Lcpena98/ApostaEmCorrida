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
using ApostaEmCorrida.Domain.Retorno;

namespace ApostaEmCorrida.Dapper
{
    public class CavaloRepository : Conexao, ICavaloRepository
    {

        public RetornoDados<Cavalo> BuscarCavaloPorNumero(int numero)
        {
            try
            {
                string query = @"SELECT * FROM CAVALO WHERE Numero_Cavalo = @Numero_Cavalo";
                return new RetornoDados<Cavalo>(true, $"Cavalo buscado com sucesso!", banco.Query<Cavalo>(query, new { Numero_Cavalo = numero }).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return new RetornoDados<Cavalo>(false, $"Erro ao buscar cavalo por número: {ex.Message}", new Cavalo());
            }
        }

        public RetornoDados<List<Cavalo>> BuscarTodosCavalos()
        {
            try
            {
                return new RetornoDados<List<Cavalo>>(true, $"Lista de cavalos buscada com sucesso!", banco.Query<Cavalo>(@"SELECT * FROM CAVALO").ToList());
            }
            catch (Exception ex)
            {
                List<Cavalo> listaVazia = new List<Cavalo>();
                return new RetornoDados<List<Cavalo>>(false, $"Falha ao buscar a lista de cavalos!", listaVazia);
            }
        }

        public List<Cavalo> BuscarCavalosNaoCadastradosEmCorrida(Corrida corrida)
        {
            try
            {
                string query = @"SELECT C.*
                               FROM CAVALO C
                               LEFT JOIN INSCRICAO_CORRIDA IC 
                               ON IC.Id_Cavalo = C.Numero_Cavalo 
                               AND IC.Id_Corrida = @Corrida_Id
                               WHERE IC.Id_Cavalo IS NULL;";
                return banco.Query<Cavalo>(query, new { Corrida_Id = corrida.Corrida_Id }).ToList();
            }
            catch (Exception ex)
            {
                return new List<Cavalo>();
            }
        }
        public RetornoStatus CadastrarCavalo(string nome, string raca, double altura, double peso, int numero)
        {
            try
            {
                string query = @"INSERT INTO CAVALO (Nome, Raca, Altura, Peso, Numero_Cavalo, Numero_de_Corridas, Numero_de_Vitorias,StatusCavalo) 
                             VALUES (@Nome, @Raca, @Altura, @Peso, @Numero_Cavalo, 0, 0,0)";
                banco.Execute(query, new { Nome = nome, Raca = raca, Altura = altura, Peso = peso, Numero_Cavalo = numero });
                return new RetornoStatus(true, $"Cavalo cadastrado com sucesso!\n {nome} - {numero}");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, $"Erro ao cadastrar cavalo: {ex.Message}");
            }
        }
        public RetornoStatus AtualizarDesempenho(List<ResultadoCorrida> resultado)
        {
            try
            {
                foreach (ResultadoCorrida res in resultado)
                {
                    if (res.Posicao == 1)
                    {
                        string queryVitoria = @"UPDATE CAVALO 
                                 SET Numero_de_Corridas += 1, 
                                     Numero_de_Vitorias += 1
                                 WHERE Numero_Cavalo = @Numero_Cavalo";
                        banco.Execute(queryVitoria, new { Numero_Cavalo = res.Corredor.Numero_Cavalo });
                    }
                    else
                    {
                        string queryDerrota = @"UPDATE CAVALO 
                                 SET Numero_de_Corridas += 1
                                 WHERE Numero_Cavalo = @Numero_Cavalo";
                        banco.Execute(queryDerrota, new { Numero_Cavalo = res.Corredor.Numero_Cavalo });
                        
                        }
                    }
                return new RetornoStatus(true, $"Desempenho dos cavalos atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, $"Erro ao atualizar desempenho dos cavalos!");
            }
        }

        public RetornoStatus AlterarDadosCavalo(string novoNome, string novaRaca, double novaAltura, double novoPeso, int numero)
        {
            try
            {
                string query = @"UPDATE CAVALO 
                             SET Nome = @Nome, Raca = @Raca, Altura = @Altura, Peso = @Peso 
                             WHERE Numero_Cavalo = @Numero_Cavalo";
                banco.Execute(query, new { Nome = novoNome, Raca = novaRaca, Altura = novaAltura, Peso = novoPeso, Numero_Cavalo = numero });
                return new RetornoStatus(true, $"Dados do cavalo alterados com sucesso! Número: {numero}");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, $"Erro ao alterar dados do cavalo: {ex.Message}");
            }
        }

        public RetornoStatus RemoverCavalo(int numero)
        {
            try
            {
                string query = @"DELETE FROM CAVALO WHERE Numero_Cavalo = @Numero_Cavalo";
                banco.Execute(query, new { Numero_Cavalo = numero });
                return new RetornoStatus(true, $"Cavalo removido com sucesso! Número: {numero}");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, $"Erro ao remover cavalo: {ex.Message}");
            }
        }
    }
}
