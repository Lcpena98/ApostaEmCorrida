using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.View.Pages.Dados;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas;
using ApostaEmCorrida.View.Pages.Gestao_Cavalo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Inicial : Form
    {
        List<Corrida> corridas_Agendadas = new List<Corrida>();
        CorridaController _corridaController;
        public Menu_Inicial()
        {
            InitializeComponent();
            _corridaController = new CorridaController(new CorridaService(new CavaloRepository(), new CorridaRepository(), new VoltasRepository(), new ApostaRepository(), new ApostadorRepository()));
            corridas_Agendadas = _corridaController.BuscarCorridasPorStatus(0);
            foreach (Corrida corrida in corridas_Agendadas)
            {
                if (corrida.DataInicio <= DateTime.Now)
                {
                    _corridaController.AlterarStatus(corrida, 1);
                    _corridaController.AtualizarStatusCompetidores(corrida, 0, 1);
                }
            }
            MessageBox.Show("Bem-vindo ao sistema de gerenciamento de corridas de cavalos!");
            MessageBox.Show("Ainda é necessário configurar o saldo dos apostadores!");
            MessageBox.Show("Próximo Passo!\n\rConfigurar o saldo dos apostadores!");
        }
        private void button_Cadastro_Cavalo_Click(object sender, EventArgs e)
        {
            Gerenciamento_Cavalo menu_Gerenciamento_Cavalo = new Gerenciamento_Cavalo(this);
            menu_Gerenciamento_Cavalo.Show();
            this.Hide();
        }
        private void button_Cadastro_Apostador_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda é necessário Configurar o saldo e O botão Esqueçi minha senha!");
            Login_Apostador menu_Gerenciamento_Apostador = new Login_Apostador(this);
            menu_Gerenciamento_Apostador.Show();
            this.Hide();
        }
        private void button_Dados_Cavalos_Click(object sender, EventArgs e)
        {
            Relatorio_Dados_Cavalos relatorio_Dados_Cavalos = new Relatorio_Dados_Cavalos(this);
            relatorio_Dados_Cavalos.Show();
            this.Hide();
        }
        private void button_Dados_Apostas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!");
        }
        private void button_Corrida_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Gerenciar_Corridas menu_Gerenciar_Corridas = new Menu_Gerenciar_Corridas(this);
                menu_Gerenciar_Corridas.Show();
                this.Hide();
            }
            catch (ApplicationException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}