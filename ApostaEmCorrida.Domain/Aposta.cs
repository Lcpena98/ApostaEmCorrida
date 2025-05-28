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
        public Aposta(Cavalo cavalo,Apostador apostador, double valorApostado) 
        {
            CavaloApostado= cavalo;
            Apostador= apostador;
            ValorApostado= valorApostado;
        }

        //metodo para cadastrar a aposta feita
        public static Aposta NovaAposta(Casa casa, double valorApostado)
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
                    if (cavalo !=null)
                    {
                        Console.WriteLine("Cavalo selecionado");
                    }
                    else
                    {
                        Console.WriteLine("Codigo invalido");
                        foreach (Cavalo c in casa.Cavalos)
                        {
                            Console.WriteLine($"[{c.Numero_Cavalo}] - {c.Nome}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
            } while (cavalo == null);
            do 
            { 
                try
                {
                    Console.WriteLine("Digite a senha do apostador");
                    int apostadorSelecionado = Convert.ToInt32(Console.ReadLine());
                    apostador = casa.Apostadores.Find(a => a.Senha == apostadorSelecionado);
                    if (apostador != null)
                    {
                        Console.WriteLine("Apostador selecionado");
                    }
                    else
                    {
                        Console.WriteLine("Codigo invalido");
                        foreach (Apostador a in casa.Apostadores)
                        {
                            Console.WriteLine($"[{a.Senha}] - {a.Nome}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (apostador == null);
            return new Aposta(cavalo,apostador,valorApostado);
        }
    }
}