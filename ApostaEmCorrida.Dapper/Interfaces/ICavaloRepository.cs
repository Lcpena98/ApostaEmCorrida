using ApostaEmCorrida.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Dapper.Interfaces
{
    public interface ICavaloRepository
    {
        public void CadastrarCavalo(string nome, double altura, double peso, int numero);
        public List<Cavalo> BuscarTodosCavalos();
        public Cavalo BuscarCavaloPorNumero(int numero);
        public void AtualizarDesempenho(List<Cavalo> cavalos, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar);
    }
}
