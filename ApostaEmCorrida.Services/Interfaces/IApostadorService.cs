using ApostaEmCorrida.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface IApostadorService
    {
        public void CadastrarApostador(List<Apostador> listaApostadores, string nome, string email, string senha, int numero);
        public int CriarNumero(List<Apostador> pessoasCadastradas);
        public void AdicionarSaldo(Apostador apostador, double valor);
    }
}
