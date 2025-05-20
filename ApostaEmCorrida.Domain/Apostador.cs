using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Apostador
    {
        private int Id_Apostador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; private set; }
        public double Saldo { get; private set; }
        

        public Apostador(int id_Apostador,string nome, string email, string senha, double saldo) 
        {
            Id_Apostador = id_Apostador;
            Nome = nome;
            Email = email;
            Senha = senha;
            Saldo = saldo;
        }
        public static Apostador CadastrarApostador(List<Apostador> listaApostadores)
        {
            int idApostador;
            if (listaApostadores.Count() == 0)
            {
                idApostador = 1;
            }
            else
            {
                idApostador = (listaApostadores.Max().Id_Apostador + 1);
            }
            string nome= Convert.ToString(Console.ReadLine());
            string email = Convert.ToString(Console.ReadLine());
            string senha = Convert.ToString(Console.ReadLine());
            Apostador apostador = new Apostador(idApostador,nome,email,senha,0);
            return apostador;
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
