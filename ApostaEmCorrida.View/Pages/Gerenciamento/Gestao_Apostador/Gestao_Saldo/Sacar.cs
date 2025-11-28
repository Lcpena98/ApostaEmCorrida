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

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador.Gestao_Saldo
{
    public partial class Sacar : Form
    {
        Menu_Gestao_Saldo _menu_Gestao_Saldo;
        Apostador _apostador;
        ApostadorController _apostadorController;
        public Sacar(Menu_Gestao_Saldo menu_Gestao_Saldo, Apostador apostador)
        {
            InitializeComponent();
            _menu_Gestao_Saldo = menu_Gestao_Saldo;
            _apostador = apostador;
            _apostadorController = new ApostadorController(new ApostadorService(new ApostadorRepository()));
        }
        private void textBox_Valor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void button_Sacar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Valor.Text))
            {
                MessageBox.Show("Insira um valor para apostar.");
            }
            else
            {
                double valorDeSaque = Convert.ToDouble(textBox_Valor.Text);
                if (_apostador.Saldo < valorDeSaque)
                {
                    MessageBox.Show("Saldo insuficiente para realizar o saque.");
                }
                else
                {
                    RetornoStatus retorno = _apostadorController.RemoverSaldo(_apostador, valorDeSaque);
                    _apostador = _apostadorController.BuscarApostadorPorNumero(_apostador.Numero).Dados;
                    MessageBox.Show(retorno.Message);
                    MessageBox.Show($"Seu saldo atual é de: R$ {_apostador.Saldo}");
                    textBox_Valor.Text = "";
                }
            }
        }
        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Gestao_Saldo.Show();
            this.Close();
        }


    }
}
