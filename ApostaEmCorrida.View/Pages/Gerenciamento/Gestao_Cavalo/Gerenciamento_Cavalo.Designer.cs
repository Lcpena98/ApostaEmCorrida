namespace ApostaEmCorrida.View.Pages.Gestao_Cavalo
{
    partial class Gerenciamento_Cavalo
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button_Alterar_Dados = new Button();
            button_Cadastro_Cavalo = new Button();
            panel4 = new Panel();
            button_Voltar = new Button();
            button_Excluir_Cavalo = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 57);
            panel1.TabIndex = 0;
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
            // panel2
            // 
            panel2.Controls.Add(button_Excluir_Cavalo);
            panel2.Controls.Add(button_Alterar_Dados);
            panel2.Controls.Add(button_Cadastro_Cavalo);
            panel2.Location = new Point(-1, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 164);
            panel2.TabIndex = 1;
            // 
            // button_Alterar_Dados
            // 
            button_Alterar_Dados.Location = new Point(59, 61);
            button_Alterar_Dados.Name = "button_Alterar_Dados";
            button_Alterar_Dados.Size = new Size(131, 28);
            button_Alterar_Dados.TabIndex = 7;
            button_Alterar_Dados.Text = "Alterar dados";
            button_Alterar_Dados.UseVisualStyleBackColor = true;
            button_Alterar_Dados.Click += button_Alterar_Dados_Click;
            // 
            // button_Cadastro_Cavalo
            // 
            button_Cadastro_Cavalo.Location = new Point(59, 13);
            button_Cadastro_Cavalo.Name = "button_Cadastro_Cavalo";
            button_Cadastro_Cavalo.Size = new Size(131, 28);
            button_Cadastro_Cavalo.TabIndex = 6;
            button_Cadastro_Cavalo.Text = "Cadastrar Cavalo";
            button_Cadastro_Cavalo.UseVisualStyleBackColor = true;
            button_Cadastro_Cavalo.Click += button_Cadastro_Cavalo_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button_Voltar);
            panel4.Location = new Point(-1, 233);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 60);
            panel4.TabIndex = 3;
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
            // button_Excluir_Cavalo
            // 
            button_Excluir_Cavalo.Location = new Point(59, 113);
            button_Excluir_Cavalo.Size = new Size(131, 28);
            button_Excluir_Cavalo.TabIndex = 8;
            button_Excluir_Cavalo.Text = "Excluir Cavalo";
            button_Excluir_Cavalo.UseVisualStyleBackColor = true;
            button_Excluir_Cavalo.Click += button_Excluir_Cavalo_Click;
            // 
            // Gerenciamento_Cavalo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 291);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Gerenciamento_Cavalo";
            Text = "Gerenciamento_Cavalo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button_Alterar_Dados;
        private Button button_Cadastro_Cavalo;
        private Panel panel4;
        private Button button_Voltar;
        private Button button_Excluir_Cavalo;
    }
}