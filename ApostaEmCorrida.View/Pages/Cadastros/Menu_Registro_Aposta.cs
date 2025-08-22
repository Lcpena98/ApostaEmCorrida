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

namespace ApostaEmCorrida.View.Pages
{
    public partial class Menu_Registro_Aposta : Form
    {
        Casa _casa;
        Menu_Inicial _Inicial;
        Apostador apostador;
        Cavalo cavalo;
        double valor;
        
        public Menu_Registro_Aposta(Menu_Inicial inicial)
        {
            InitializeComponent();
            _Inicial = inicial;
            
            foreach (Apostador apostador in _casa.Apostadores)
            {
                comboBox_Apostador.DataSource = _casa.Apostadores.ToList();
                //comboBox_Apostador.DisplayMember = "Nome";       // O que aparece na lista
                //comboBox_Apostador.ValueMember = "Numero";       // Valor interno (id ou número)
            }

            foreach (Cavalo cavalo in _casa.Cavalos)
            {
                comboBox_Cavalo.DataSource = _casa.Cavalos.ToList();
                //comboBox_Apostador.DisplayMember = "Nome";       // O que aparece na lista
                //comboBox_Apostador.ValueMember = "Numero_Cavalo";       // Valor interno (id ou número)
            }
        }

        private void comboBox_Apostador_SelectedIndexChanged(object sender, EventArgs e)
        {
            apostador = (Apostador)comboBox_Apostador.SelectedItem;
        }
        private void comboBox_Cavalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cavalo = (Cavalo)comboBox_Cavalo.SelectedItem;
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

        private void textBox_Valor_Apostado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor = double.Parse(textBox_Valor_Apostado.Text);
            }
            catch (Exception ex)
            {
                resultado_Cadastro.Text = ($"Valor inválido");
                resultado_Cadastro.Visible = true;
                textBox_Valor_Apostado.Text = "";
            }
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Valor_Apostado.Text))
            {
                resultado_Cadastro.Text = ("Valor em branco");
                resultado_Cadastro.Visible = true;
            }
            else
            {
                try
                {
                    // PARA REFAZER APÓS ALTERAÇÕES
                    
                    // Aposta.NovaAposta(_casa, cavalo, apostador, valor);
                    resultado_Cadastro.Text = ($"Aposta cadastrada com sucesso!");
                    resultado_Cadastro.Visible = true;
                }
                catch
                {
                    resultado_Cadastro.Text = ($"Não foi possível cadastrar a aposta!");
                    resultado_Cadastro.Visible = true;
                }
            }
        }
        private void button_Voltar_Click(object sender, EventArgs e)
        {
            _Inicial.Show();
            this.Close();
        }

        
    }
}
