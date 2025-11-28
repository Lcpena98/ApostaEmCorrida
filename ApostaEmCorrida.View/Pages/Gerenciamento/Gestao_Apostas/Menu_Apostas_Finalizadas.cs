using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Enumerator;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostas
{
    public partial class Menu_Apostas_Finalizadas : Form
    {
        Menu_Minhas_Apostas _menuMinhasApostas;
        List<Aposta> _apostasFinalizadas;
        ApostaController _apostaController;
        public Menu_Apostas_Finalizadas(Menu_Minhas_Apostas minhas_Apostas, List<Aposta> apostasFinalizadas, bool temApostasPendenteValidacao)
        {
            InitializeComponent();
            _menuMinhasApostas = minhas_Apostas;
            _apostasFinalizadas = apostasFinalizadas;
            _apostaController = new ApostaController(new ApostaService(new ApostaRepository(), new ApostadorRepository(), new CorridaRepository()));

            Preencher_Lista(temApostasPendenteValidacao);
        }
        public void Recarregar_Lista(object sender, EventArgs e)
        {
            Preencher_Lista(false);
        }
        private void Preencher_Lista(bool temApostasPendenteValidacao)
        {
            dataGridView_Apostas.DataSource = null;
            dataGridView_Apostas.AutoGenerateColumns = false;
            dataGridView_Apostas.Columns.Clear();
            dataGridView_Apostas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CavaloApostado",
                HeaderText = "Competidor"
            });
            dataGridView_Apostas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorApostado",
                HeaderText = "Valor Apostado"
            });
            dataGridView_Apostas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status da Aposta"
            });
            dataGridView_Apostas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Apostas.MultiSelect = false;
            dataGridView_Apostas.ReadOnly = true;
            dataGridView_Apostas.DataSource = _apostasFinalizadas;
            dataGridView_Apostas.ClearSelection();
            if (temApostasPendenteValidacao == false)
            {
                button_Validar_Apostas.Text = "Verificar Dados";
            }
        }
        private void button_Validar_Apostas_Click(object sender, EventArgs e)
        {
            foreach (Aposta aposta in _apostasFinalizadas)
            {
                RetornoStatus validacao = _apostaController.AtualizarStatus(aposta, (int)StatusAposta.Finalizada);
                if (validacao.Sucesso == false)
                {
                    MessageBox.Show($"Erro ao validar a aposta no competidor {aposta.CavaloApostado.Nome}: {validacao.Message}");
                }
                else
                {
                    MessageBox.Show($"Aposta feita em: {aposta.CavaloApostado.Nome}, \n\r Resultado: {aposta.Status.ToString()}\r\nPremio: R${aposta.ValorPremio}");
                }
            }
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menuMinhasApostas.Show();
            this.Close();
        }
    }
}