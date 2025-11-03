namespace ApostaEmCorrida.View.Pages
{
    partial class Menu_Registro_Aposta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultado_Cadastro = new Label();
            panel8 = new Panel();
            button_Voltar = new Button();
            panel2 = new Panel();
            label_Dados_Usuario = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel7 = new Panel();
            button_Registrar = new Button();
            panel5 = new Panel();
            textBox_Valor_Apostado = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            comboBox_Cavalo = new ComboBox();
            label3 = new Label();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // resultado_Cadastro
            // 
            resultado_Cadastro.AutoSize = true;
            resultado_Cadastro.BorderStyle = BorderStyle.Fixed3D;
            resultado_Cadastro.Location = new Point(7, 29);
            resultado_Cadastro.MaximumSize = new Size(240, 60);
            resultado_Cadastro.MinimumSize = new Size(240, 60);
            resultado_Cadastro.Name = "resultado_Cadastro";
            resultado_Cadastro.Size = new Size(240, 60);
            resultado_Cadastro.TabIndex = 4;
            resultado_Cadastro.TextAlign = ContentAlignment.MiddleCenter;
            resultado_Cadastro.Visible = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Voltar);
            panel8.Location = new Point(4, 336);
            panel8.Name = "panel8";
            panel8.Size = new Size(259, 41);
            panel8.TabIndex = 6;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(94, 7);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 1;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label_Dados_Usuario);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 116);
            panel2.TabIndex = 5;
            // 
            // label_Dados_Usuario
            // 
            label_Dados_Usuario.AutoSize = true;
            label_Dados_Usuario.BorderStyle = BorderStyle.FixedSingle;
            label_Dados_Usuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Dados_Usuario.Location = new Point(26, 57);
            label_Dados_Usuario.MaximumSize = new Size(205, 32);
            label_Dados_Usuario.MinimumSize = new Size(205, 32);
            label_Dados_Usuario.Name = "label_Dados_Usuario";
            label_Dados_Usuario.Size = new Size(205, 32);
            label_Dados_Usuario.TabIndex = 5;
            label_Dados_Usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de Apostas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 384);
            panel1.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(resultado_Cadastro);
            panel7.Controls.Add(button_Registrar);
            panel7.Location = new Point(4, 224);
            panel7.Name = "panel7";
            panel7.Size = new Size(256, 106);
            panel7.TabIndex = 5;
            // 
            // button_Registrar
            // 
            button_Registrar.Location = new Point(94, 3);
            button_Registrar.Name = "button_Registrar";
            button_Registrar.Size = new Size(75, 23);
            button_Registrar.TabIndex = 0;
            button_Registrar.Text = "Registrar";
            button_Registrar.UseVisualStyleBackColor = true;
            button_Registrar.Click += button_Registrar_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_Valor_Apostado);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 173);
            panel5.Name = "panel5";
            panel5.Size = new Size(260, 45);
            panel5.TabIndex = 3;
            // 
            // textBox_Valor_Apostado
            // 
            textBox_Valor_Apostado.Location = new Point(107, 12);
            textBox_Valor_Apostado.Name = "textBox_Valor_Apostado";
            textBox_Valor_Apostado.Size = new Size(100, 23);
            textBox_Valor_Apostado.TabIndex = 1;
            textBox_Valor_Apostado.KeyPress += TextBox_Valor_Apostado_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 15);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 0;
            label4.Text = "Valor Apostado:";
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox_Cavalo);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 45);
            panel4.TabIndex = 2;
            // 
            // comboBox_Cavalo
            // 
            comboBox_Cavalo.FormattingEnabled = true;
            comboBox_Cavalo.Location = new Point(76, 12);
            comboBox_Cavalo.Name = "comboBox_Cavalo";
            comboBox_Cavalo.Size = new Size(177, 23);
            comboBox_Cavalo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 15);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Cavalo:";
            // 
            // Menu_Registro_Aposta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 389);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Menu_Registro_Aposta";
            Text = "Menu_Registro_Aposta";
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        private void ComboBox_Apostador_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label resultado_Cadastro;
        private Panel panel8;
        private Button button_Voltar;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel7;
        private Button button_Registrar;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Label label3;
        private ComboBox comboBox_Cavalo;
        private TextBox textBox_Valor_Apostado;
        private Label label_Dados_Usuario;
    }
}