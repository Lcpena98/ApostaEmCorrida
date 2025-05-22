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
        public double ValorApostado { get; private set; }
        public string Nome { get; set; }


        public Apostador(int senha, double saldo, double valor, string nome) 
        {
            Senha = senha;
            Saldo = saldo;
            ValorApostado = valor;
            Nome = nome;
        }
        public static Apostador CadastrarApostador(List<Apostador> listaApostadores)
        {
            Console.WriteLine("Digite o nome do Apostador");
            string nome= Convert.ToString(Console.ReadLine());
            int senha = CriarSenha(listaApostadores);
            Console.WriteLine("Apostador cadastrado com sucesso");
            Console.WriteLine($"A Senha do Apostador cadastrado é {senha}");
            Apostador apostador = new Apostador(senha,0,0,nome);
            return apostador;
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
        //Fuñção que Registra a escolha do Apostador
        public static Cavalo Escolha(Cavalo[] cavalos)
        {
            int escolha;
            Console.WriteLine("Corrida de cavalos:\n\n Participantes:");
            for (int i = 0; i < cavalos.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {cavalos[i].Nome}\nAltura: {cavalos[i].Altura}m\nPeso: {cavalos[i].Peso}kg\nCorridas: {cavalos[i].Numero_de_Corridas}\nVitórias:{cavalos[i].Numero_de_Vitorias}\nDesempenho: {cavalos[i].Desempenho}%\n");
            }
            Console.WriteLine("Selecione o número do cavalo de sua aposta");
            escolha = Convert.ToInt32(Console.ReadLine());

            return cavalos[escolha - 1];
        }
    }
}
