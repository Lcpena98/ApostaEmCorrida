namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador
{
    partial class Menu_AlterarDados_Apostador
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
            panel9 = new Panel();
            textBox_AlterarEmail_Apostador = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            button_Alterar = new Button();
            panel3 = new Panel();
            textBox_AlterarNome_Apostador = new TextBox();
            label4 = new Label();
            panel10 = new Panel();
            label6 = new Label();
            label_Dados_Usuario = new Label();
            button_voltar = new Button();
            panel7 = new Panel();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.Controls.Add(textBox_AlterarEmail_Apostador);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(0, 159);
            panel9.Name = "panel9";
            panel9.Size = new Size(260, 45);
            panel9.TabIndex = 41;
            // 
            // textBox_AlterarEmail_Apostador
            // 
            textBox_AlterarEmail_Apostador.Location = new Point(98, 12);
            textBox_AlterarEmail_Apostador.Name = "textBox_AlterarEmail_Apostador";
            textBox_AlterarEmail_Apostador.Size = new Size(155, 23);
            textBox_AlterarEmail_Apostador.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 15);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Alterar);
            panel1.Location = new Point(0, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 32);
            panel1.TabIndex = 40;
            // 
            // button_Alterar
            // 
            button_Alterar.Location = new Point(94, 3);
            button_Alterar.Name = "button_Alterar";
            button_Alterar.Size = new Size(75, 23);
            button_Alterar.TabIndex = 0;
            button_Alterar.Text = "Alterar";
            button_Alterar.UseVisualStyleBackColor = true;
            button_Alterar.Click += button_Alterar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox_AlterarNome_Apostador);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 45);
            panel3.TabIndex = 39;
            // 
            // textBox_AlterarNome_Apostador
            // 
            textBox_AlterarNome_Apostador.Location = new Point(98, 12);
            textBox_AlterarNome_Apostador.Name = "textBox_AlterarNome_Apostador";
            textBox_AlterarNome_Apostador.Size = new Size(155, 23);
            textBox_AlterarNome_Apostador.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 15);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 0;
            label4.Text = "Nome:";
            // 
            // panel10
            // 
            panel10.Controls.Add(label6);
            panel10.Controls.Add(label_Dados_Usuario);
            panel10.Location = new Point(1, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(260, 108);
            panel10.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 8);
            label6.Name = "label6";
            label6.Size = new Size(172, 32);
            label6.TabIndex = 8;
            label6.Text = "Alterar Dados";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Dados_Usuario
            // 
            label_Dados_Usuario.AutoSize = true;
            label_Dados_Usuario.BorderStyle = BorderStyle.FixedSingle;
            label_Dados_Usuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Dados_Usuario.Location = new Point(29, 54);
            label_Dados_Usuario.MaximumSize = new Size(205, 32);
            label_Dados_Usuario.MinimumSize = new Size(205, 32);
            label_Dados_Usuario.Name = "label_Dados_Usuario";
            label_Dados_Usuario.Size = new Size(205, 32);
            label_Dados_Usuario.TabIndex = 4;
            label_Dados_Usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(64, 16);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(131, 28);
            button_voltar.TabIndex = 14;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(1, 248);
            panel7.Name = "panel7";
            panel7.Size = new Size(260, 60);
            panel7.TabIndex = 37;
            // 
            // Menu_AlterarDados_Apostador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 314);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel10);
            Controls.Add(panel7);
            Name = "Menu_AlterarDados_Apostador";
            Text = "Menu_AlterarDados_Apostador";
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private TextBox textBox_AlterarEmail_Apostador;
        private Label label5;
        private Panel panel1;
        private Button button_Alterar;
        private Panel panel3;
        private TextBox textBox_AlterarNome_Apostador;
        private Label label4;
        private Panel panel10;
        private Label label_Dados_Usuario;
        private Button button_voltar;
        private Panel panel7;
        private Label label6;
    }
}