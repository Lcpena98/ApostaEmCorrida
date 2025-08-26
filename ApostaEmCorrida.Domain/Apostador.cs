using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Apostador
    {
        public string Nome { get; set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public int Numero { get; protected set; }//Codigo publico para a identificação do mesmo. um numero gerado para que o mesmo seja identificado caso ganhe a aposta
        public double Saldo { get; private set; }

        public Apostador(){ }
        public Apostador(string nome, string email, string senha, int numero, double saldo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Numero = numero;
            Saldo = saldo;
        }
        public override string ToString()
        {
            return $"{Nome} - {Numero}";
        }


        //Função que adiciona o saldo ao Apostador em caso de vitória
        public void AdicionarSaldo(Apostador apostador, double valor)
        {
            apostador.Saldo += valor;
        }
    }
}