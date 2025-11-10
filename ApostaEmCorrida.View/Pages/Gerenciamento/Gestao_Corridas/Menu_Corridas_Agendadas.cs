using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Enumerator;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.Services.Interfaces;
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
    public partial class Menu_Corridas_Agendadas : Form
    {

        Menu_Gerenciar_Corridas _menu_Gerenciar_Corridas;
        CorridaController _corridaController;
        List<Corrida> corridas_agendadas = new List<Corrida>();
        public Menu_Corridas_Agendadas(Menu_Gerenciar_Corridas menu_Gerenciar_Corridas)
        {
            InitializeComponent();
            _menu_Gerenciar_Corridas = menu_Gerenciar_Corridas;
            _corridaController = new CorridaController(new CorridaService(new CorridaRepository()));

            dataGridView_Corridas_Agendadas.AutoGenerateColumns = false;
            dataGridView_Corridas_Agendadas.Columns.Clear();

            dataGridView_Corridas_Agendadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Numero_de_Voltas",
                HeaderText = "Voltas"
            });

            dataGridView_Corridas_Agendadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Percurso",
                HeaderText = "Distância (m)"
            });

            dataGridView_Corridas_Agendadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataInicio",
                HeaderText = "Data e hora"
            });
            dataGridView_Corridas_Agendadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Corridas_Agendadas.MultiSelect = false;
            dataGridView_Corridas_Agendadas.ReadOnly = true;
            RecarregarCorridas();
        }

        private void RecarregarCorridas()
        {
            var lista = _corridaController.BuscarCorridasPorStatus(0);
            dataGridView_Corridas_Agendadas.DataSource = lista;
            dataGridView_Corridas_Agendadas.ClearSelection();
            dataGridView_Corridas_Agendadas.CurrentCell = null;
        }

        private void Recarregar_Lista(object sender, EventArgs e)
        {
            RecarregarCorridas();
        }

        private void button_Editar_Corrida_Click(object sender, EventArgs e)
        {
            if (dataGridView_Corridas_Agendadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma corrida antes de continuar.");
                return;
            }
            var corridaSelecionada = dataGridView_Corridas_Agendadas.SelectedRows[0].DataBoundItem as Corrida;
            Corrida corrida = corridaSelecionada;
            if (dataGridView_Corridas_Agendadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma corrida antes de continuar.");
            }
            else
            {
                if (DateTime.Now> corrida.DataInicio.AddHours(-1))
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

        private void button_Cancelar_Corrida_Click(object sender, EventArgs e)
        {
            if (dataGridView_Corridas_Agendadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma corrida antes de continuar.");
                return;
            }
            var corridaSelecionada = dataGridView_Corridas_Agendadas.SelectedRows[0].DataBoundItem as Corrida;
            if (dataGridView_Corridas_Agendadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma corrida antes de continuar.");
            }
            else
            {
                if (DateTime.Now > corridaSelecionada.DataInicio.AddHours(-1))
                {
                    MessageBox.Show("A corrida selecionada está muito próxima, não é possivel cancelar a mesma.");
                }
                else
                {
                    var resultado = MessageBox.Show("Tem certeza que deseja cancelar a corrida selecionada?", "Confirmação", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        RetornoStatus retorno = _corridaController.CancelarCorrida(corridaSelecionada);
                        MessageBox.Show(retorno.Message);
                        RecarregarCorridas();
                    }
                }
            }
        }
        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Gerenciar_Corridas.Show();
            this.Close();
        }
    }
}
