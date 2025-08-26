using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain.Retorno
{
    public class RetornoStatus
    {
        public bool Sucesso { get; set; }
        public string Message { get; set; }

        public RetornoStatus(bool sucesso, string message)
        {
            Sucesso = sucesso;
            Message = message;
        }
    }
}
