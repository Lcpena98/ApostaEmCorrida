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

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador
{
    public partial class Login_Apostador : Form
    {
        Menu_Inicial _menu_Inicial;
        ApostadorController _apostadorController;
        public Login_Apostador(Menu_Inicial menu_Inicial)
        {
            InitializeComponent();
            _menu_Inicial = menu_Inicial;
            _apostadorController = new ApostadorController(new ApostadorService(new ApostadorRepository()));
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_EmailApostador.Text) || string.IsNullOrEmpty(textBox_SenhaApostador.Text))
            {
                MessageBox.Show("Favor preencher os dados!");
            }
            else
            {
                MessageBox.Show("Ainda é necessário configurar o cadastro não valida se o e-mail Já está cadastrado, é preciso validar");
                RetornoDados<Apostador> retornoApostador = _apostadorController.BuscarApostadorPorEmail(textBox_EmailApostador.Text);
                if (retornoApostador.Sucesso)
                {
                    if (retornoApostador.Dados.Senha == textBox_SenhaApostador.Text)
                    {
                        MessageBox.Show(retornoApostador.Message);
                        Menu_Apostador _menu_apostador = new Menu_Apostador(this,retornoApostador.Dados);
                        _menu_apostador.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!");
                    }
                }
                else
                {
                    MessageBox.Show(retornoApostador.Message);
                }

            }
        }

        private void button_Cadastro_Apostador_Click(object sender, EventArgs e)
        {
            Menu_Cadastro_Apostador _menu_Cadastro_Apostador = new Menu_Cadastro_Apostador(this);
            _menu_Cadastro_Apostador.Show();
            this.Hide();
        }

        private void button_trocar_senha_Click(object sender, EventArgs e)
        {
            Menu_EsqueciSenha_Apostador esqueciSenha_Apostador = new Menu_EsqueciSenha_Apostador(this);
            esqueciSenha_Apostador.Show();
            this.Hide();
        }


        private void button_esqueci_senha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!");
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menu_Inicial.Show();
            this.Close();
        }
    }
}
