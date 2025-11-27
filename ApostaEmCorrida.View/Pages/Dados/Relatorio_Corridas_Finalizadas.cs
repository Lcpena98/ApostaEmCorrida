using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages.Dados
{
    public partial class Relatorio_Corridas_Finalizadas : Form
    {
        Menu_Gerenciar_Corridas _menu_Gerenciar_Corridas;
        CorridaController _corridaController;
        public Relatorio_Corridas_Finalizadas(Menu_Gerenciar_Corridas menu_Gerenciar_Corridas)
        {
            InitializeComponent();
            _menu_Gerenciar_Corridas = menu_Gerenciar_Corridas;
            _corridaController = new CorridaController(new CorridaService(new CavaloRepository(), new CorridaRepository(), new VoltasRepository(), new ApostaRepository(), new ApostadorRepository()));
            PreencherLista();
            
        }
        public void Recarregar_Lista(object sender, EventArgs e)
        {
            PreencherLista();
        }
        private void PreencherLista()
        {
            dataGridView_Corridas_Finalizadas.DataSource = null;
            dataGridView_Corridas_Finalizadas.AutoGenerateColumns = false;
            dataGridView_Corridas_Finalizadas.Columns.Clear();
            dataGridView_Corridas_Finalizadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataInicio",
                HeaderText = "Data de Inicio"
            });
            dataGridView_Corridas_Finalizadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Numero_de_Voltas",
                HeaderText = "Número de Voltas"
            });
            dataGridView_Corridas_Finalizadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Percurso",
                HeaderText = "Percurso (m)"
            });
            dataGridView_Corridas_Finalizadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Duracao",
                HeaderText = "Duração"
            });
            dataGridView_Corridas_Finalizadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataFim",
                HeaderText = "Data de Fim"
            });
            dataGridView_Corridas_Finalizadas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CorridaStatus",
                HeaderText = "Status"
            });

            dataGridView_Corridas_Finalizadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Corridas_Finalizadas.MultiSelect = false;
            dataGridView_Corridas_Finalizadas.ReadOnly = true;
            dataGridView_Corridas_Finalizadas.DataSource = _corridaController.BuscarCorridasPorStatus(2);
            dataGridView_Corridas_Finalizadas.ClearSelection();
        }
        private void button_Mais_Info_Click(object sender, EventArgs e)
        {
            Corrida corridaSelecionada = (Corrida)dataGridView_Corridas_Finalizadas.CurrentRow.DataBoundItem;
            Relatorio_Competidores_Da_Corrida_Selecionada relatorio_Competidores_Da_Corrida_Selecionada = new Relatorio_Competidores_Da_Corrida_Selecionada(this, corridaSelecionada);
            relatorio_Competidores_Da_Corrida_Selecionada.Show();
            this.Hide();
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menu_Gerenciar_Corridas.Show();
            this.Close();
        }
    }
}
