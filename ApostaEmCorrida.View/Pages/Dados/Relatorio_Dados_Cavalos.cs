using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
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

namespace ApostaEmCorrida.View.Pages.Dados
{
    public partial class Relatorio_Dados_Cavalos : Form
    {
        Menu_Inicial _menu_Inicial;
        CavaloController _cavaloController;
        public Relatorio_Dados_Cavalos(Menu_Inicial menu_Inicial)
        {
            InitializeComponent();
            _menu_Inicial = menu_Inicial;
            _cavaloController = new CavaloController(new CavaloService(new CavaloRepository()));

            dataGridView_Cavalos.DataSource = _cavaloController.BuscarTodosCavalos().Dados;
            dataGridView_Cavalos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Cavalos.MultiSelect = false;
            dataGridView_Cavalos.ReadOnly = true;
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            _menu_Inicial.Show();
            this.Close();
        }
    }
}
