using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
        public static Pessoa Cadasrar()
        {
            Console.WriteLine("Digite o nome do Apostador");
            string nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o CPF do Apostador");
            string cpf = Convert.ToString(Console.ReadLine());

            return new Pessoa(nome, cpf);
        }
    }
}