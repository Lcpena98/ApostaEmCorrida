using ApostaEmCorrida.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador.Gestao_Saldo
{
    public partial class Menu_Gestao_Saldo : Form
    {
        Menu_Apostador _menu_Apostador;
        Apostador _apostador;
        public Menu_Gestao_Saldo(Menu_Apostador menu_Apostador, Apostador apostador)
        {
            InitializeComponent();
            _menu_Apostador = menu_Apostador;
            _apostador = apostador;
        }
        private void button_Sacar_Click(object sender, EventArgs e)
        {
            Sacar sacar = new Sacar(this, _apostador);
            sacar.Show();
            this.Hide();
        }

        private void button_Depositar_Click(object sender, EventArgs e)
        {
            Depositar depositar = new Depositar(this, _apostador);
            depositar.Show();
            this.Hide();
        }
        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Apostador.Show();
            this.Close();
        }
    }
}
