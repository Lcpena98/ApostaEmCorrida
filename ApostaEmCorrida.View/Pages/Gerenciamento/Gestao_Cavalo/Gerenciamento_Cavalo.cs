using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Cavalo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages.Gestao_Cavalo
{
    public partial class Gerenciamento_Cavalo : Form
    {
        Menu_Inicial _menu_Inicial;
        public Gerenciamento_Cavalo(Menu_Inicial menu_Inicial)
        {
            InitializeComponent();
            _menu_Inicial = menu_Inicial;
        }
        private void button_Cadastro_Cavalo_Click(object sender, EventArgs e)
        {
            Menu_Cadastro_Cavalo _menu_Cadastro_Cavalo = new Menu_Cadastro_Cavalo(this);
            _menu_Cadastro_Cavalo.Show();
            this.Hide();
        }

        private void button_Alterar_Dados_Click(object sender, EventArgs e)
        {
            Menu_AlterarDados _menu_AlterarDados = new Menu_AlterarDados(this);
            _menu_AlterarDados.Show();
            this.Hide();    
        }
        private void button_Excluir_Cavalo_Click(object sender, EventArgs e)
        {
            Menu_ExcluirCavalo _menu_ExcluirCavalo = new Menu_ExcluirCavalo(this);
            _menu_ExcluirCavalo.Show();
            this.Hide();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menu_Inicial.Show();
            this.Close();
        }

        
    }
}
