using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services.Interfaces;
using ApostaEmCorrida.Dapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaEmCorrida.Services
{
    public class ApostaService:IApostaService
    {
        protected readonly IApostaRepository _apostaRepository;

        public ApostaService(IApostaRepository apostaRepository)
        {
            _apostaRepository = apostaRepository;
        }

        public RetornoStatus RegistrarAposta(int numeroCavalo, int numeroApostador, double valorApostado)
        {
            return _apostaRepository.RegistrarAposta(numeroCavalo, numeroApostador, valorApostado);
        }
    }
}
