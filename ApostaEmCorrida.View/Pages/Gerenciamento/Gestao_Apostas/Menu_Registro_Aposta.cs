using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.Services.Interfaces;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Registro_Aposta : Form
    {
        Menu_Apostador _menu_Apostador;
        Apostador _apostador;
        ApostaController _apostaController;
        CorridaController _corridaController;
        Corrida corridaSelecionada = new Corrida();
        public Menu_Registro_Aposta(Menu_Apostador menu_Apostador, Apostador apostador)
        {
            InitializeComponent();
            _menu_Apostador = menu_Apostador;
            _apostador = apostador; _corridaController = new CorridaController(new CorridaService(new CavaloRepository(), new CorridaRepository(), new VoltasRepository(), new ApostaRepository(), new ApostadorRepository()));
            _apostaController = new ApostaController(new ApostaService(new ApostaRepository(), new ApostadorRepository(), new CorridaRepository()));
            label_Dados_Usuario.Text = $"{_apostador.Nome.ToString()} - {_apostador.Numero.ToString()}";

            dataGridView_Corridas.DataSource = null;
            dataGridView_Corridas.AutoGenerateColumns = false;
            dataGridView_Corridas.Columns.Clear();
            dataGridView_Corridas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Numero_de_Voltas",
                HeaderText = "Voltas"
            });

            dataGridView_Corridas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Percurso",
                HeaderText = "Distância (m)"
            });

            dataGridView_Corridas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataInicio",
                HeaderText = "Data e hora"
            });

            dataGridView_Corridas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Corridas.ReadOnly = true;
            dataGridView_Corridas.MultiSelect = false;
            dataGridView_Corridas.DataSource = _corridaController.BuscarCorridasPorStatus(0);
            dataGridView_Corridas.ClearSelection();
        }
        private void TextBox_Valor_Apostado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir controle (backspace)
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Permitir apenas uma vírgula ou ponto
            TextBox txt = sender as TextBox;
            if ((e.KeyChar == '.') && (txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void button_Selecionar_Corrida_Click(object sender, EventArgs e)
        {
            corridaSelecionada = (Corrida)dataGridView_Corridas.SelectedRows[0].DataBoundItem;
            List<Cavalo> cavalosNaCorrida = _corridaController.BuscarCompetidores(corridaSelecionada);
            foreach (Cavalo cavalo in cavalosNaCorrida)
            {
                comboBox_Cavalo.Items.Add(cavalo);
            }
            comboBox_Cavalo.Text = string.Empty;
            comboBox_Cavalo.SelectedItem = -1;
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            if (corridaSelecionada == null)
            {
                MessageBox.Show("Selecione uma corrida para apostar.");
            }
            else if (comboBox_Cavalo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cavalo para apostar.");
            }
            else if (string.IsNullOrEmpty(textBox_Valor_Apostado.Text))
            {
                MessageBox.Show("Insira um valor para apostar.");
            }
            else
            {
                Cavalo cavaloSelecionado = comboBox_Cavalo.SelectedItem as Cavalo;
                double valorApostado = Convert.ToDouble(textBox_Valor_Apostado.Text);
                if (_apostador.Saldo < valorApostado)
                {
                    MessageBox.Show("Saldo insuficiente para realizar a aposta.");
                }
                else
                {
                    RetornoStatus retorno = _apostaController.RegistrarAposta(corridaSelecionada, cavaloSelecionado.Numero_Cavalo, _apostador, valorApostado);
                    comboBox_Cavalo.Items.Clear();
                    comboBox_Cavalo.Text = string.Empty;
                    comboBox_Cavalo.SelectedItem = -1;
                    textBox_Valor_Apostado.Text = "";
                    MessageBox.Show(retorno.Message);
                }
            }
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menu_Apostador.Show();
            this.Close();
        }
    }
}