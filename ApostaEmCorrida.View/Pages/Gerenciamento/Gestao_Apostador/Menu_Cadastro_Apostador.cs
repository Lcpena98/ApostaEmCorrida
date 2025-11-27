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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Cadastro_Apostador : Form
    {
        Login_Apostador _gerenciamento_Apostador;
        ApostadorController _apostadorController;

        public Menu_Cadastro_Apostador(Login_Apostador gerenciamento_Apostador)
        {
            InitializeComponent();
            _gerenciamento_Apostador = gerenciamento_Apostador;
            _apostadorController = new ApostadorController(new ApostadorService(new ApostadorRepository()));
        }

        private void button_Numero_Click(object sender, EventArgs e)
        {
            RetornoDados<int> retornoNumero = _apostadorController.CadastrarNumero();
            if (retornoNumero.Sucesso)
            {
                label_Numero.Text = retornoNumero.Dados.ToString();
                label_Numero.Visible = true;
            }
            else
            {
                MessageBox.Show("Não foi possível gerar o número do apostador.");
            }
        }
        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_NomeApostador.Text) ||
            string.IsNullOrEmpty(textBox_EmailApostador.Text) ||
            string.IsNullOrEmpty(textBox_SenhaApostador.Text) ||
            string.IsNullOrEmpty(textBox_ConfirmarSenha.Text) ||
            string.IsNullOrEmpty(label_Numero.Text))
            {
                MessageBox.Show("Favor Preencher os campos obrigatórios");
                textBox_NomeApostador.Text = "";
                textBox_EmailApostador.Text = "";
                textBox_SenhaApostador.Text = "";
                textBox_ConfirmarSenha.Text = "";
                label_Numero.Text = "";
                label_Numero.Visible = false;
            }
            else
            {

                if (textBox_SenhaApostador.Text != textBox_ConfirmarSenha.Text)
                {
                    MessageBox.Show("A senha deve ser igual ao confirmar senha");
                    textBox_NomeApostador.Text = "";
                    textBox_EmailApostador.Text = "";
                    textBox_SenhaApostador.Text = "";
                    textBox_ConfirmarSenha.Text = "";
                    label_Numero.Text = "";
                    label_Numero.Visible = false;
                }
                else
                {
                    try
                    {

                        RetornoStatus retorno = _apostadorController.CadastrarApostador(
                            textBox_NomeApostador.Text,
                            textBox_SenhaApostador.Text,
                            textBox_ConfirmarSenha.Text,
                            textBox_EmailApostador.Text.ToLower(),
                            int.Parse(label_Numero.Text),
                            0);
                        MessageBox.Show($"{retorno.Message}");
                        textBox_NomeApostador.Text = "";
                        textBox_EmailApostador.Text = "";
                        textBox_SenhaApostador.Text = "";
                        textBox_ConfirmarSenha.Text = "";
                        label_Numero.Text = string.Empty;
                        label_Numero.Visible = false;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar o Apostador!");
                        textBox_NomeApostador.Text = "";
                        textBox_EmailApostador.Text = "";
                        textBox_SenhaApostador.Text = "";
                        textBox_ConfirmarSenha.Text = "";
                        label_Numero.Text = string.Empty;
                        label_Numero.Visible = false;
                    }
                }
            }
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _gerenciamento_Apostador.Show();
            this.Close();
        }
    }
}
