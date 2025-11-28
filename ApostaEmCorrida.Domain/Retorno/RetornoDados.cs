using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain.Retorno
{
    public class RetornoDados<T> : RetornoStatus
    {
        public T Dados { get; set; }
        public RetornoDados(bool retorno, string message, T dados) : base(retorno, message)
        {
            Dados = dados;
        }
    }
}
