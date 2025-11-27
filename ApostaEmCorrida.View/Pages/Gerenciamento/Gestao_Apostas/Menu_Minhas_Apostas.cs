using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador;
using ApostaEmCorrida.Domain.Enumerator;
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
    public partial class Menu_Minhas_Apostas : Form
    {
        Menu_Apostador _menu_Apostador;
        Apostador _apostador;
        ApostaController _apostaController;
        List<Aposta> _minhasApostas;
        bool apostaParaValidar = false;
        public Menu_Minhas_Apostas(Menu_Apostador menu_Apostador, Apostador apostador)
        {
            InitializeComponent();
            _menu_Apostador = menu_Apostador;
            _apostador = apostador;
            _apostaController = new ApostaController(new ApostaService(new ApostaRepository(), new ApostadorRepository(), new CorridaRepository()));
            _minhasApostas = _apostaController.BuscarApostasPorApostador(_apostador);
            if (_minhasApostas.Count == 0)
            {
                MessageBox.Show("Você não possui apostas cadastradas.");
            }
            else
            {
                Preencher_Lista();
                foreach (Aposta aposta in _minhasApostas)
                {
                    if (aposta.CorridaApostada.CorridaStatus == CorridaStatus.Finalizada && aposta.Status != StatusAposta.Finalizada)
                    {
                        apostaParaValidar = true;
                        MessageBox.Show("Você possui apostas para serem validadas!\n\rClique em Validar Apostas Para validar as mesmas!");
                        button_Validar_Apostas.Text = "Validar Apostas";
                        break;
                    }
                }
            }
        }

        public void Recarregar_Lista(object sender, EventArgs e)
        {
            Preencher_Lista();
        }
        private void Preencher_Lista() 
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
            dataGridView_Apostas.DataSource = _minhasApostas;
            dataGridView_Apostas.ClearSelection();
        }
        private void button_Validar_Apostas_Click(object sender, EventArgs e)
        {
            List<Aposta> apostasParaValidar = new List<Aposta>();
            if (apostaParaValidar == true)
            {
                foreach (Aposta aposta in _minhasApostas)
                {
                    if (aposta.CorridaApostada.CorridaStatus == CorridaStatus.Finalizada && aposta.Status != StatusAposta.Finalizada)
                    {
                        apostasParaValidar.Add(aposta);
                    }
                }
                Menu_Apostas_Finalizadas menu_Apostas_Finalizadas = new Menu_Apostas_Finalizadas(this, apostasParaValidar, apostaParaValidar);
                menu_Apostas_Finalizadas.Show();
                this.Hide();
            }
            else
            {
                foreach (Aposta aposta in _minhasApostas)
                {
                    if (aposta.CorridaApostada.CorridaStatus == CorridaStatus.Finalizada && aposta.Status == StatusAposta.Finalizada)
                    {
                        apostasParaValidar.Add(aposta);
                    }
                }
                Menu_Apostas_Finalizadas menu_Apostas_Finalizadas = new Menu_Apostas_Finalizadas(this, apostasParaValidar, apostaParaValidar);
                menu_Apostas_Finalizadas.Show();
                this.Hide();
            }
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menu_Apostador.Show();
            this.Close();
        }
    }
}
