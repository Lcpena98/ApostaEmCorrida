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
            label_Resultado_Corrida.Visible = false;
            this.Hide();
        }

        private void button_Cadastro_Apostador_Click(object sender, EventArgs e)
        {
            Login_Apostador menu_Gerenciamento_Apostador = new Login_Apostador(this);
            menu_Gerenciamento_Apostador.Show();
            this.Hide();
        }

        private void button_Registro_Aposta_Click(object sender, EventArgs e)
        {
            /*Menu_Registro_Aposta menu_Registro_Aposta = new Menu_Registro_Aposta(this, _CasaController);
            menu_Registro_Aposta.Show();
            label_Resultado_Corrida.Visible = false;*/
            this.Hide();
        }

        private void button_Dados_Cadastrados_Click(object sender, EventArgs e)
        {

        }

        private void button_Corridas_Click(object sender, EventArgs e)
        {

        }

        private void button_Documentos_Click(object sender, EventArgs e)
        {

        }

        private void button_Nova_Corrida_Click(object sender, EventArgs e)
        {
            try
            {
                // PARA REFAZER APÓS ALTERAÇÕES

                /*Cavalo vencedor = Corrida.novaCorrida(casa);
                label_Resultado_Corrida.Text = ($"O Vencedor é: {vencedor.Nome.ToString()} - [{vencedor.Numero_Cavalo}]");
                label_Resultado_Corrida.Visible = true;*/
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
