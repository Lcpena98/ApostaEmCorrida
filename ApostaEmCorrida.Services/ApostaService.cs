using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Enumerator;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services
{
    public class ApostaService : IApostaService
    {
        protected readonly IApostadorRepository _apostadorRepository;
        protected readonly IApostaRepository _apostaRepository;
        protected readonly ICorridaRepository _corridaRepository;


        public ApostaService(IApostaRepository apostaRepository, IApostadorRepository apostadorRepository, ICorridaRepository corridaRepository)
        {
            _apostadorRepository = apostadorRepository;
            _apostaRepository = apostaRepository;
            _corridaRepository = corridaRepository;
        }

        public List<Aposta> BuscarApostasPorApostador(Apostador apostador)
        {
            return _apostaRepository.BuscarApostasPorApostador(apostador);
        }

        public RetornoStatus RegistrarAposta(Corrida corrida, int numeroCavalo, int numeroApostador, double valorApostado)
        {

            RetornoStatus resultadoAposta = _apostaRepository.RegistrarAposta(corrida, numeroCavalo, numeroApostador, valorApostado);
            if (resultadoAposta.Sucesso)
            {
                RetornoStatus resultadoSoma = _corridaRepository.AdicionarValoresCorrida(corrida, valorApostado);
                _apostadorRepository.RemoverSaldo(numeroApostador, valorApostado);
            }
            return resultadoAposta;
        }
        public RetornoStatus AtualizarStatus(Aposta aposta,int novoStatus)
        {
            return _apostaRepository.AtualizarStatus(aposta, novoStatus);
        }
        /*public RetornoStatus ValidarAposta(Aposta aposta)
        {
            RetornoStatus statusValidacao = new RetornoStatus(false,"Não validado");
            List<ResultadoCorrida> resultadoCorrida = _corridaRepository.BuscarResultadosDaCorrida(aposta.CorridaApostada);
            double premioTotal = _corridaRepository.BuscarValorTotalApostadoNaCorrida(aposta.CorridaApostada);
            foreach (ResultadoCorrida resultado in resultadoCorrida)
            {
                RetornoDados<double> premio= new RetornoDados<double>(false, "Nenhum premio atribuido", 0);
                if (resultado.Id_Cavalo == aposta.Cavalo_Id)
                {
                    if (resultado.Posicao == 1)
                    {
                        statusValidacao= new RetornoStatus(true, "Aposta vencedora - Primeiro Lugar");
                        aposta.Status = StatusAposta.PrimeiroLugar;
                         premio = CalcularPorcentagem(50,premioTotal);
                    }
                    else if (resultado.Posicao == 2)
                    {
                        statusValidacao = new RetornoStatus(true, "Aposta vencedora - Segundo Lugar");
                        aposta.Status = StatusAposta.SegundoLugar;
                        premio = CalcularPorcentagem(35, premioTotal);
                    }
                    else if (resultado.Posicao == 3)
                    {
                        statusValidacao = new RetornoStatus(true, "Aposta vencedora - Terceiro Lugar");
                        aposta.Status = StatusAposta.TerceiroLugar;
                        premio = CalcularPorcentagem(15, premioTotal);
                    }
                    else
                    {
                        statusValidacao = new RetornoStatus(true, "Aposta perdedora");
                        aposta.Status = StatusAposta.Perdedor;
                    }
                    _apostaRepository.AtualizarStatus(aposta,(int)aposta.Status);
                    _apostadorRepository.AdicionarSaldo(aposta.Apostador_Id, premio.Dados);
                    break;
                }
            }
            return statusValidacao;
        }*/
        public List<Aposta> BuscarApostasPorCorrida(Corrida corrida)
        {
            return _apostaRepository.BuscarApostasPorCorrida(corrida);
        }
    }
}
