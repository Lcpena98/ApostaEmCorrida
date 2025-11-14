using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
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
        protected readonly IApostaRepository _apostaRepository;
        protected readonly ICorridaRepository _corridaRepository;

        public ApostaService(IApostaRepository apostaRepository, ICorridaRepository corridaRepository)
        {
            _apostaRepository = apostaRepository;
            _corridaRepository = corridaRepository;
        }

        public void AdicionarValoresCorrida(Corrida corrida, double valor)
        {

        }

        public RetornoStatus RegistrarAposta(Corrida corrida, int numeroCavalo, int numeroApostador, double valorApostado)
        {

            RetornoStatus resultadoAposta = _apostaRepository.RegistrarAposta(corrida, numeroCavalo, numeroApostador, valorApostado);
            if (resultadoAposta.Sucesso)
            {
                RetornoStatus resultadoSoma = _corridaRepository.AdicionarValoresCorrida(corrida, valorApostado);
            }
            return resultadoAposta;

        }
    }
}
