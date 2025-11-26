using ApostaEmCorrida.Domain;
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
    public partial class Menu_Apostador : Form
    {
        Login_Apostador _login_Apostador;
        Apostador _apostador;
        public Menu_Apostador(Login_Apostador login_Apostador, Apostador apostador)
        {
            InitializeComponent();
            _login_Apostador = login_Apostador;
            _apostador = apostador;
        }

        private void button_trocar_senha_Click(object sender, EventArgs e)
        {
            Menu_TrocaSenha_Apostador _menu_TrocaSenha_Apostador = new Menu_TrocaSenha_Apostador(this, _apostador);
            _menu_TrocaSenha_Apostador.Show();
            this.Hide();
        }

        private void button_alterar_dados_Click(object sender, EventArgs e)
        {
            Menu_AlterarDados_Apostador _menu_AlterarDados_Apostador = new Menu_AlterarDados_Apostador(this, _apostador);
            _menu_AlterarDados_Apostador.Show();
            this.Hide();
        }

        private void button_Cadastrar_Aposta_Click(object sender, EventArgs e)
        {
            Menu_Registro_Aposta _menu_Registro_Aposta = new Menu_Registro_Aposta(this, _apostador);
            _menu_Registro_Aposta.Show();
            this.Hide();
        }
        private void button_Minhas_Apostas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função Em Desenvolvimento.");
        }
        private void button_Saldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu saldo atual é: R$ {_apostador.Saldo:F2}");
            MessageBox.Show("Função Em Desenvolvimento.");
        }
        private void button_voltar_Click(object sender, EventArgs e)
        {
            _login_Apostador.Show();
            this.Close();
        }

        
    }
}
