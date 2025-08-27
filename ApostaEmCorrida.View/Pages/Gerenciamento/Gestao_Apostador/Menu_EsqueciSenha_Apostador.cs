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
    public partial class Menu_EsqueciSenha_Apostador : Form
    {
        Login_Apostador _login_Apostador;
        public Menu_EsqueciSenha_Apostador(Login_Apostador login_Apostador)
        {
            InitializeComponent();
            _login_Apostador = login_Apostador;
        }

        private void button_Alterar_Click(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            _login_Apostador.Show();
            this.Close();
        }
    }
}
