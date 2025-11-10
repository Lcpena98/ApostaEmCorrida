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
    public partial class Menu_Exibicao_Corridas_Em_Andamento : Form
    {
        Menu_Gerenciar_Corridas _menu_Gerenciar_Corridas;
        public Menu_Exibicao_Corridas_Em_Andamento(Menu_Gerenciar_Corridas menu_Gerenciar_Corridas)
        {
            InitializeComponent();
            _menu_Gerenciar_Corridas = menu_Gerenciar_Corridas;

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
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Gerenciar_Corridas.Show();
            this.Close();
        }
    }
}
