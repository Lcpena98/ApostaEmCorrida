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
    public partial class Menu_Cadastro_Apostador : Form
    {
        Menu_Inicial _Inicial;
        Casa _casa;
        string NomeApostador, EmailApostador, SenhaApostador,ConfirmaSenhaApostador;
        int Numero_Apostador;

        public Menu_Cadastro_Apostador(Menu_Inicial inicial, Casa casa)
        {
            InitializeComponent();
            _Inicial = inicial;
            _casa = casa;
        }

        private void textBox_NomeApostador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NomeApostador = textBox_NomeApostador.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox_EmailApostador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EmailApostador = textBox_EmailApostador.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox_SenhaApostador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SenhaApostador = textBox_SenhaApostador.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox_ConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfirmaSenhaApostador = textBox_ConfirmarSenha.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_Numero_Click(object sender, EventArgs e)
        {
            Numero_Apostador = Apostador.CriarNumero(_casa.Apostadores);

            label_Numero.Text = Numero_Apostador.ToString();
            label_Numero.Visible = true;
        }
        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_NomeApostador.Text) ||
            string.IsNullOrEmpty(textBox_EmailApostador.Text) ||
            string.IsNullOrEmpty(textBox_SenhaApostador.Text) ||
            string.IsNullOrEmpty(textBox_ConfirmarSenha.Text) ||
            string.IsNullOrEmpty(label_Numero.Text))
            {
                resultado_Cadastro.Text = "Favor Preencher os campos obrigatórios";
                resultado_Cadastro.Visible = true;

                resultado_Cadastro.Visible = true;
                textBox_NomeApostador.Text = "";
                textBox_EmailApostador.Text = "";
                textBox_SenhaApostador.Text = "";
                textBox_ConfirmarSenha.Text = "";
                label_Numero.Text = "";
                label_Numero.Visible = false;
            }
            else
            {

                if (SenhaApostador == ConfirmaSenhaApostador)
                {
                    try
                    {
                        Apostador.Cadastrar(_casa.Apostadores, NomeApostador, EmailApostador, SenhaApostador, Numero_Apostador);

                        resultado_Cadastro.Text = ($"Apostador cadastrado com sucesso!\nApostador: {NomeApostador} - {Numero_Apostador}");

                        resultado_Cadastro.Visible = true;
                        textBox_NomeApostador.Text = "";
                        textBox_EmailApostador.Text = "";
                        textBox_SenhaApostador.Text = "";
                        textBox_ConfirmarSenha.Text = "";
                        label_Numero.Text = "";
                        label_Numero.Visible = false;
                    }
                    catch
                    {
                        resultado_Cadastro.Text = "Não foi possível cadastrar o Apostador!";
                        resultado_Cadastro.Visible = true;

                        resultado_Cadastro.Visible = true;
                        textBox_NomeApostador.Text = "";
                        textBox_EmailApostador.Text = "";
                        textBox_SenhaApostador.Text = "";
                        textBox_ConfirmarSenha.Text = "";
                        label_Numero.Text = "";
                        label_Numero.Visible = false;
                    }
                }
                else
                {
                    resultado_Cadastro.Text = "A senha deve ser igual ao confirmar senha";
                    resultado_Cadastro.Visible = true;

                    resultado_Cadastro.Visible = true;
                    textBox_NomeApostador.Text = "";
                    textBox_EmailApostador.Text = "";
                    textBox_SenhaApostador.Text = "";
                    textBox_ConfirmarSenha.Text = "";
                    label_Numero.Text = "";
                    label_Numero.Visible = false;
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
