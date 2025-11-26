using ApostaEmCorrida.Domain;
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
        public Relatorio_Competidores_Da_Corrida_Selecionada(Relatorio_Corridas_Finalizadas relatorio_Corridas_Finalizadas,Corrida corridaSelecionada)
        {
            InitializeComponent();
            relatorio_Corridas_Finalizadas = relatorio_Corridas_Finalizadas;
            _corridaSelecionada = corridaSelecionada;
            dataGridView_Competidores.DataSource = _corridaSelecionada.Competidores;
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _relatorio_Corridas_Finalizadas.Show();
            this.Close();
        }
    }
}
