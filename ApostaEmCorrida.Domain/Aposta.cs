using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Domain
{
    public class Aposta
    {
        public Cavalo CavaloApostado { get; set; }
        public Apostador Apostador { get; set; }
        public double ValorApostado { get; set; }
        public double ValorEmAposta { get; set; }
        public Aposta(Cavalo cavalo,Apostador apostador, double valorApostado, double valorEmAposta) 
        {
            CavaloApostado= cavalo;
            Apostador= apostador;
            ValorApostado= valorApostado;
            ValorEmAposta= valorEmAposta;
        }

        //metodo para cadastrar a aposta feita
        public static void NovaAposta(Casa casa, double valorApostado)
        {
            Cavalo cavalo = null;
            Apostador apostador = null;
            do
            {
                try
                {
                    Console.WriteLine("Digite o numero do Cavalo em que a aposta foi feita");
                    int cavaloEscolhido = Convert.ToInt32(Console.ReadLine());
                    cavalo = casa.Cavalos.Find(c => c.Numero_Cavalo == cavaloEscolhido);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Codigo invalido");
                    Console.WriteLine(ex.Message);
                    foreach(Cavalo c in casa.Cavalos)
                    {
                        Console.WriteLine($"[{c.Numero_Cavalo}] - {c.Nome}");
                    }
                    cavalo = null;
                }
            } while (cavalo == null);
            do 
            { 
                try
                {
                    Console.WriteLine("Digite a senha do apostador");
                    int apostadorSelecionado = Convert.ToInt32(Console.ReadLine());
                    apostador = casa.Apostadores.Find(a => a.Senha == apostadorSelecionado);
                }
                //NÃO ESTÁ VALIDANDO O CATCH
                catch (Exception ex)
                {
                    Console.WriteLine("Codigo invalido");
                    Console.WriteLine(ex.Message);
                    foreach (Apostador a in casa.Apostadores)
                    {
                        Console.WriteLine($"[{a.Senha}] - {a.Nome}");
                    }
                    apostador = null;
                }
            } while (apostador == null);
            double totalApostado = valorApostado;
            if (casa.Apostas.Any()) 
            {
                totalApostado = casa.Apostas[0].ValorEmAposta+valorApostado;
            }
            foreach(var aposta in casa.Apostas)
            {
                aposta.ValorEmAposta = totalApostado;
            }
            casa.Apostas.Add(new Aposta(cavalo,apostador,valorApostado, totalApostado));
        }
    }
}
