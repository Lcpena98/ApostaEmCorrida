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

        private void button_Dados_Cavalos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!");
        }

        private void button_Dados_Apostadores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!");
        }

        private void button_Dados_Apostas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!");
        }

        private void button_Dados_Corridas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!");
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
/*
             IDEIA DE IMPLEMENTAÇÃO FUTURA
            1. Verificar as datas de corridas agendadas que são menores que o Datetime.Now e alterar o status para "Em Andamento"
            2. Carregar as corridas com status "Em Andamento" na datagridview
            3. Criar botões para "Finalizar Corrida" e "Ver Detalhes da Corrida"
            4. Usar o método Random em cada cavalo para determinar o desempenho em cada volta e preencher a tabela de Voltas
            5. Calcular o tempo total de cada cavalo e determinar a ordem de chegada
            6. Validar os vencedores e posições e preencher os dados na tabela de Resultados
            7. Atualizar o status da corrida para "Finalizada"
            8. Notificar os usuários sobre os resultados das corridas finalizadas

            OBS: O Banco já está implementado para suportar essas funcionalidades.
             */