using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas
{
    public partial class Menu_Gerenciar_Corridas : Form
    {
        Menu_Inicial _menu_Inicial;
        public Menu_Gerenciar_Corridas(Menu_Inicial menu_Inicial)
        {
            InitializeComponent();
            _menu_Inicial = menu_Inicial;
        }

        private void button_Nova_Corrida_Click(object sender, EventArgs e)
        {
            Menu_Cadastro_Corrida _menu_Cadastro_Corrida = new Menu_Cadastro_Corrida(this);
            _menu_Cadastro_Corrida.Show();
            this.Hide();
        }

        private void button_Corridas_Agendadas_Click(object sender, EventArgs e)
        {

        }

        private void button_Corridas_Andamento_Click(object sender, EventArgs e)
        {

        }

        private void button_Corridas_Finalizadas_Click(object sender, EventArgs e)
        {

        }
        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Inicial.Show();
            this.Close();
        }
    }
}
