using ApostaEmCorrida.API.Controllers;
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

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Inicial : Form
    {
        CasaController _CasaController;
        public Menu_Inicial()
        {
            InitializeComponent();
            _CasaController = new CasaController();

        }


        private void button_Cadastro_Cavalo_Click(object sender, EventArgs e)
        {
            Menu_Cadastro_Cavalo menu_Cadastro_Cavalo = new Menu_Cadastro_Cavalo(this);
            menu_Cadastro_Cavalo.Show();
            label_Resultado_Corrida.Visible = false;
            this.Hide();
        }

        private void button_Cadastro_Apostador_Click(object sender, EventArgs e)
        {
            /*Menu_Cadastro_Apostador menu_Cadastro_Apostador = new Menu_Cadastro_Apostador(this,_CasaController);
            menu_Cadastro_Apostador.Show();
            label_Resultado_Corrida.Visible = false;*/
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
