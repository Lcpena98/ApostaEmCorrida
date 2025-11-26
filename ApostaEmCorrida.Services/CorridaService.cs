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
        protected readonly ICavaloRepository _cavaloRepository;
        protected readonly ICorridaRepository _corridaRepository;
        protected readonly IVoltasRepository _voltasRepository;

        public CorridaService(ICavaloRepository cavaloRepository,ICorridaRepository corridaRepository, IVoltasRepository voltasRepository)
        {
            _cavaloRepository = cavaloRepository;
            _corridaRepository = corridaRepository;
            _voltasRepository = voltasRepository;
        }
        public RetornoStatus AgendarCorrida(Corrida corrida)
        {
            return _corridaRepository.AgendarCorrida(corrida);
        }
        public List<Corrida> BuscarCorridasPorStatus(int status)
        {
            return _corridaRepository.BuscarCorridasPorStatus(status);
        }
        public List<Cavalo> BuscarCompetidores(Corrida corrida)
        {
            return _corridaRepository.BuscarCompetidores(corrida);
        }
        public RetornoStatus CadastrarParticipantes(Corrida corrida, List<Cavalo> competidores)
        {
            return _corridaRepository.CadastrarParticipantes(corrida, competidores);
        }
        public RetornoStatus AtualizarDadosDaCorrida(Corrida corrida, int Numero_Voltas, double percurso, DateTime dataInicio)
        {
            return _corridaRepository.AtualizarDadosDaCorrida(corrida, Numero_Voltas, percurso, dataInicio);
        }

        public RetornoStatus AlterarStatus(Corrida corrida, int status)
        {
            return _corridaRepository.AlterarStatus(corrida, status);
        }

        public void AtualizarStatusCompetidores(Corrida corrida, int statusAtual, int novoStatus)
        {
            foreach (Cavalo cavalo in _corridaRepository.BuscarCompetidores(corrida))
            {
                if ((int)cavalo.StatusCavalo == statusAtual)
                    _corridaRepository.AtualizarStatusCompetidores(cavalo, novoStatus);
            }
        }

        public RetornoStatus IniciarCorrida(Corrida corridaSelecionada)
        {
            List<Voltas> voltasExistentes = new List<Voltas>();
            try
            {
                List<Cavalo> competidores = _corridaRepository.BuscarCompetidores(corridaSelecionada);
                TimeSpan tempoCorrida = new TimeSpan();
                for (int i = 1; i <= corridaSelecionada.Numero_de_Voltas; i++)
                {
                    Voltas volta = new Voltas();
                    TimeSpan maiorTempoVolta = new TimeSpan();
                    foreach (Cavalo cavalo in competidores)
                    {
                        Random tempo = new Random();
                        int tempoVolta = tempo.Next(50, 121); // Tempo aleatório entre 50 e 120 segundos
                        TimeSpan duracaoVolta = TimeSpan.FromSeconds(tempoVolta);
                        if (duracaoVolta > maiorTempoVolta)
                        {
                            maiorTempoVolta = duracaoVolta;
                        }
                        volta = _voltasRepository.RegistrarVolta(corridaSelecionada, cavalo, i, duracaoVolta);
                        voltasExistentes.Add(volta);
                    }
                    _voltasRepository.RegistrarTempoVolta(volta, maiorTempoVolta);
                    tempoCorrida += maiorTempoVolta;
                }
                _corridaRepository.AtualizarTempoTotalCorrida(corridaSelecionada, tempoCorrida);
                _corridaRepository.AlterarStatus(corridaSelecionada, 2);
                List<Cavalo> naoRegistrados = _corridaRepository.BuscarCavalosNaoCadastradosEmCorrida(1);
                foreach (Cavalo cavalo in naoRegistrados)
                {
                    _corridaRepository.AtualizarStatusCompetidores(cavalo, 0);
                }
                corridaSelecionada.CorridaStatus = CorridaStatus.Finalizada;
                return new RetornoStatus(true, "Corrida Finalizada.");
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Falha ao finalizar Corrida!");
            }
        }

        public RetornoStatus CadastrarFimCorrida(Corrida corrida)
        {
            try
            {
                if (corrida.CorridaStatus != CorridaStatus.Finalizada)
                {
                    return new RetornoStatus(false, "A corrida ainda não foi finalizada.");
                }
                else
                {
                    foreach (Cavalo cavalo in _corridaRepository.BuscarCompetidores(corrida))
                    {
                        TimeSpan tempoTotalCavalo = new TimeSpan();
                        List<Voltas> voltasCavalo = _voltasRepository.BuscarVoltasPorCorridaECompetidor(corrida, cavalo);
                        foreach (Voltas volta in voltasCavalo)
                        {
                            tempoTotalCavalo += volta.TempoVolta;
                        }
                        _voltasRepository.CadastrarFimCorrida(new ResultadoCorrida(corrida, cavalo, tempoTotalCavalo));
                    }
                    _voltasRepository.OrdenarCompetidores(corrida);
                    List<ResultadoCorrida> resultadoCorrida = _voltasRepository.BuscarResultadoCorrida(corrida);
                    _cavaloRepository.AtualizarDesempenho(resultadoCorrida);
                    _corridaRepository.AlterarStatus(corrida, 2);
                    return new RetornoStatus(true, "Dados Da corrida atualizados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Falha ao atualizar os dados!");
            }
        }
    }
}