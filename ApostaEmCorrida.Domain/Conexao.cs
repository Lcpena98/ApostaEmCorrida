using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ApostaEmCorrida.Domain
{
    public class Conexao
    {
        public SqlConnection banco;
        public Conexao() 
        {
            banco = new SqlConnection("Server=PC-LEONARDO\\SQLEXPRESS;Database=ApostaEmCorridas_Banco;User Id=sa;Password=unauna;TrustServerCertificate=True");
        }
    }
}
