namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador
{
    partial class Gerenciamento_Apostador
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
            panel4 = new Panel();
            button_Voltar = new Button();
            panel2 = new Panel();
            button_trocar_senha = new Button();
            button_Excluir_Apostador = new Button();
            button_Alterar_Dados = new Button();
            button_Cadastro_Apostador = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(button_Voltar);
            panel4.Location = new Point(13, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 60);
            panel4.TabIndex = 6;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(59, 19);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(131, 28);
            button_Voltar.TabIndex = 14;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_trocar_senha);
            panel2.Controls.Add(button_Excluir_Apostador);
            panel2.Controls.Add(button_Alterar_Dados);
            panel2.Controls.Add(button_Cadastro_Apostador);
            panel2.Location = new Point(12, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 194);
            panel2.TabIndex = 5;
            // 
            // button_trocar_senha
            // 
            button_trocar_senha.Location = new Point(59, 58);
            button_trocar_senha.Name = "button_trocar_senha";
            button_trocar_senha.Size = new Size(131, 28);
            button_trocar_senha.TabIndex = 9;
            button_trocar_senha.Text = "Trocar Senha";
            button_trocar_senha.UseVisualStyleBackColor = true;
            // 
            // button_Excluir_Apostador
            // 
            button_Excluir_Apostador.Location = new Point(59, 144);
            button_Excluir_Apostador.Name = "button_Excluir_Apostador";
            button_Excluir_Apostador.Size = new Size(131, 28);
            button_Excluir_Apostador.TabIndex = 8;
            button_Excluir_Apostador.Text = "Excluir Apostador";
            button_Excluir_Apostador.UseVisualStyleBackColor = true;
            // 
            // button_Alterar_Dados
            // 
            button_Alterar_Dados.Location = new Point(59, 101);
            button_Alterar_Dados.Name = "button_Alterar_Dados";
            button_Alterar_Dados.Size = new Size(131, 28);
            button_Alterar_Dados.TabIndex = 7;
            button_Alterar_Dados.Text = "Alterar dados";
            button_Alterar_Dados.UseVisualStyleBackColor = true;
            // 
            // button_Cadastro_Apostador
            // 
            button_Cadastro_Apostador.Location = new Point(59, 13);
            button_Cadastro_Apostador.Name = "button_Cadastro_Apostador";
            button_Cadastro_Apostador.Size = new Size(131, 28);
            button_Cadastro_Apostador.TabIndex = 6;
            button_Cadastro_Apostador.Text = "Cadastrar Apostador";
            button_Cadastro_Apostador.UseVisualStyleBackColor = true;
            button_Cadastro_Apostador.Click += button_Cadastro_Apostador_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 57);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 1;
            label1.Text = "Gerenciamento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Gerenciamento_Apostador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 347);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Gerenciamento_Apostador";
            Text = "Gerenciamento_Apostador";
            Load += Gerenciamento_Apostador_Load;
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Button button_Voltar;
        private Panel panel2;
        private Button button_Excluir_Apostador;
        private Button button_Alterar_Dados;
        private Button button_Cadastro_Apostador;
        private Panel panel1;
        private Label label1;
        private Button button_trocar_senha;
    }
}