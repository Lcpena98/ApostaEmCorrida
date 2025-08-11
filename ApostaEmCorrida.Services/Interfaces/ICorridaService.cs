using ApostaEmCorrida.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface ICorridaService
    {
        public void CadastrarCorrida(Casa casa);
        public void IniciarCorrida(Casa casa);
        public void CadastrarFimCorrida(Casa casa);
        public void FinalizarCorrida(Casa casa, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar);
    }
}
