using ApostaEmCorrida.Controller;
using ApostaEmCorrida.Dapper;
using ApostaEmCorrida.Dapper.Interfaces;
using ApostaEmCorrida.Domain;
using ApostaEmCorrida.Domain.Retorno;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.Services.Interfaces;
using ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Registro_Aposta : Form
    {
        Menu_Apostador _menu_Apostador;
        Apostador _apostador;
        CavaloController _cavaloController;
        ApostaController _apostaController;

        public Menu_Registro_Aposta(Menu_Apostador menu_Apostador, Apostador apostador)
        {
            InitializeComponent();
            _menu_Apostador = menu_Apostador;
            _apostador = apostador;
            _cavaloController = new CavaloController(new CavaloService(new CavaloRepository()));
            _apostaController = new ApostaController(new ApostaService(new ApostaRepository()));
            label_Dados_Usuario.Text = $"{_apostador.Nome.ToString()} - {_apostador.Numero.ToString()}";
            RetornoDados<List<Cavalo>> retornoCavalos = _cavaloController.BuscarTodosCavalos();
            foreach (Cavalo cavalo in retornoCavalos.Dados)
            {
                comboBox_Cavalo.Items.Add(cavalo);
            }
        }
        private void TextBox_Valor_Apostado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir controle (backspace)
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir apenas uma vírgula ou ponto
            TextBox txt = sender as TextBox;
            if ((e.KeyChar == '.') && (txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            //FEITO A ALTERAÇÃO PARA VINCULAR A APOSTA A CORRIDA, AINDA FALTA FAZER ESSA LIGAÇÃO APÓS CRIAR E GERENCIAR A CORRIDA
            
            /*try
            {
                if (string.IsNullOrEmpty(textBox_Valor_Apostado.Text))
                {
                    resultado_Cadastro.Text = ("Valor em branco");
                    resultado_Cadastro.Visible = true;
                    textBox_Valor_Apostado.Text = string.Empty;
                }
                else
                {
                    try
                    {*/

                        /*Cavalo cavalo = comboBox_Cavalo.SelectedItem as Cavalo;
                        double valorApostado = Convert.ToDouble(textBox_Valor_Apostado.Text);
                        RetornoStatus retorno = _apostaController.RegistrarAposta(cavalo.Numero_Cavalo, _apostador.Numero, valorApostado);
                        resultado_Cadastro.Text = (retorno.Message);
                        resultado_Cadastro.Visible = true;
                        textBox_Valor_Apostado.Text = string.Empty;
                        comboBox_Cavalo.SelectedItem = -1;
                        comboBox_Cavalo.Text = string.Empty;*/

                        /*resultado_Cadastro.Text = ("FEITO A ALTERAÇÃO PARA VINCULAR A APOSTA A CORRIDA, AINDA FALTA FAZER ESSA LIGAÇÃO APÓS CRIAR E GERENCIAR A CORRIDA");
                        resultado_Cadastro.Visible = true;

                    }
                    catch
                    {
                        resultado_Cadastro.Text = ("Selecione um cavalo");
                        resultado_Cadastro.Visible = true;
                        textBox_Valor_Apostado.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                resultado_Cadastro.Text = ($"Erro inesperado: {ex.Message}");
                resultado_Cadastro.Visible = true;
            }*/

            MessageBox.Show("Em Desenvolvimento! \r\n Agora que as corridas estão cadastradas.\r\n É necessário vincular as apostas com as mesmas.");
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _menu_Apostador.Show();
            this.Close();
        }
    }
}
