using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services
{
    public class ApostadorService: IApostadorService
    {

        public void CadastrarApostador(List<Apostador> listaApostadores, string nome, string email, string senha, int numero)
        {
            listaApostadores.Add(new Apostador(nome, email, senha, numero, 0));
        }

        //Função que cria uma senha de 5 digitos para o usuário e impede que haja 2 senhas iguais
        public int CriarNumero(List<Apostador> pessoasCadastradas)
        {
            List<Apostador> apostadoresCadastrados = new List<Apostador>();
            foreach (Apostador apostador in pessoasCadastradas)
            {
                apostadoresCadastrados.Add(apostador);
            }
            List<int> numerosCadastrados = apostadoresCadastrados.Select(a => a.Numero).ToList();
            Random rnd = new Random();
            int novaSenha;
            do
            {
                novaSenha = rnd.Next(10000, 99999);
            } while (numerosCadastrados.Contains(novaSenha));

            return novaSenha;
        }

        //Função que chama o metodo de adição do saldo ao Apostador em caso de vitória
        public void AdicionarSaldo(Apostador apostador, double valor)
        {
            apostador.AdicionarSaldo(apostador, valor);
        }
    }
}
