namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador
{
    partial class Menu_Apostador
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
            panel7 = new Panel();
            button_voltar = new Button();
            panel8 = new Panel();
            button_Alterar_Aposta = new Button();
            butto_alterar_aposta = new Button();
            panel9 = new Panel();
            button_alterar_dados = new Button();
            button_trocar_senha = new Button();
            panel10 = new Panel();
            label2 = new Label();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(6, 195);
            panel7.Name = "panel7";
            panel7.Size = new Size(343, 60);
            panel7.TabIndex = 23;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(104, 24);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(131, 28);
            button_voltar.TabIndex = 14;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Alterar_Aposta);
            panel8.Controls.Add(butto_alterar_aposta);
            panel8.Location = new Point(6, 135);
            panel8.Name = "panel8";
            panel8.Size = new Size(343, 54);
            panel8.TabIndex = 22;
            // 
            // button_Alterar_Aposta
            // 
            button_Alterar_Aposta.Location = new Point(3, 14);
            button_Alterar_Aposta.Name = "button_Alterar_Aposta";
            button_Alterar_Aposta.Size = new Size(131, 28);
            button_Alterar_Aposta.TabIndex = 9;
            button_Alterar_Aposta.Text = "Fazer uma aposta";
            button_Alterar_Aposta.UseVisualStyleBackColor = true;
            // 
            // butto_alterar_aposta
            // 
            butto_alterar_aposta.Location = new Point(180, 14);
            butto_alterar_aposta.Name = "butto_alterar_aposta";
            butto_alterar_aposta.Size = new Size(131, 28);
            butto_alterar_aposta.TabIndex = 6;
            butto_alterar_aposta.Text = "Alterar Aposta";
            butto_alterar_aposta.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(button_alterar_dados);
            panel9.Controls.Add(button_trocar_senha);
            panel9.Location = new Point(6, 75);
            panel9.Name = "panel9";
            panel9.Size = new Size(339, 54);
            panel9.TabIndex = 21;
            // 
            // button_alterar_dados
            // 
            button_alterar_dados.Location = new Point(3, 14);
            button_alterar_dados.Name = "button_alterar_dados";
            button_alterar_dados.Size = new Size(131, 28);
            button_alterar_dados.TabIndex = 9;
            button_alterar_dados.Text = "Alterar dados";
            button_alterar_dados.UseVisualStyleBackColor = true;
            button_alterar_dados.Click += button_alterar_dados_Click;
            // 
            // button_trocar_senha
            // 
            button_trocar_senha.Location = new Point(176, 14);
            button_trocar_senha.Name = "button_trocar_senha";
            button_trocar_senha.Size = new Size(131, 28);
            button_trocar_senha.TabIndex = 6;
            button_trocar_senha.Text = "Trocar Senha";
            button_trocar_senha.UseVisualStyleBackColor = true;
            button_trocar_senha.Click += button_trocar_senha_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Location = new Point(3, 12);
            panel10.Name = "panel10";
            panel10.Size = new Size(339, 57);
            panel10.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 14);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 1;
            label2.Text = "Apostador";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu_Apostador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 268);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel10);
            Name = "Menu_Apostador";
            Text = "Menu_Apostador";
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button button_voltar;
        private Panel panel8;
        private Button button_Alterar_Aposta;
        private Button butto_alterar_aposta;
        private Panel panel9;
        private Button button_alterar_dados;
        private Button button_trocar_senha;
        private Panel panel10;
        private Label label2;
    }
}