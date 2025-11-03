using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using Microsoft.Extensions.Configuration;
using ApostaEmCorrida.View.Pages.Gestao_Cavalo;

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Cadastro_Cavalo : Form
    {
        Gerenciamento_Cavalo _gerenciamento_Cavalo;
        CavaloController _cavaloController;
        public Menu_Cadastro_Cavalo(Gerenciamento_Cavalo gerenciamento_Cavalo)
        {
            InitializeComponent();
            _gerenciamento_Cavalo = gerenciamento_Cavalo;
            _cavaloController = new CavaloController(new CavaloService(new CavaloRepository()));
        }

        private void textBox_NomeCavalo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string NomeCavalo = textBox_NomeCavalo.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void TextBox_AlturaCavalo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_Raca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string RacaCavalo = textBox_AlturaCavalo.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void textBox_AlturaCavalo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double AlturaCavalo = double.Parse(textBox_AlturaCavalo.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TextBox_PesoCavalo_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBox_PesoCavalo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double PesoCavalo = double.Parse(textBox_PesoCavalo.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void button_Numero_Click(object sender, EventArgs e)
        {
            RetornoDados<int> Retorno_cavalo = _cavaloController.CadastrarNumero();
            int Numero_Cavalo = Retorno_cavalo.Dados;
            label_Numero.Text = Numero_Cavalo.ToString();
            label_Numero.Visible = true;
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            if (
            string.IsNullOrEmpty(textBox_NomeCavalo.Text) ||
            string.IsNullOrEmpty(textBox_Raca.Text) ||
            string.IsNullOrEmpty(textBox_AlturaCavalo.Text) ||
            string.IsNullOrEmpty(textBox_PesoCavalo.Text) ||
            string.IsNullOrEmpty(label_Numero.Text))
            {
                resultado_Cadastro.Text = "Favor Preencher os campos obrigatórios";
                resultado_Cadastro.Visible = true;
                textBox_NomeCavalo.Text = "";
                textBox_Raca.Text = "";
                textBox_AlturaCavalo.Text = "";
                textBox_PesoCavalo.Text = "";
                label_Numero.Text = "";
                label_Numero.Visible = false;
            }
            else
            {

                RetornoStatus Cadastro = _cavaloController.CadastrarCavalo(
                    textBox_NomeCavalo.Text,
                    textBox_Raca.Text,
                    double.Parse(textBox_AlturaCavalo.Text),
                    double.Parse(textBox_PesoCavalo.Text),
                    int.Parse(label_Numero.Text));
                resultado_Cadastro.Text = Cadastro.Message;
                resultado_Cadastro.Visible = true;
                textBox_NomeCavalo.Text = "";
                textBox_Raca.Text = "";
                textBox_AlturaCavalo.Text = "";
                textBox_PesoCavalo.Text = "";
                label_Numero.Text = "";
                label_Numero.Visible = false;

            }
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {

            _gerenciamento_Cavalo.Show();
            this.Close();
        }

        private void resultado_Cadastro_Click(object sender, EventArgs e)
        {
            _gerenciamento_Cavalo.Show();
            this.Close();
        }


    }
}
