using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador;
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
    public partial class Menu_Cadastro_Corrida : Form
    {
        Menu_Gerenciar_Corridas _menu_Gerenciar_Corridas;
        CavaloController _cavaloController;
        CorridaController _corridaController;
        List<Cavalo> competidores = new List<Cavalo>();
        private bool bloqueio = false;
        double distancia = 0;
        public Menu_Cadastro_Corrida(Menu_Gerenciar_Corridas menu_Gerenciar_Corridas)
        {
            InitializeComponent();
            _menu_Gerenciar_Corridas = menu_Gerenciar_Corridas;
            _cavaloController = new CavaloController(new CavaloService(new CavaloRepository()));
            _corridaController = new CorridaController(new CorridaService(new CavaloRepository(), new CorridaRepository(), new VoltasRepository(), new ApostaRepository(), new ApostadorRepository()));
            // Carregar cavalos no combobox
            RetornoDados<List<Cavalo>> retornoCavalos = _cavaloController.BuscarTodosCavalos();
            foreach (Cavalo cavalo in retornoCavalos.Dados)
            {
                comboBox_Cavalo.Items.Add(cavalo);
            }
            // Definir o que será exibido no date picker
            data_Inicio_Corrida.Value = DateTime.Now;
            data_Inicio_Corrida.CustomFormat = "dd/MM/yyyy HH:mm";
            // Definir colunas do DataGridView
            dataGridView_Cavalos.DataSource = competidores.ToList();
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
        private void button_Cadastrar_Cavalo_Click(object sender, EventArgs e)
        {
            try
            {
                Cavalo cavaloRegistrado = (Cavalo)comboBox_Cavalo.SelectedItem;
                competidores.Add(cavaloRegistrado);
                comboBox_Cavalo.Items.Remove(comboBox_Cavalo.SelectedItem);
                comboBox_Cavalo.SelectedItem = -1;
                comboBox_Cavalo.Text = string.Empty;
                dataGridView_Cavalos.DataSource = null;
                dataGridView_Cavalos.DataSource = competidores.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cavalo para cadastrar na corrida.");
            }
        }
        private void button_Cadastrar_Corrida_Click(object sender, EventArgs e)
        {
            if (data_Inicio_Corrida.Value < DateTime.Now)
            {
                MessageBox.Show("A data de início da corrida não pode ser anterior a data atual.");
            }
            else
            {
                Corrida corrida = new Corrida(competidores, (int)numericUpDown_Numero_Voltas.Value, distancia, data_Inicio_Corrida.Value);
                RetornoStatus statusCadastro = _corridaController.AgendarCorrida(corrida);
                MessageBox.Show(statusCadastro.Message.ToString());

                comboBox_Cavalo.Items.Clear();
                comboBox_Cavalo.SelectedItem = -1;
                comboBox_Cavalo.Text = string.Empty;
                dataGridView_Cavalos.DataSource = null;
                numericUpDown_Numero_Voltas.Value = 0;
                data_Inicio_Corrida.Value = DateTime.Now;
                textBox_Percurso.Text = "";
                data_Inicio_Corrida.Text = string.Empty;
            }
        }
        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Gerenciar_Corridas.Show();
            this.Close();
        }


    }
}

