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
        protected readonly IApostaRepository _apostaRepository;
        protected readonly IApostadorRepository _apostadorRepository;

        public CorridaService(ICavaloRepository cavaloRepository, ICorridaRepository corridaRepository,
            IVoltasRepository voltasRepository, IApostaRepository apostaRepository,IApostadorRepository apostadorRepository)
        {
            _apostadorRepository = apostadorRepository;
            _apostaRepository = apostaRepository;
            _cavaloRepository = cavaloRepository;
            _corridaRepository = corridaRepository;
            _voltasRepository = voltasRepository;
        }
        public RetornoStatus AgendarCorrida(Corrida corrida)
        {
            return _corridaRepository.AgendarCorrida(corrida);
        }
        public Corrida BuscarCorridaPorId(int id)
        {
            return _corridaRepository.BuscarCorridaPorId(id);
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
                    _corridaRepository.AlterarStatus(corrida, (int)CorridaStatus.Finalizada);
                    ValidarApostasDaCorrida(corrida);
                    return new RetornoStatus(true, "Dados Da corrida atualizados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                return new RetornoStatus(false, "Falha ao atualizar os dados!");
            }
        }
        public List<ResultadoCorrida> BuscarResultadosDaCorrida(Corrida corrida)
        {
            List<ResultadoCorrida> resultadosCorrida = _voltasRepository.BuscarResultadoCorrida(corrida);
            foreach (ResultadoCorrida resultado in resultadosCorrida)
            {
                resultado.Corredor = _cavaloRepository.BuscarCavaloPorNumero(resultado.Id_Cavalo).Dados;
            }
            return resultadosCorrida;
        }

        public void ValidarApostasDaCorrida(Corrida corrida)
        {
            List<Aposta> apostasNaCorrida = _apostaRepository.BuscarApostasPorCorrida(corrida),
                vencedores1 = new List<Aposta>(),
                vencedores2 = new List<Aposta>(),
                vencedores3 = new List<Aposta>(),
                perdedores = new List<Aposta>();
            List<ResultadoCorrida> resultadosCorrida = _voltasRepository.BuscarResultadoCorrida(corrida);
            double valorApostado=_corridaRepository.BuscarValorTotalApostadoNaCorrida(corrida),
                premio1= valorApostado * 0.5,
                premio2= valorApostado * 0.3,
                premio3= valorApostado * 0.2,
                premio1Individual=0,
                premio2Individual=0,
                premio3Individual=0,
                premioEstornadoIndividual=0;
            bool 
                semVencedores1 = true, 
                semVencedores2=true, 
                semVencedores3 = true;

            foreach (Aposta aposta in apostasNaCorrida)
            {
                foreach (ResultadoCorrida resultado in resultadosCorrida)
                {
                    if (aposta.Cavalo_Id == resultado.Id_Cavalo)
                    {
                        switch (resultado.Posicao)
                        {
                            default:
                                perdedores.Add(aposta);
                                break;
                            case 1:
                                vencedores1.Add(aposta);
                                break;
                            case 2:
                                vencedores2.Add(aposta);
                                break;
                            case 3:
                                vencedores3.Add(aposta);
                                break;
                            
                        }
                        break;
                    }
                }

            }
            if (vencedores1.Count > 0)
            {
                semVencedores1 = false;
                premio1Individual = Math.Round(premio1 / vencedores1.Count,2);
                foreach (Aposta aposta in vencedores1)
                {
                    _apostaRepository.AtualizarStatus(aposta, (int)StatusAposta.PrimeiroLugar);
                    _apostadorRepository.AdicionarSaldo(aposta.Apostador_Id, premio1Individual);
                    _apostaRepository.AtualizarPremiacao(aposta, premio1Individual);
                }
            }
            else
            {
                premio2 += premio1;
            }
            if (vencedores2.Count > 0)
            {
                semVencedores2 = false;
                premio2Individual= Math.Round(premio2 / vencedores2.Count,2);
                foreach (Aposta aposta in vencedores2)
                {
                    _apostaRepository.AtualizarStatus(aposta, (int)StatusAposta.SegundoLugar);
                    _apostadorRepository.AdicionarSaldo(aposta.Apostador_Id, premio2Individual);
                    _apostaRepository.AtualizarPremiacao(aposta, premio2Individual);
                }
            }
            else
            {
                premio3 += premio2;
            }
            if (vencedores3.Count > 0)
            {
                semVencedores3 = false;
                premio3Individual = Math.Round(premio3 / vencedores3.Count,2);
                foreach (Aposta aposta in vencedores3)
                {
                    _apostaRepository.AtualizarStatus(aposta, (int)StatusAposta.TerceiroLugar);
                    _apostadorRepository.AdicionarSaldo(aposta.Apostador_Id, premio3Individual);
                    _apostaRepository.AtualizarPremiacao(aposta, premio3Individual);
                }
            }
            //Caso ninguém vença, o prêmio é estornado para os apostadores que perderam
            else if (semVencedores1==false&&semVencedores2==false&&semVencedores3==false)
            {
                premioEstornadoIndividual = Math.Round(premio3 / vencedores3.Count, 2);
                foreach (Aposta aposta in perdedores)
                {
                    _apostaRepository.AtualizarStatus(aposta, (int)StatusAposta.Estornado);
                    _apostadorRepository.AdicionarSaldo(aposta.Apostador_Id, premioEstornadoIndividual);
                    _apostaRepository.AtualizarPremiacao(aposta, premioEstornadoIndividual);
                }
            }
            //caso apenas o primeiro e terceiro lugar não tenha ganhadores, todos os apostadores do segundo lugar recebem os premios
            else if (semVencedores1==false)
            {
                premio3Individual = Math.Round(premio3 / vencedores2.Count, 2);
                foreach (Aposta aposta in vencedores2)
                {
                    _apostadorRepository.AdicionarSaldo(aposta.Apostador_Id, premio3Individual);
                    _apostaRepository.AtualizarPremiacao(aposta, premio2Individual+premio3Individual);
                }
            }
            //caso apenas o terceiro lugar não tenha ganhadores, todos os apostadores do primeiro lugar recebem os premios
            else
            {
                premio3Individual = Math.Round(premio3 / vencedores1.Count, 2);
                foreach (Aposta aposta in vencedores1)
                {
                    _apostadorRepository.AdicionarSaldo(aposta.Apostador_Id, premio3);
                    _apostaRepository.AtualizarPremiacao(aposta, premio1Individual + premio3Individual);
                }
            }
            foreach (Aposta aposta in perdedores)
            {
                _apostaRepository.AtualizarStatus(aposta, (int)StatusAposta.Perdedor);
            }
        }
    }
}