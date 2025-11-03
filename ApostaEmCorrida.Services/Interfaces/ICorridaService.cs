using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface ICorridaService
    {
        public RetornoStatus AgendarCorrida(Corrida corrida);
        public void IniciarCorrida();
        public void CadastrarFimCorrida();
        public void FinalizarCorrida();
    }
}
