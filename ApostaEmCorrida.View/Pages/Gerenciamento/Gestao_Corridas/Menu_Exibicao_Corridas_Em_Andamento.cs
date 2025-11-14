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
        List<Corrida> corridas_Em_Andamento = new List<Corrida>();
        List<Corrida> corridas_Agendadas = new List<Corrida>();
        public Menu_Exibicao_Corridas_Em_Andamento(Menu_Gerenciar_Corridas menu_Gerenciar_Corridas)
        {
            InitializeComponent();
            _menu_Gerenciar_Corridas = menu_Gerenciar_Corridas;
            _corridaController = new CorridaController(new CorridaService(new CorridaRepository(),new VoltasRepository()));
            corridas_Agendadas = _corridaController.BuscarCorridasPorStatus(0);
            corridas_Em_Andamento = _corridaController.BuscarCorridasPorStatus(1);

            PreencerDataGridViewCorridas(dataGridView_Corridas_Agendadas, 0);
            PreencerDataGridViewCorridas(dataGridView_Corridas_Em_Andamento, 1);

            /*
             IDEIA DE IMPLEMENTAÇÃO FUTURA

            . Criar botões para "Finalizar Corrida" e "Ver Detalhes da Corrida"
            . Usar o método Random em cada cavalo para determinar o desempenho em cada volta e preencher a tabela de Voltas
            . Calcular o tempo total de cada cavalo e determinar a ordem de chegada
            . Validar os vencedores e posições e preencher os dados na tabela de Resultados
            . Atualizar o status da corrida para "Finalizada"
            . Notificar os usuários sobre os resultados das corridas finalizadas

            OBS: O Banco já está implementado para suportar essas funcionalidades.
             */
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
            corrida.Competidores= new List<Cavalo>();
        }
        

        private void button_Editar_Corrida_Click(object sender, EventArgs e)
        {
            var corridaSelecionada = dataGridView_Corridas_Agendadas.SelectedRows[0].DataBoundItem as Corrida;
            Corrida corrida = corridaSelecionada;
            if (dataGridView_Corridas_Agendadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma corrida antes de continuar.");
                return;
            }
            else
            {
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
                Corrida corridaSelecionada = dataGridView_Corridas_Em_Andamento.SelectedRows[0].DataBoundItem as Corrida;
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
/*  
        public Menu_Registro_Aposta(Menu_Apostador menu_Apostador, Apostador apostador)
        {
            
            
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
            corridaSelecionada = dataGridView_Corridas.SelectedRows[0].DataBoundItem as Corrida;
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
                RetornoStatus retorno = _apostaController.RegistrarAposta(corridaSelecionada, cavaloSelecionado.Numero_Cavalo, _apostador.Numero, valorApostado);
                comboBox_Cavalo.Items.Clear();
                comboBox_Cavalo.Text = string.Empty;
                comboBox_Cavalo.SelectedItem = -1;
                textBox_Valor_Apostado.Text = "";
                MessageBox.Show(retorno.Message);
            }
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menu_Apostador.Show();
            this.Close();
        }
    }
}
*/