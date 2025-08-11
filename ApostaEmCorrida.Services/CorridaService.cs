using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Enumerator;
using ApostaEmCorrida.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services
{
    public class CorridaService : ICorridaService
    {
        protected readonly CasaService _casaService;
        protected readonly CavaloService _cavaloService;
        public CorridaService(CasaService casaService, CavaloService cavaloService)
        {
            _casaService = casaService;
            _cavaloService = cavaloService;
        }

        public void CadastrarCorrida(Casa casa)
        {
            Corrida corrida = new Corrida(casa.Cavalos, CorridaStatus.Waiting);
            casa.CorridaAtual = corrida;
        }
        public void IniciarCorrida(Casa casa)
        {
            try
            {
                if (casa.CorridaAtual.CorridaStatus == CorridaStatus.Waiting)
                {
                    casa.CorridaAtual.DataInicio = DateTime.Now;
                    casa.CorridaAtual.CorridaStatus = CorridaStatus.InProgress;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CadastrarFimCorrida(Casa casa)
        {
            if (casa.CorridaAtual.CorridaStatus == CorridaStatus.InProgress)
            {
                casa.CorridaAtual.DataFim = DateTime.Now;
                casa.CorridaAtual.Duracao = casa.CorridaAtual.DataFim - casa.CorridaAtual.DataInicio;
                casa.CorridaAtual.CorridaStatus = CorridaStatus.Finished;
            }
        }
        public void FinalizarCorrida(Casa casa,Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar)
        {
            try
            {
                if (casa.CorridaAtual.CorridaStatus == CorridaStatus.InProgress)
                {
                    casa.CorridaAtual.DataFim = DateTime.Now;
                    casa.CorridaAtual.Duracao = casa.CorridaAtual.DataFim - casa.CorridaAtual.DataInicio;
                    casa.CorridaAtual.CorridaStatus = CorridaStatus.Finished;
                }
                casa.CorridaAtual.Primeiro_lugar = primeiroLugar;
                casa.CorridaAtual.Segundo_lugar = segundoLugar;
                casa.CorridaAtual.Terceiro_lugar = terceiroLugar;
                casa.Corridas.Add(casa.CorridaAtual);
                _cavaloService.AtualizarDesempenho(casa.Cavalos,primeiroLugar,segundoLugar, terceiroLugar);
                _casaService.ValidarAposta(casa.CorridaAtual, casa.Apostas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

