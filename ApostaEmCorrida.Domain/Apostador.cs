using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Apostador : Pessoa
    {
        public int Numero { get; protected set; }//Codigo publico para a identificação do mesmo. um numero gerado para que o mesmo seja identificado caso ganhe a aposta
        public double Saldo { get; private set; }


        public Apostador(string nome, string email, string senha, int numero, double saldo) : base(nome, email, senha)
        {
            Numero = numero;
            Saldo = saldo;
        }
        public static void Cadastrar(List<Pessoa> listaApostadores, string nome, string email, string senha, int numero)
        {
            listaApostadores.Add(new Apostador(nome, email, senha, numero, 0));
        }

        public override string ToString()
        {
            return $"{Nome} - {Numero}";
        }

        //Função que cria uma senha de 5 digitos para o usuário e impede que haja 2 senhas iguais
        public static int CriarNumero(List<Pessoa> pessoasCadastradas)
        {
            List<Apostador> apostadoresCadastrados = new List<Apostador>();
            foreach (Pessoa pessoa in pessoasCadastradas)
            {
                if (pessoa is Apostador)
                {
                    apostadoresCadastrados.Add(pessoa as Apostador);
                }
                else
                {
                    pessoasCadastradas.Remove(pessoa);
                }
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

        //Função que adiciona o saldo ao Apostador em caso de vitória
        public static void AdicionarSaldo(Apostador apostador, double valor)
        {
            apostador.Saldo += valor;
        }
    }
}