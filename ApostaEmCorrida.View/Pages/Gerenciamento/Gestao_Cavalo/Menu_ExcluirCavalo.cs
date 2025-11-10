using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.View.Pages.Gestao_Cavalo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Cavalo
{
    public partial class Menu_ExcluirCavalo : Form
    {
        Gerenciamento_Cavalo _gerenciamento_Cavalo;
        CavaloController _cavaloController;
        public Menu_ExcluirCavalo(Gerenciamento_Cavalo gerenciamento_Cavalo)
        {
            InitializeComponent();
            _gerenciamento_Cavalo = gerenciamento_Cavalo;
            _cavaloController = new CavaloController(new CavaloService(new CavaloRepository()));

            RetornoDados<List<Cavalo>> retornoDados = _cavaloController.BuscarTodosCavalos();
            if (retornoDados.Sucesso)
            {
                foreach (Cavalo cavalo in retornoDados.Dados)
                    comboBox_Cavalos.Items.Add(cavalo);
            }
            else
            {
                MessageBox.Show(retornoDados.Message);
            }
        }

        private void button_Excluir_Cavalo_Click(object sender, EventArgs e)
        {
            /*if (comboBox_Cavalos.Items.Count > 0)
            {
                Cavalo cavaloSelecionado = (Cavalo)comboBox_Cavalos.SelectedItem;
                int numeroCavalo = cavaloSelecionado.Numero_Cavalo;
                RetornoStatus retornoExclusao = _cavaloController.RemoverCavalo(numeroCavalo);
                if (retornoExclusao.Sucesso)
                {
                    resultado_Exclusao.Text = retornoExclusao.Message;
                    resultado_Exclusao.Visible = true;
                    comboBox_Cavalos.Items.Remove(cavaloSelecionado);
                    comboBox_Cavalos.SelectedIndex = -1;
                    comboBox_Cavalos.Text = string.Empty;
                }
                else
                {
                    resultado_Exclusao.Text = retornoExclusao.Message;
                    resultado_Exclusao.Visible = true;
                }
            }
            else
            {
                resultado_Exclusao.Text = "Nenhum cavalo disponível para exclusão.";
                resultado_Exclusao.Visible = true;
            }*/

            /*
             * 
            */
            MessageBox.Show("Em Desenvolvimento!\r\nAgora que Cavalos são registrados em corridas.\r\n É necessário validar que o cavalo não esteja registrado em nenhuma corrida para que o mesmo seja excluido.\r\n Minha ideia é fazer a validação e apenas criar o Status do Cavalo (Removido) e apenas alterar para o mesmo, sem remove-lo do banco.");
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _gerenciamento_Cavalo.Show();
            this.Close();
        }
    }
}
