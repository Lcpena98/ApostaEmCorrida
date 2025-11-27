namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador
{
    partial class Menu_EsqueciSenha_Apostador
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
            panel10 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            button_voltar = new Button();
            panel9 = new Panel();
            textBox_NovaSenha = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            button_Gerar_Codigo = new Button();
            panel4 = new Panel();
            textBox_ConfirmaNovaSenha = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            textBox_Email = new TextBox();
            label1 = new Label();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Location = new Point(12, 12);
            panel10.Name = "panel10";
            panel10.Size = new Size(260, 57);
            panel10.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 14);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 1;
            label2.Text = "Recuperar Senha";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(12, 281);
            panel7.Name = "panel7";
            panel7.Size = new Size(261, 51);
            panel7.TabIndex = 26;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(65, 13);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(131, 28);
            button_voltar.TabIndex = 14;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(textBox_NovaSenha);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(12, 126);
            panel9.Name = "panel9";
            panel9.Size = new Size(260, 45);
            panel9.TabIndex = 31;
            // 
            // textBox_NovaSenha
            // 
            textBox_NovaSenha.Location = new Point(98, 12);
            textBox_NovaSenha.Name = "textBox_NovaSenha";
            textBox_NovaSenha.Size = new Size(155, 23);
            textBox_NovaSenha.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 15);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 0;
            label5.Text = "Nova Senha:";
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Gerar_Codigo);
            panel1.Location = new Point(12, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 47);
            panel1.TabIndex = 30;
            // 
            // button_Gerar_Codigo
            // 
            button_Gerar_Codigo.Location = new Point(59, 12);
            button_Gerar_Codigo.Name = "button_Gerar_Codigo";
            button_Gerar_Codigo.Size = new Size(142, 23);
            button_Gerar_Codigo.TabIndex = 0;
            button_Gerar_Codigo.Text = "Alterar";
            button_Gerar_Codigo.UseVisualStyleBackColor = true;
            button_Gerar_Codigo.Click += button_Gerar_Codigo_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox_ConfirmaNovaSenha);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(11, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 45);
            panel4.TabIndex = 29;
            // 
            // textBox_ConfirmaNovaSenha
            // 
            textBox_ConfirmaNovaSenha.Location = new Point(100, 12);
            textBox_ConfirmaNovaSenha.Name = "textBox_ConfirmaNovaSenha";
            textBox_ConfirmaNovaSenha.Size = new Size(155, 23);
            textBox_ConfirmaNovaSenha.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 15);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 0;
            label3.Text = "Confirmar Senha:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_Email);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 45);
            panel2.TabIndex = 32;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(56, 12);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(194, 23);
            textBox_Email.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // Menu_EsqueciSenha_Apostador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 335);
            Controls.Add(panel2);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel10);
            Controls.Add(panel7);
            Name = "Menu_EsqueciSenha_Apostador";
            Text = "Menu_EsqueciSenha_Apostador";
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Label label2;
        private Panel panel7;
        private Button button_voltar;
        private Panel panel9;
        private TextBox textBox_NovaSenha;
        private Label label5;
        private Panel panel1;
        private Button button_Gerar_Codigo;
        private Panel panel4;
        private TextBox textBox_ConfirmaNovaSenha;
        private Label label3;
        private Panel panel2;
        private TextBox textBox_Email;
        private Label label1;
    }
}