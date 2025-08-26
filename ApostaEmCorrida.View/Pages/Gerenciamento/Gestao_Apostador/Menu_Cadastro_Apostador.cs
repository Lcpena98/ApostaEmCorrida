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
        Gerenciamento_Apostador _gerenciamento_Apostador;
        ApostadorController _apostadorController;
        ApostadorService _apostadorService;
        ApostadorRepository _apostadorRepository;

        public Menu_Cadastro_Apostador(Gerenciamento_Apostador gerenciamento_Apostador)
        {
            InitializeComponent();
            _gerenciamento_Apostador = gerenciamento_Apostador;
            _apostadorRepository = new ApostadorRepository();
            _apostadorService = new ApostadorService(_apostadorRepository);
            _apostadorController = new ApostadorController(_apostadorService);
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
                resultado_Cadastro.Text = "Não foi possível gerar o número do apostador.";
                resultado_Cadastro.Visible = true;
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
                resultado_Cadastro.Text = "Favor Preencher os campos obrigatórios";
                resultado_Cadastro.Visible = true;

                resultado_Cadastro.Visible = true;
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
                    resultado_Cadastro.Text = "A senha deve ser igual ao confirmar senha";
                    resultado_Cadastro.Visible = true;

                    resultado_Cadastro.Visible = true;
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
                            resultado_Cadastro.Text = ($"{retorno.Message}");
                            resultado_Cadastro.Visible = true;
                            textBox_NomeApostador.Text = "";
                            textBox_EmailApostador.Text = "";
                            textBox_SenhaApostador.Text = "";
                            textBox_ConfirmarSenha.Text = "";
                            label_Numero.Text = string.Empty;
                            label_Numero.Visible = false;
                        }
                        catch
                        {
                            resultado_Cadastro.Text = "Não foi possível cadastrar o Apostador!";
                            resultado_Cadastro.Visible = true;
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
