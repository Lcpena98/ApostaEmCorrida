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
    public partial class Gerenciamento_Apostador : Form
    {
        Menu_Inicial _menu_Inicial;
        public Gerenciamento_Apostador(Menu_Inicial menu_Inicial)
        {
            InitializeComponent();
            _menu_Inicial = menu_Inicial;
        }

        private void button_Cadastro_Apostador_Click(object sender, EventArgs e)
        {
            Menu_Cadastro_Apostador _menu_Cadastro_Apostador = new Menu_Cadastro_Apostador(this);
            _menu_Cadastro_Apostador.Show();
            this.Hide();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menu_Inicial.Show();
            this.Close();
        }

        private void Gerenciamento_Apostador_Load(object sender, EventArgs e)
        {

        }
    }
}
