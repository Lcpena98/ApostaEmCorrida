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
    public partial class Menu_Gerenciar_Corrida_Agendada_Selecionada : Form
    {
        Menu_Corridas_Agendadas _menu_Corridas_Agendadas;
        Corrida _corrida_selecionada;
        CavaloController _cavaloController;
        CorridaController _corridaController;
        List<Cavalo> competidores = new List<Cavalo>();
        bool bloqueio = false;
        double distancia = 0;
        int tipo_gerenciamento = 0;
        string resultado_gerenciamento = "";

        public Menu_Gerenciar_Corrida_Agendada_Selecionada(Menu_Corridas_Agendadas menu_Corridas_Agendadas, Corrida corrida_selecionada)
        {
            InitializeComponent();
            _cavaloController = new CavaloController(new CavaloService(new CavaloRepository()));
            _corridaController = new CorridaController(new CorridaService(new CorridaRepository()));
            _menu_Corridas_Agendadas = menu_Corridas_Agendadas;
            _corrida_selecionada = corrida_selecionada;
            distancia = corrida_selecionada.Percurso;

            textBox_Percurso.Text = _corrida_selecionada.Percurso.ToString();
            data_Inicio_Corrida.Text = _corrida_selecionada.DataInicio.ToString();
            numericUpDown_Numero_Voltas.Value = _corrida_selecionada.Numero_de_Voltas;

            // Definir o que será exibido no date picker
            data_Inicio_Corrida.Value = _corrida_selecionada.DataInicio;
            data_Inicio_Corrida.CustomFormat = "dd/MM/yyyy HH:mm";

            dataGridView_Cavalos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Cavalos.ReadOnly = true;

            competidores = _corridaController.BuscarCompetidores(_corrida_selecionada);
            dataGridView_Cavalos.DataSource = null;
            dataGridView_Cavalos.DataSource = competidores.ToList();
            dataGridView_Cavalos.ClearSelection();
        }

        private void button_Cadastrar_Cavalo_Click(object sender, EventArgs e)
        {
            button_Gerenciar_Cavalo.Text = "Cadastrar Cavalo";
            dataGridView_Cavalos.DataSource = null;
            dataGridView_Cavalos.DataSource = _cavaloController.BuscarCavalosNaoCadastradosEmCorrida(_corrida_selecionada);
            dataGridView_Cavalos.ClearSelection();
            MessageBox.Show("Selecione os cavalos que deseja cadastrar na corrida e clique em 'Adicionar Cavalo'.");
            tipo_gerenciamento = 1;
        }
        private void button_Remover_Cavalo_Click(object sender, EventArgs e)
        {
            competidores = _corridaController.BuscarCompetidores(_corrida_selecionada);
            dataGridView_Cavalos.DataSource=null;
            dataGridView_Cavalos.DataSource = competidores.ToList();
            dataGridView_Cavalos.ClearSelection();

            button_Gerenciar_Cavalo.Text = "Remover Cavalo";
            competidores = _corridaController.BuscarCompetidores(_corrida_selecionada);
            MessageBox.Show("Selecione os cavalos que deseja cadastrar na corrida e clique em 'Adicionar Cavalo'.");
            tipo_gerenciamento = 2;
        }

        private void button_Gerenciar_Cavalo_Click(object sender, EventArgs e)
        {
            if (tipo_gerenciamento == 0)
            {
                MessageBox.Show("Selecione uma opção de gerenciamento de cavalos.");
            }
            else if (tipo_gerenciamento == 1)
            {
                var resultado = MessageBox.Show("Tem certeza que deseja adicionar os cavalos a corrida?", "Confirmação", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    List<Cavalo> cavalos_selecionados = new List<Cavalo>();
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView_Cavalos.SelectedRows)
                        {
                            var cavaloSelecionado = row.DataBoundItem as Cavalo;
                            cavalos_selecionados.Add(cavaloSelecionado);
                        }
                        _corridaController.CadastrarParticipantes(_corrida_selecionada, cavalos_selecionados);
                        MessageBox.Show("Cavalos cadastrados com sucesso na corrida.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao selecionar cavalos. Tente novamente.");
                    }
                }
            }
            else
            {
                var resultado = MessageBox.Show("Tem certeza que deseja remover os cavalos da corrida?", "Confirmação", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    List<Cavalo> cavalos_selecionados = new List<Cavalo>();
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView_Cavalos.SelectedRows)
                        {
                            var cavaloSelecionado = row.DataBoundItem as Cavalo;
                            cavalos_selecionados.Add(cavaloSelecionado);
                        }
                        RetornoStatus status_Remocao = _corridaController.RemoverParticipantes(_corrida_selecionada, cavalos_selecionados);
                        MessageBox.Show(status_Remocao.Message.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao selecionar cavalos. Tente novamente.");
                    }
                }
            }

            competidores = _corridaController.BuscarCompetidores(_corrida_selecionada);
            dataGridView_Cavalos.DataSource = competidores.ToList();

            tipo_gerenciamento = 0;
            button_Gerenciar_Cavalo.Text = "Gerenciar Cavalos";
        }

        private void textBox_Percurso_TextKeyPress(object sender, KeyPressEventArgs e)
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
        private void textBox_Percurso_TextChanged(object sender, EventArgs e)
        {
            if (bloqueio) return;

            bloqueio = true;

            string texto = textBox_Percurso.Text.Replace("m", "").Trim();

            if (double.TryParse(texto, out _))
            {
                textBox_Percurso.Text = texto + " m";
                textBox_Percurso.SelectionStart = textBox_Percurso.Text.Length - 2; // mantém o cursor antes do 'm'
            }

            bloqueio = false;
            if (textBox_Percurso.Text.Length > 0)
            {
                distancia = double.Parse(textBox_Percurso.Text.Replace("m", "").Trim());
            }
        }

        private void button_Gerenciar_Corrida_Click(object sender, EventArgs e)
        {
            if (data_Inicio_Corrida.Value < DateTime.Now.AddHours(-1))
            {
                MessageBox.Show("A data de início da corrida não pode ser anterior a até uma hora antes da data e hora atual.");
            }
            else
            {
                

                RetornoStatus statusAlteracao = _corridaController.AtualizarDadosDaCorrida(_corrida_selecionada, (int)numericUpDown_Numero_Voltas.Value, distancia, data_Inicio_Corrida.Value);
                _corrida_selecionada.Percurso= distancia;
                _corrida_selecionada.DataInicio= data_Inicio_Corrida.Value;
                _corrida_selecionada.Numero_de_Voltas= (int)numericUpDown_Numero_Voltas.Value;
                MessageBox.Show(statusAlteracao.Message);
            }
        }


        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Corridas_Agendadas.Show();
            this.Close();
        }
    }
}