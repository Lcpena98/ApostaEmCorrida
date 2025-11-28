using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using Dapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper
{
    public class ApostadorRepository : Conexao, IApostadorRepository
    {
        public RetornoDados<Apostador> BuscarApostadorPorNumero(int numero)
        {
            string sql = @"SELECT * FROM APOSTADOR WHERE NUMERO = @Numero";
            try
            {
                var apostador = banco.QueryFirstOrDefault<Apostador>(sql, new { Numero = numero });
                if (apostador != null)
                {
                    return new RetornoDados<Apostador>(true, "Bem vindo!", apostador);
                }
                else
                {
                    return new RetornoDados<Apostador>(false, "Apostador não encontrado", null);
                }
            }
            catch (Exception ex)
            {
                return new RetornoDados<Apostador>(false, "Erro ao buscar apostador: " + ex.Message, null);
            }
        }
        public RetornoDados<Apostador> BuscarApostadorPorEmail(string email)
        {
            string sql = @"SELECT * FROM APOSTADOR WHERE EMAIL = @Email";
            try
            {
                var apostador = banco.QueryFirstOrDefault<Apostador>(sql, new { Email = email });
                if (apostador != null)
                {
                    return new RetornoDados<Apostador>(true, $"Bem vindo! {apostador.Nome}", apostador);
                }
                else
                {
                    return new RetornoDados<Apostador>(false, "Apostador não encontrado", null);
                }
            }
            catch (Exception ex)
            {
                return new RetornoDados<Apostador>(false, "Erro ao buscar apostador: " + ex.Message, null);
            }
        }
        public RetornoDados<List<Apostador>> BuscarTodosApostadores()
        {
            try
            {
                return new RetornoDados<List<Apostador>>(true, "Apostadores Buscados com sucesso", banco.Query<Apostador>(@"SELECT * FROM APOSTADOR").ToList());
            }
            catch (Exception ex)
            {
                return new RetornoDados<List<Apostador>>(false, "Erro ao buscar apostadores: " + ex.Message, new List<Apostador>());
            }
        }
        public RetornoStatus CadastrarApostador(string nome, string senha, string email, int numero, double saldo)
        {
            try
            {
                string sql = @"INSERT INTO APOSTADOR (NOME, SENHA, EMAIL, NUMERO, SALDO) 
                           VALUES (@Nome, @Senha, @Email, @Numero, @Saldo)";
                banco.Execute(sql, new { Nome = nome, Senha = senha, Email = email, Numero = numero, Saldo = saldo });
                return new RetornoStatus(true, $"Apostador cadastrado com sucesso: {nome} - {numero}");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Erro ao cadastrar apostador: " + ex.Message);
            }
        }
        public RetornoStatus TrocarSenhaApostador(string senha, string novaSenha, int numero)
        {
            string sqlVerifica = @"SELECT * FROM APOSTADOR WHERE NUMERO = @Numero AND SENHA = @Senha";
            try
            {
                var apostador = banco.QueryFirstOrDefault<Apostador>(sqlVerifica, new { Numero = numero, Senha = senha });
                if (apostador != null)
                {
                    string sqlAtualiza = @"UPDATE APOSTADOR SET SENHA = @NovaSenha WHERE NUMERO = @Numero";
                    banco.Execute(sqlAtualiza, new { NovaSenha = novaSenha, Numero = numero });
                    return new RetornoStatus(true, "Senha alterada com sucesso!");
                }
                else
                {
                    return new RetornoStatus(false, "Senha atual incorreta!");
                }
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Erro ao trocar senha: " + ex.Message);
            }
        }
        public RetornoStatus AlterarDadosApostador(string nome, string email, int numero)
        {
            string sqlVerifica = @"SELECT * FROM APOSTADOR WHERE NUMERO = @Numero";
            try
            {
                var apostador = banco.QueryFirstOrDefault<Apostador>(sqlVerifica, new { Numero = numero });
                if (apostador != null)
                {
                    string sqlAtualiza = @"UPDATE APOSTADOR SET NOME = @Nome, EMAIL = @Email WHERE NUMERO = @Numero";
                    banco.Execute(sqlAtualiza, new { Nome = nome, Email = email, Numero = numero });
                    return new RetornoStatus(true, "Dados alterados com sucesso!");
                }
                else
                {
                    return new RetornoStatus(false, "Apostador não encontrado!");
                }
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Erro ao alterar dados: " + ex.Message);
            }
        }
        public RetornoStatus AdicionarSaldo(Apostador apostador, double valor)
        {
            try
            {
                if (valor < 0)
                {
                    return new RetornoStatus(false, "Valores negativos não são permitidos");
                }
                else
                {
                    string sql = @"UPDATE APOSTADOR SET Saldo += @Valor WHERE Numero = @Numero";
                    banco.Execute(sql, new { Valor = valor, Numero = apostador.Numero });
                    return new RetornoStatus(true, "Saldo adicionado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Erro ao adicionar saldo: " + ex.Message);
            }
        }
        public RetornoStatus RemoverSaldo(Apostador apostador, double valor)
        {
            try
            {
                if (apostador.Saldo < valor)
                {
                    return new RetornoStatus(false, "Saldo insuficiente!");
                }
                else if (valor < 0)
                {
                    return new RetornoStatus(false, "Valores negativos não são permitidos");
                }
                else
                {
                    string sql = @"UPDATE APOSTADOR SET Saldo -= @Valor WHERE Numero = @Numero AND Saldo >= @valor";
                    banco.Execute(sql, new { Valor = valor, Numero = apostador.Numero });
                    return new RetornoStatus(true, "Saldo adicionado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Erro ao remover saldo: " + ex.Message);
            }
        }
    }
}
