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
        public RetornoStatus RegistrarAposta(Corrida corrida, int numeroCavalo, Apostador apostador, double valorApostado)
        {
            RetornoStatus resultadoAposta = _apostaRepository.RegistrarAposta(corrida, numeroCavalo, apostador.Numero, valorApostado);
            if (resultadoAposta.Sucesso)
            {
                RetornoStatus resultadoSoma = _corridaRepository.AdicionarValoresCorrida(corrida, valorApostado);
                _apostadorRepository.RemoverSaldo(apostador, valorApostado);
            }
            return resultadoAposta;
        }
        public RetornoStatus AtualizarStatus(Aposta aposta,int novoStatus)
        {
            return _apostaRepository.AtualizarStatus(aposta, novoStatus);
        }
        public List<Aposta> BuscarApostasPorCorrida(Corrida corrida)
        {
            return _apostaRepository.BuscarApostasPorCorrida(corrida);
        }
    }
}
