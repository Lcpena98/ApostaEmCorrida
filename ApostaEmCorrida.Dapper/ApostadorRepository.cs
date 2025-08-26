using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper
{
    public class ApostadorRepository : Conexao, IApostadorRepository
    {
        public RetornoStatus AdicionarSaldo(int numero, double valor)
        {
            throw new NotImplementedException();
        }

        public RetornoStatus AlterarDadosApostador(string nome, string email, int numero)
        {
            throw new NotImplementedException();
        }

        public RetornoDados<Apostador> BuscarApostadorPorNumero(int numero)
        {
            throw new NotImplementedException();
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

        public RetornoStatus RemoverApostador(int numero)
        {
            throw new NotImplementedException();
        }

        public RetornoStatus TrocarSenhaApostador(string senha, string novaSenha, int numero)
        {
            throw new NotImplementedException();
        }
    }
}
