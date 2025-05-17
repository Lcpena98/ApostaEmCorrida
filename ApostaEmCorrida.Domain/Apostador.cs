using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Apostador
    {
        public int Id_Apostador { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public string email { get; set; }
        public string senha { get; set; }


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
