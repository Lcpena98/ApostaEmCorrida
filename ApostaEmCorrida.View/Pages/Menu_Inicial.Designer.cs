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
            label_Resultado_Corrida = new Label();
            button_Sair = new Button();
            button_Nova_Corrida = new Button();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            button_Documentos = new Button();
            button_Corridas = new Button();
            button_Dados_Cadastrados = new Button();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            button_Registro_Aposta = new Button();
            button_Cadastro_Apostador = new Button();
            button_Cadastro_Cavalo = new Button();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label_Resultado_Corrida);
            panel1.Controls.Add(button_Sair);
            panel1.Controls.Add(button_Nova_Corrida);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 321);
            panel1.TabIndex = 0;
            // 
            // label_Resultado_Corrida
            // 
            label_Resultado_Corrida.AutoSize = true;
            label_Resultado_Corrida.BorderStyle = BorderStyle.Fixed3D;
            label_Resultado_Corrida.Location = new Point(12, 275);
            label_Resultado_Corrida.MaximumSize = new Size(280, 31);
            label_Resultado_Corrida.MinimumSize = new Size(280, 31);
            label_Resultado_Corrida.Name = "label_Resultado_Corrida";
            label_Resultado_Corrida.Size = new Size(280, 31);
            label_Resultado_Corrida.TabIndex = 7;
            label_Resultado_Corrida.TextAlign = ContentAlignment.MiddleCenter;
            label_Resultado_Corrida.Visible = false;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(161, 240);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(130, 23);
            button_Sair.TabIndex = 6;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // button_Nova_Corrida
            // 
            button_Nova_Corrida.Location = new Point(12, 240);
            button_Nova_Corrida.Name = "button_Nova_Corrida";
            button_Nova_Corrida.Size = new Size(130, 23);
            button_Nova_Corrida.TabIndex = 5;
            button_Nova_Corrida.Text = "Nova Corrida";
            button_Nova_Corrida.UseVisualStyleBackColor = true;
            button_Nova_Corrida.Click += button_Nova_Corrida_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Location = new Point(161, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(137, 34);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 4);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 0;
            label3.Text = "Dados";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(button_Documentos);
            panel6.Controls.Add(button_Corridas);
            panel6.Controls.Add(button_Dados_Cadastrados);
            panel6.Location = new Point(158, 61);
            panel6.Name = "panel6";
            panel6.Size = new Size(140, 173);
            panel6.TabIndex = 3;
            // 
            // button_Documentos
            // 
            button_Documentos.Location = new Point(5, 132);
            button_Documentos.Name = "button_Documentos";
            button_Documentos.Size = new Size(131, 28);
            button_Documentos.TabIndex = 2;
            button_Documentos.Text = "Documentos";
            button_Documentos.UseVisualStyleBackColor = true;
            button_Documentos.Click += button_Documentos_Click;
            // 
            // button_Corridas
            // 
            button_Corridas.Location = new Point(6, 92);
            button_Corridas.Name = "button_Corridas";
            button_Corridas.Size = new Size(131, 28);
            button_Corridas.TabIndex = 1;
            button_Corridas.Text = "Corridas";
            button_Corridas.UseVisualStyleBackColor = true;
            button_Corridas.Click += button_Corridas_Click;
            // 
            // button_Dados_Cadastrados
            // 
            button_Dados_Cadastrados.Location = new Point(6, 51);
            button_Dados_Cadastrados.Name = "button_Dados_Cadastrados";
            button_Dados_Cadastrados.Size = new Size(131, 28);
            button_Dados_Cadastrados.TabIndex = 0;
            button_Dados_Cadastrados.Text = "Dados Cadastrados";
            button_Dados_Cadastrados.UseVisualStyleBackColor = true;
            button_Dados_Cadastrados.Click += button_Dados_Cadastrados_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Location = new Point(9, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(137, 34);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 0;
            label2.Text = "Gerenciar";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Registro_Aposta);
            panel3.Controls.Add(button_Cadastro_Apostador);
            panel3.Controls.Add(button_Cadastro_Cavalo);
            panel3.Location = new Point(6, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 173);
            panel3.TabIndex = 1;
            // 
            // button_Registro_Aposta
            // 
            button_Registro_Aposta.Location = new Point(5, 132);
            button_Registro_Aposta.Name = "button_Registro_Aposta";
            button_Registro_Aposta.Size = new Size(131, 28);
            button_Registro_Aposta.TabIndex = 2;
            button_Registro_Aposta.Text = "Aposta";
            button_Registro_Aposta.UseVisualStyleBackColor = true;
            button_Registro_Aposta.Click += button_Registro_Aposta_Click;
            // 
            // button_Cadastro_Apostador
            // 
            button_Cadastro_Apostador.Location = new Point(6, 92);
            button_Cadastro_Apostador.Name = "button_Cadastro_Apostador";
            button_Cadastro_Apostador.Size = new Size(131, 28);
            button_Cadastro_Apostador.TabIndex = 1;
            button_Cadastro_Apostador.Text = "Apostador";
            button_Cadastro_Apostador.UseVisualStyleBackColor = true;
            button_Cadastro_Apostador.Click += button_Cadastro_Apostador_Click;
            // 
            // button_Cadastro_Cavalo
            // 
            button_Cadastro_Cavalo.Location = new Point(6, 51);
            button_Cadastro_Cavalo.Name = "button_Cadastro_Cavalo";
            button_Cadastro_Cavalo.Size = new Size(131, 28);
            button_Cadastro_Cavalo.TabIndex = 0;
            button_Cadastro_Cavalo.Text = "Cavalo";
            button_Cadastro_Cavalo.UseVisualStyleBackColor = true;
            button_Cadastro_Cavalo.Click += button_Cadastro_Cavalo_Click;
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
            // Menu_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 322);
            Controls.Add(panel1);
            Name = "Menu_Inicial";
            Text = "Menu_Inicial";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label2;
        private Panel panel3;
        private Button button2;
        private Button button_Cadastro_Cavalo;
        private Panel panel2;
        private Label label1;
        private Button button_Registro_Aposta;
        private Button button_Cadastro_Apostador;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private Button button_Documentos;
        private Button button_Corridas;
        private Button button_Dados_Cadastrados;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button_Nova_Corrida;
        private Button button_Sair;
        private Label label_Resultado_Corrida;
    }
}