using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApostaEmCorrida.Domain;

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Cadastro_Cavalo : Form
    {
        Menu_Inicial _inicial;
        string NomeCavalo;
        double AlturaCavalo, PesoCavalo;
        int Numero_Cavalo;
        Casa _casa;
        public Menu_Cadastro_Cavalo(Menu_Inicial menu, Casa casa)
        {
            InitializeComponent();
            _inicial = menu;
            _casa = casa;
        }

        private void Menu_Cadastro_Cavalo_Load(object sender, EventArgs e)
        {

        }

        private void textBox_NomeCavalo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NomeCavalo = textBox_NomeCavalo.Text;
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
        private void textBox_AlturaCavalo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AlturaCavalo = double.Parse(textBox_AlturaCavalo.Text);
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
                PesoCavalo = double.Parse(textBox_PesoCavalo.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void button_Numero_Click(object sender, EventArgs e)
        {
            Numero_Cavalo = Cavalo.CadastrarNumero(_casa.Cavalos);

            label_Numero.Text = Numero_Cavalo.ToString();
            label_Numero.Visible = true;
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            if (
            string.IsNullOrEmpty(textBox_NomeCavalo.Text) ||
            string.IsNullOrEmpty(textBox_AlturaCavalo.Text) ||
            string.IsNullOrEmpty(textBox_PesoCavalo.Text) ||
            string.IsNullOrEmpty(label_Numero.Text))
            {
                resultado_Cadastro.Text = "Favor Preencher os campos obrigatórios";
                resultado_Cadastro.Visible = true;
                textBox_NomeCavalo.Text = "";
                textBox_AlturaCavalo.Text = "";
                textBox_PesoCavalo.Text = "";
                label_Numero.Text = "";
                label_Numero.Visible = false;
            }
            else
            {
                try
                {
                    Cavalo.CadastrarCavalo(_casa.Cavalos, NomeCavalo, AlturaCavalo, PesoCavalo, Numero_Cavalo, _casa.Saldo);
                    resultado_Cadastro.Text = ($"Cavalo cadastrado com sucesso!\nCavalo: {NomeCavalo} - {Numero_Cavalo}");

                    resultado_Cadastro.Visible = true;
                    textBox_NomeCavalo.Text = "";
                    textBox_AlturaCavalo.Text = "";
                    textBox_PesoCavalo.Text = "";
                    label_Numero.Text = "";
                    label_Numero.Visible = false;
                }
                catch
                {
                    resultado_Cadastro.Text = "Erro! Não foi possível realizar o cadastro do cavalo!";
                    resultado_Cadastro.Visible = true;
                }
            }
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _inicial.Show();
            this.Close();
        }
    }
}
