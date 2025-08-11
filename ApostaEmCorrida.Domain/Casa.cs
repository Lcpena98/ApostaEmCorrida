using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Enumerator;

namespace ApostaEmCorrida.Domain
{
    public class Casa
    {
        public double Saldo { get; private set; }
        public List<Cavalo> Cavalos { get; set; }
        public List<Apostador> Apostadores {  get; set; }
        public List<Aposta> Apostas { get; set; }
        public List<Corrida> Corridas { get; set; }
        public Corrida CorridaAtual { get; set; }


        public Casa(double saldo, List<Cavalo> cavalos, List<Apostador> apostadores, List<Aposta> apostas, List<Corrida> corridas, double valorEmAposta)
        {
            Saldo = saldo;
            Cavalos = cavalos;
            Apostadores = apostadores;
            Corridas = corridas;
            Apostas = apostas;
        }

        public void AdicionarSaldo(double valor) 
        {
            Saldo += valor;
        }

        public void RetirarSaldo(double valor)
        {
            Saldo -= valor;
        }
    }
}