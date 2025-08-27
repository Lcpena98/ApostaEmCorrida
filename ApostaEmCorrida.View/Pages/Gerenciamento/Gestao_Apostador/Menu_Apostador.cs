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
            Menu_TrocaSenha_Apostador _menu_TrocaSenha_Apostador = new Menu_TrocaSenha_Apostador(this,_apostador);
            _menu_TrocaSenha_Apostador.Show();
            this.Hide();
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            _login_Apostador.Show();
            this.Close();
        }

        
    }
}
