using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Menu_Cadastro_Cavalo menu_Cadastro_Cavalo= new Menu_Cadastro_Cavalo(this);
            menu_Cadastro_Cavalo.Show();
            this.Hide();
        }

        private void button_Cadastro_Apostador_Click(object sender, EventArgs e)
        {

        }

        private void button_Registro_Aposta_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
