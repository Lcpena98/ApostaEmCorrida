using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Domain;
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

namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador
{
    public partial class Menu_AlterarDados_Apostador : Form
    {
        Menu_Apostador _menu_Apostador;
        Apostador _apostador;
        ApostadorController _apostadorController;
        ApostadorService _apostadorService;
        ApostadorRepository _apostadorRepository;
        public Menu_AlterarDados_Apostador(Menu_Apostador menu_Apostador, Apostador apostador)
        {
            InitializeComponent();
            _menu_Apostador = menu_Apostador;
            _apostador = apostador;
            _apostadorRepository = new ApostadorRepository();
            _apostadorService = new ApostadorService(_apostadorRepository);
            _apostadorController = new ApostadorController(_apostadorService);
            label_Dados_Usuario.Text = $"{_apostador.Nome.ToString()} - {_apostador.Numero.ToString()}";
        }

        private void button_Alterar_Click(object sender, EventArgs e)
        {
            string nome, email;
            if (string.IsNullOrEmpty(textBox_AlterarNome_Apostador.Text))
            {
                nome = _apostador.Nome;
            }
            else
            {
                nome = textBox_AlterarNome_Apostador.Text.ToString();
            }
            if (string.IsNullOrEmpty(textBox_AlterarEmail_Apostador.Text))
            {
                email = _apostador.Email;
            }
            else
            {
                email = textBox_AlterarEmail_Apostador.Text.ToString();
            }
            RetornoStatus retornoAlteracao = _apostadorController.AlterarDadosApostador(textBox_AlterarNome_Apostador.Text, textBox_AlterarEmail_Apostador.Text, _apostador.Numero);
            MessageBox.Show(retornoAlteracao.Message);
            textBox_AlterarNome_Apostador.Text = string.Empty;
            textBox_AlterarEmail_Apostador.Text = string.Empty;
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            _menu_Apostador.Show();
            this.Close();
        }
    }
}
