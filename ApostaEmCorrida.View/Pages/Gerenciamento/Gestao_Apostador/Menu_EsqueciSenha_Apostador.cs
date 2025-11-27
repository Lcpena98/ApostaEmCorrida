using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
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
    public partial class Menu_EsqueciSenha_Apostador : Form
    {
        Login_Apostador _login_Apostador;
        ApostadorController _apostadorController;
        public Menu_EsqueciSenha_Apostador(Login_Apostador login_Apostador)
        {
            InitializeComponent();
            _login_Apostador = login_Apostador;
            _apostadorController = new ApostadorController(new ApostadorService(new ApostadorRepository()));
        }
        private void button_Gerar_Codigo_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;
            string senhaCavalo = textBox_NovaSenha.Text;
            string confirmaSenhaCavalo = textBox_ConfirmaNovaSenha.Text;
            RetornoStatus reset = _apostadorController.ResetarSenhaApostador(email, senhaCavalo, confirmaSenhaCavalo);
            MessageBox.Show(reset.Message);
            _login_Apostador.Show();
            this.Close();
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            _login_Apostador.Show();
            this.Close();
        }
    }
}
