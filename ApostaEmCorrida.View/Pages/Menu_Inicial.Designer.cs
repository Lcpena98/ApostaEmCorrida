namespace ApostaEmCorrida.View.Pages
{
    partial class Menu_Inicial
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
            button_Sair = new Button();
            panel3 = new Panel();
            button_Cadastro_Apostador = new Button();
            button_Cadastro_Cavalo = new Button();
            button_Corrida = new Button();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button_Dados_Cavalos = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Sair);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 258);
            panel1.TabIndex = 0;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(76, 225);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(130, 23);
            button_Sair.TabIndex = 6;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Dados_Cavalos);
            panel3.Controls.Add(button_Cadastro_Apostador);
            panel3.Controls.Add(button_Cadastro_Cavalo);
            panel3.Controls.Add(button_Corrida);
            panel3.Location = new Point(6, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 140);
            panel3.TabIndex = 1;
            // 
            // button_Cadastro_Apostador
            // 
            button_Cadastro_Apostador.Location = new Point(6, 18);
            button_Cadastro_Apostador.Name = "button_Cadastro_Apostador";
            button_Cadastro_Apostador.Size = new Size(131, 28);
            button_Cadastro_Apostador.TabIndex = 1;
            button_Cadastro_Apostador.Text = "Gerenciar Apostador";
            button_Cadastro_Apostador.UseVisualStyleBackColor = true;
            button_Cadastro_Apostador.Click += button_Cadastro_Apostador_Click;
            // 
            // button_Cadastro_Cavalo
            // 
            button_Cadastro_Cavalo.Location = new Point(151, 18);
            button_Cadastro_Cavalo.Name = "button_Cadastro_Cavalo";
            button_Cadastro_Cavalo.Size = new Size(131, 28);
            button_Cadastro_Cavalo.TabIndex = 0;
            button_Cadastro_Cavalo.Text = "Gerenciar Cavalos";
            button_Cadastro_Cavalo.UseVisualStyleBackColor = true;
            button_Cadastro_Cavalo.Click += button_Cadastro_Cavalo_Click;
            // 
            // button_Corrida
            // 
            button_Corrida.Location = new Point(7, 84);
            button_Corrida.Name = "button_Corrida";
            button_Corrida.Size = new Size(130, 23);
            button_Corrida.TabIndex = 5;
            button_Corrida.Text = "Gerenciar Corridas";
            button_Corrida.UseVisualStyleBackColor = true;
            button_Corrida.Click += button_Corrida_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 52);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 8);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 0;
            label1.Text = "Central de Serviços";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Dados_Cavalos
            // 
            button_Dados_Cavalos.Location = new Point(151, 81);
            button_Dados_Cavalos.Name = "button_Dados_Cavalos";
            button_Dados_Cavalos.Size = new Size(131, 28);
            button_Dados_Cavalos.TabIndex = 0;
            button_Dados_Cavalos.Text = "Dados dos Cavalos";
            button_Dados_Cavalos.UseVisualStyleBackColor = true;
            button_Dados_Cavalos.Click += button_Dados_Cavalos_Click;
            // 
            // Menu_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 258);
            Controls.Add(panel1);
            Name = "Menu_Inicial";
            Text = "Menu_Inicial";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button button2;
        private Button button_Cadastro_Cavalo;
        private Panel panel2;
        private Label label1;
        private Button button_Cadastro_Apostador;
        private Button button_Corridas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button_Corrida;
        private Button button_Sair;
        private Button button_Dados_Cavalos;
    }
}