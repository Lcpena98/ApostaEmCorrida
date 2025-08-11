using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Services.Interfaces;
using ApostaEmCorrida.Domain.Enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services
{
    public class CasaService : ICasaService
    {
        protected readonly ApostadorService _apostadorService;
        protected readonly ApostaService _apostaService;
        protected readonly CavaloService _cavaloService;
        protected readonly CorridaService _corridaService;
        public CasaService(ApostadorService apostadorService, ApostaService apostaService, CavaloService cavaloService, CorridaService corridaService)
        {
            _apostadorService = apostadorService;
            _apostaService = apostaService;
            _cavaloService = cavaloService;
            _corridaService = corridaService;
        }
        public Casa CadastrarCasa()
        {
            List<Cavalo> cavalos = new List<Cavalo>();
            List<Apostador> apostadores = new List<Apostador>();
            List<Aposta> apostas = new List<Aposta>();
            List<Corrida> corridas = new List<Corrida>();

            return new Casa(0, cavalos, apostadores, apostas, corridas, 0);
        }

        //Função que valida o resultado da aposta e separa as pessoas que venceram
        public void ValidarAposta(Corrida resultado, List<Aposta> apostas)
        {
            List<Aposta> vencedores = new List<Aposta>();
            foreach (var aposta in apostas)
            {
                if (aposta.CavaloApostado.StatusCavalo == StatusCavalo.FirstPlace)
                {
                    aposta.Status = StatusAposta.FirstPlace;
                    vencedores.Add(aposta);
                }
                else if (aposta.CavaloApostado.StatusCavalo == StatusCavalo.SecondPlace)
                {
                    aposta.Status = StatusAposta.SecondPlace;
                    vencedores.Add(aposta);
                }
                else if (aposta.CavaloApostado.StatusCavalo == StatusCavalo.ThirdPlace)
                {
                    aposta.Status = StatusAposta.ThirdPlace;
                    vencedores.Add(aposta);
                }
                else
                {
                    aposta.Status = StatusAposta.Lose;
                }
            }
        }
        public double SomaDeValoresApostados(List<Aposta> apostas)
        {
            double valorApostado = 0;
            foreach (var aposta in apostas)
            {
                valorApostado += aposta.ValorApostado;
            }

            return valorApostado;
        }

        //PARA TESTAR
        public void Calculo_de_aposta(Casa casa)
        {
            try
            {
                if (casa.CorridaAtual.CorridaStatus == CorridaStatus.Finished)
                {
                    double valorApostadoTotal = this.SomaDeValoresApostados(casa.Apostas);
                    List<Aposta> totalVencedores = new List<Aposta>();
                    List<Aposta> apostasPrimeiro = new List<Aposta>();
                    List<Aposta> apostasSegundo = new List<Aposta>();
                    List<Aposta> apostasTerceiro = new List<Aposta>();


                    foreach (var aposta in casa.Apostas)
                    {
                        if (aposta.Status == StatusAposta.FirstPlace)
                        {
                            totalVencedores.Add(aposta);
                            apostasPrimeiro.Add(aposta);
                        }
                        else if (aposta.Status == StatusAposta.SecondPlace)
                        {
                            totalVencedores.Add(aposta);
                            apostasSegundo.Add(aposta);
                        }
                        else if (aposta.Status == StatusAposta.ThirdPlace)
                        {
                            totalVencedores.Add(aposta);
                            apostasTerceiro.Add(aposta);
                        }
                    }
                    double valorPrimeiro = valorApostadoTotal / 2; //Valor geral para os apostadores que apostaram no primeiro colocado
                    valorApostadoTotal -= valorPrimeiro;
                    double valorApostadorPrimeiro = valorPrimeiro / apostasPrimeiro.Count(); //Valor Individual para os apostadores que apostaram no primeiro colocado

                    double valorSegundo = valorApostadoTotal / 2; //Valor geral para os apostadores que apostaram no segundo colocado
                    valorApostadoTotal -= valorSegundo;
                    double valorApostadorSegundo = valorSegundo / apostasSegundo.Count(); //Valor individual para os apostadores que apostaram no segundo colocado

                    double valorTerceiro = valorApostadoTotal / 2; //Valor geral para os apostadores que apostaram no terceiro colocado
                    valorApostadoTotal -= valorTerceiro;
                    double valorApostadorTerceiro = valorTerceiro / apostasTerceiro.Count(); //Valor individual para os apostadores que apostaram no terceiro colocado

                    foreach (Apostador apostador in casa.Apostadores)
                    {
                        foreach (Aposta apostouNoPrimeiroColocado in apostasPrimeiro)
                        {
                            if (apostouNoPrimeiroColocado.Apostador == apostador)
                            {
                                _apostadorService.AdicionarSaldo(apostador, valorApostadorPrimeiro);
                            }
                        }
                        foreach (Aposta apostouNoSegundoColocado in apostasSegundo) 
                        {
                            _apostadorService.AdicionarSaldo(apostador, valorApostadorSegundo);
                        }
                        foreach (Aposta apostouNoTerceiroColocado in apostasTerceiro) 
                        {
                            _apostadorService.AdicionarSaldo(apostador, valorApostadorTerceiro);
                        }
                    }
                    casa.AdicionarSaldo(valorApostadoTotal);
                    foreach(Aposta aposta in casa.Apostas)
                    {
                        aposta.Status=StatusAposta.Finished;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar resultados!");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}