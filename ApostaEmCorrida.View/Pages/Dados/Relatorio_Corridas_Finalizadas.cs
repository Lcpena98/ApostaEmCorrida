using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
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
            _corridaController = new CorridaController(new CorridaService(new CavaloRepository(), new CorridaRepository(), new VoltasRepository()));

            dataGridView_Corridas_Finalizadas.DataSource = _corridaController.BuscarCorridasPorStatus(2);
            dataGridView_Corridas_Finalizadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Corridas_Finalizadas.MultiSelect = false;
            dataGridView_Corridas_Finalizadas.ReadOnly = true;
        }
        private void button_Mais_Info_Click(object sender, EventArgs e)
        {
            Relatorio_Competidores_Da_Corrida_Selecionada relatorio_Competidores_Da_Corrida_Selecionada=new Relatorio_Competidores_Da_Corrida_Selecionada(this, dataGridView_Corridas_Finalizadas.SelectedRows[0]);
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
