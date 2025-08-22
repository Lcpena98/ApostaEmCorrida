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
        public void CadastrarCavalo(List<Cavalo> ListaCavalos, string nome, double altura, double peso, int numero, double saldo);
        public List<Cavalo> BuscarTodosCavalos();
        public Cavalo BuscarCavaloPorNumero(int numero);
        public int CadastrarNumero(List<Cavalo> cavalosCadastrados);
        public void AtualizarDesempenho(List<Cavalo> cavalos, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar);
    }
}
