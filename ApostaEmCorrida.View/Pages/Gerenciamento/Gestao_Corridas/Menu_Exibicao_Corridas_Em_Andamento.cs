using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas
{
    public partial class Menu_Exibicao_Corridas_Em_Andamento : Form
    {
        Menu_Gerenciar_Corridas _menu_Gerenciar_Corridas;
        CorridaController _corridaController;
        public Menu_Exibicao_Corridas_Em_Andamento(Menu_Gerenciar_Corridas menu_Gerenciar_Corridas)
        {
            InitializeComponent();
            _menu_Gerenciar_Corridas = menu_Gerenciar_Corridas;
            _corridaController = new CorridaController(new CorridaService(new CavaloRepository(), new CorridaRepository(), new VoltasRepository(), new ApostaRepository(), new ApostadorRepository()));
            PreencerDataGridViewCorridas(dataGridView_Corridas_Agendadas, 0);
            PreencerDataGridViewCorridas(dataGridView_Corridas_Em_Andamento, 1);
        }
        private void Recarregar_Lista(object sender, EventArgs e)
        {
            PreencerDataGridViewCorridas(dataGridView_Corridas_Agendadas, 0);
            PreencerDataGridViewCorridas(dataGridView_Corridas_Em_Andamento, 1);
        }
        private void PreencerDataGridViewCorridas(DataGridView dataGridView, int status)
        {
            dataGridView.DataSource = null;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Numero_de_Voltas",
                HeaderText = "Voltas"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Percurso",
                HeaderText = "Distância (m)"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataInicio",
                HeaderText = "Data Agendada"
            });
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
            dataGridView.MultiSelect = false;
            dataGridView.DataSource = _corridaController.BuscarCorridasPorStatus(status);
            dataGridView.ClearSelection();
            Corrida corrida = new Corrida();
            corrida.Competidores = new List<Cavalo>();
        }
        private void button_Editar_Corrida_Click(object sender, EventArgs e)
        {
            if (dataGridView_Corridas_Agendadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma corrida antes de continuar.");
                return;
            }
            else
            {
                var corridaSelecionada = dataGridView_Corridas_Agendadas.SelectedRows[0].DataBoundItem as Corrida;
                Corrida corrida = corridaSelecionada;
                if (DateTime.Now > corrida.DataInicio.AddHours(-1))
                {
                    MessageBox.Show("A corrida selecionada está muito próxima, não é possivel alterar dados da mesma.");
                }
                else
                {
                    dataGridView_Corridas_Agendadas.DataSource = null;
                    Menu_Gerenciar_Corrida_Agendada_Selecionada menu_Gerenciar_Corrida_Agendada = new Menu_Gerenciar_Corrida_Agendada_Selecionada(this, corrida);
                    menu_Gerenciar_Corrida_Agendada.Show();
                    this.Hide();
                }
            }
        }
        private void button_Iniciar_Corrida_Click(object sender, EventArgs e)
        {
            if (dataGridView_Corridas_Em_Andamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma corrida antes de continuar.");
                return;
            }
            else
            {
                Corrida corridaSelecionada = (Corrida)dataGridView_Corridas_Em_Andamento.SelectedRows[0].DataBoundItem;
                RetornoStatus resultado = _corridaController.IniciarCorrida(corridaSelecionada);
                MessageBox.Show(resultado.Message);
            }
        }
        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Gerenciar_Corridas.Show();
            this.Close();
        }
    }
}