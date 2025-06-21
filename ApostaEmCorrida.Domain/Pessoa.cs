using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Pessoa(string nome, string email,string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}