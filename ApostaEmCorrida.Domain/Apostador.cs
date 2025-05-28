using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Apostador
    {
        public int Senha { get; private set; }//Codigo publico para a identificação do mesmo. um numero gerado para que o mesmo seja identificado caso ganhe a aposta
        public double Saldo { get; private set; }
        public string Nome { get; set; }

        public Apostador(int senha, double saldo, string nome) 
        {
            Senha = senha;
            Saldo = saldo;
            Nome = nome;
        }
        public static void CadastrarApostador(List<Apostador> listaApostadores)
        {
            Console.WriteLine("Digite o nome do Apostador");
            string nome= Convert.ToString(Console.ReadLine());
            int senha = CriarSenha(listaApostadores);
            Console.WriteLine("Apostador cadastrado com sucesso");
            Console.WriteLine($"A Senha do Apostador cadastrado é {senha}");
            listaApostadores.Add(new Apostador(senha, 0, nome));
        }

        //Função que cria uma senha de 5 digitos para o usuário e impede que haja 2 senhas iguais
        public static int CriarSenha(List<Apostador> apostadoresCadastrados)
        {
            List<int> senhasCadastradas= apostadoresCadastrados.Select(a=>a.Senha).ToList();
            Random rnd = new Random();
            int novaSenha;
            do
            {
                novaSenha = rnd.Next(10000, 99999);
            }while(senhasCadastradas.Contains(novaSenha));

            return novaSenha;
        }

        //Função que Registra a escolha do Apostador
        public static Cavalo Escolha(List<Cavalo> cavalos)
        {
            Console.WriteLine("Competidores:");
            foreach (var cavalo in cavalos) 
            { Console.WriteLine($"[{cavalo.Numero_Cavalo}] - {cavalo.Nome}"); }
            Console.WriteLine("Selecione o numero do cavalo em que a aposta foi feita");
            int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
            Cavalo escolha = cavalos.Find(c => c.Numero_Cavalo == numeroEscolhido);
            return escolha;
        }
        //Função que adiciona o saldo ao Apostador em caso de vitória
        //PARA TESTAR
        public static void AdicionarSaldo(Apostador apostador,double valor)
        {
            apostador.Saldo += valor;
        }
    }
}