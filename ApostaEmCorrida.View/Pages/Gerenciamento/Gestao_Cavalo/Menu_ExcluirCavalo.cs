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
        CavaloService _cavaloService;
        CavaloRepository _cavaloRepository;
        public Menu_ExcluirCavalo(Gerenciamento_Cavalo gerenciamento_Cavalo)
        {
            InitializeComponent();
            _gerenciamento_Cavalo = gerenciamento_Cavalo;
            _cavaloRepository = new CavaloRepository();
            _cavaloService = new CavaloService(_cavaloRepository);
            _cavaloController = new CavaloController(_cavaloService);

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
            if (comboBox_Cavalos.Items.Count > 0)
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
            }
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _gerenciamento_Cavalo.Show();
            this.Close();
        }
    }
}
