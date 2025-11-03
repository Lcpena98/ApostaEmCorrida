using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using Microsoft.IdentityModel.Tokens;
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
    public partial class Menu_TrocaSenha_Apostador : Form
    {
        Menu_Apostador _menu_Apostador;
        Apostador _apostador;
        ApostadorController _apostadorController;
        public Menu_TrocaSenha_Apostador(Menu_Apostador menu_Apostador, Apostador apostador)
        {
            InitializeComponent();
            _menu_Apostador = menu_Apostador;
            _apostador = apostador;
            _apostadorController = new ApostadorController(new ApostadorService(new ApostadorRepository()));
            label_Dados_Usuario.Text = $"{_apostador.Nome.ToString()} - {_apostador.Numero.ToString()}";
        }
        private void button_Alterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Senha_Apostador.Text)||
                string.IsNullOrEmpty(textBox_NovaSenha_Apostador.Text) ||
                string.IsNullOrEmpty(textBox_Confirma_Nova_Senha_Apostador.Text))
            {
                MessageBox.Show("Favor preencher os dados!");
            }
            else
            {
                RetornoStatus retornoAlteracao = _apostadorController.TrocarSenhaApostador(textBox_Senha_Apostador.Text, textBox_NovaSenha_Apostador.Text, textBox_Confirma_Nova_Senha_Apostador.Text, _apostador.Numero);
                MessageBox.Show(retornoAlteracao.Message);
                
            }
        }
        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Apostador.Show();
            this.Close();
        }


    }
}
