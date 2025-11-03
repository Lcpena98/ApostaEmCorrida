using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Enumerator;
using ApostaEmCorrida.Domain.Retorno;
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
        protected readonly ICorridaRepository _corridaRepository;

        public CorridaService(ICorridaRepository corridaRepository)
        {
            _corridaRepository = corridaRepository;
        }

        public RetornoStatus AgendarCorrida(Corrida corrida)
        {
           return _corridaRepository.AgendarCorrida(corrida);
        }
        public void IniciarCorrida()
        {
            try
            {
                /*if (casa.CorridaAtual.CorridaStatus == CorridaStatus.EmAndamento)
                {
                    casa.CorridaAtual.DataInicio = DateTime.Now;
                    casa.CorridaAtual.CorridaStatus = CorridaStatus.EmAndamento;
                }*/
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CadastrarFimCorrida()
        {
            /*if (casa.CorridaAtual.CorridaStatus == CorridaStatus.EmAndamento)
            {
                casa.CorridaAtual.DataFim = DateTime.Now;
                casa.CorridaAtual.Duracao = casa.CorridaAtual.DataFim - casa.CorridaAtual.DataInicio;
                casa.CorridaAtual.CorridaStatus = CorridaStatus.Finalizada;
            }*/
        }
        public void FinalizarCorrida()
        {
            try
            {
                /*if (casa.CorridaAtual.CorridaStatus == CorridaStatus.EmAndamento)
                {
                    casa.CorridaAtual.DataFim = DateTime.Now;
                    casa.CorridaAtual.Duracao = casa.CorridaAtual.DataFim - casa.CorridaAtual.DataInicio;
                    casa.CorridaAtual.CorridaStatus = CorridaStatus.Finalizada;
                }*/
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}