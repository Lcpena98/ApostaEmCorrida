using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ApostaEmCorrida.View.Pages.Gestao_Cavalo;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas;

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Inicial : Form
    {
        public Menu_Inicial()
        {
            InitializeComponent();
        }


        private void button_Cadastro_Cavalo_Click(object sender, EventArgs e)
        {
            Gerenciamento_Cavalo menu_Gerenciamento_Cavalo = new Gerenciamento_Cavalo(this);
            menu_Gerenciamento_Cavalo.Show();
            this.Hide();
        }

        private void button_Cadastro_Apostador_Click(object sender, EventArgs e)
        {
            Login_Apostador menu_Gerenciamento_Apostador = new Login_Apostador(this);
            menu_Gerenciamento_Apostador.Show();
            this.Hide();
        }

        private void button_Corridas_Click(object sender, EventArgs e)
        {

        }

        private void button_Corrida_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Gerenciar_Corridas menu_Gerenciar_Corridas = new Menu_Gerenciar_Corridas(this);
                menu_Gerenciar_Corridas.Show();
                this.Hide();
            }
            catch (ApplicationException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
