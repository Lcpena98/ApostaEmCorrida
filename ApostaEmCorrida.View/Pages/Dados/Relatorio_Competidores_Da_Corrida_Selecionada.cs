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
    public partial class Relatorio_Competidores_Da_Corrida_Selecionada : Form
    {
        Relatorio_Corridas_Finalizadas _relatorio_Corridas_Finalizadas;
        Corrida _corridaSelecionada;
        List<ResultadoCorrida> _resultadosCorrida = new List<ResultadoCorrida>();
        CorridaController _corridaController;
        public Relatorio_Competidores_Da_Corrida_Selecionada(Relatorio_Corridas_Finalizadas relatorio_Corridas_Finalizadas,Corrida corridaSelecionada)
        {
            InitializeComponent();
            _corridaController = new CorridaController(new CorridaService(new CavaloRepository(),new CorridaRepository(),new VoltasRepository(),new ApostaRepository(), new ApostadorRepository()));
            _relatorio_Corridas_Finalizadas = relatorio_Corridas_Finalizadas;
            _corridaSelecionada = corridaSelecionada;
            _resultadosCorrida = _corridaController.BuscarResultadosDaCorrida(_corridaSelecionada);

            dataGridView_Competidores.DataSource = null;
            dataGridView_Competidores.AutoGenerateColumns = false;
            dataGridView_Competidores.Columns.Clear();
            dataGridView_Competidores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Corredor",
                HeaderText = "Corredor"
            });
            dataGridView_Competidores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Posicao",
                HeaderText = "Posição"
            });
            dataGridView_Competidores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Competidores.MultiSelect = false;
            dataGridView_Competidores.ReadOnly = true;
            dataGridView_Competidores.DataSource= _resultadosCorrida;
            dataGridView_Competidores.ClearSelection();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _relatorio_Corridas_Finalizadas.Show();
            this.Close();
        }
    }
}
