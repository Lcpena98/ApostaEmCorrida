using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services.Interfaces
{
    public interface ICavaloService
    {
        public RetornoStatus CadastrarCavalo(string nome,string raca, double altura, double peso, int numero);
        public RetornoDados<List<Cavalo>> BuscarTodosCavalos();
        public RetornoDados<Cavalo> BuscarCavaloPorNumero(int numero);
        public RetornoDados<int> CadastrarNumero();
        public RetornoStatus AtualizarDesempenho(List<Cavalo> cavalos, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar);
        public RetornoStatus AlterarDadosCavalo(string novoNome, string novaRaca, double novaAltura, double novoPeso, int numero);
        public RetornoStatus RemoverCavalo(int numero);
    }
}
