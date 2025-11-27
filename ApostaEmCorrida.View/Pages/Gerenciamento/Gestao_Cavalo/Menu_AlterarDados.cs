using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Enumerator;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.View.Pages.Gestao_Cavalo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Cavalo
{
    public partial class Menu_AlterarDados : Form
    {
        Gerenciamento_Cavalo _gerenciamento_Cavalo;
        CavaloController _cavaloController;
        public Menu_AlterarDados(Gerenciamento_Cavalo gerenciamento_Cavalo)
        {
            InitializeComponent();
            _gerenciamento_Cavalo = gerenciamento_Cavalo;
            _cavaloController = new CavaloController(new CavaloService(new CavaloRepository())); 

            RetornoDados<List<Cavalo>> retornoDados = _cavaloController.BuscarTodosCavalos();
            if (retornoDados.Sucesso)
            {
                foreach (Cavalo cavalo in retornoDados.Dados)
                    comboBox_Cavalos.Items.Add(cavalo);
            }
            else
            {
                MessageBox.Show(retornoDados.Message);
            }
        }

        private void comboBox_Cavalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cavalo cavalo = (Cavalo)comboBox_Cavalos.SelectedItem;
            textBox_NomeCavalo.Text = cavalo.Nome;
            textBox_Raca.Text = cavalo.Raca;
            textBox_PesoCavalo.Text = cavalo.Peso.ToString();
            textBox_AlturaCavalo.Text = cavalo.Altura.ToString();

            resultado_Alteracao.Text = string.Empty;
            resultado_Alteracao.Visible = false;
        }

        private void button_Alterar_Click(object sender, EventArgs e)
        {
            if (comboBox_Cavalos.SelectedIndex == -1)
            {
                resultado_Alteracao.Text = "Selecione um cavalo para alterar os dados.";
                resultado_Alteracao.Visible = true;
            }
            else
            {
                Cavalo cavalo = (Cavalo)comboBox_Cavalos.SelectedItem;
                string nomeCavalo;
                string racaCavalo;
                double alturaCavalo;
                double pesoCavalo;
                if (cavalo.StatusCavalo == StatusCavalo.EmEspera)
                {
                    var result = MessageBox.Show("Tem Certeza que deseja excluir o cavalo selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                    else
                    {
                        if (string.IsNullOrEmpty(textBox_NomeCavalo.Text))
                            nomeCavalo = cavalo.Nome;
                        else
                            nomeCavalo = textBox_NomeCavalo.Text.ToString();

                        if (string.IsNullOrEmpty(textBox_Raca.Text))
                            racaCavalo = cavalo.Raca.ToString();
                        else
                            racaCavalo = textBox_Raca.Text;

                        if (string.IsNullOrEmpty(textBox_PesoCavalo.Text))
                            pesoCavalo = cavalo.Peso;
                        else
                            pesoCavalo = double.Parse(textBox_PesoCavalo.Text);

                        if (string.IsNullOrEmpty(textBox_AlturaCavalo.Text))
                            alturaCavalo = cavalo.Altura;
                        else
                            alturaCavalo = double.Parse(textBox_AlturaCavalo.Text);

                        RetornoStatus retornoStatus = _cavaloController.AlterarDadosCavalo(nomeCavalo, racaCavalo, alturaCavalo, pesoCavalo, cavalo.Numero_Cavalo);
                        comboBox_Cavalos.SelectedIndex = 0;
                        comboBox_Cavalos.Text = string.Empty;
                        textBox_NomeCavalo.Text = string.Empty;
                        textBox_AlturaCavalo.Text = string.Empty;
                        textBox_Raca.Text = string.Empty;
                        textBox_PesoCavalo.Text = string.Empty;
                        MessageBox.Show("Dados Alterados com sucesso!.");
                    }
                }

                else
                {
                    MessageBox.Show("Cavalo Selecionado está cadastrado em uma corrida.");
                }
            }
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _gerenciamento_Cavalo.Show();
            this.Close();
        }


    }
}
