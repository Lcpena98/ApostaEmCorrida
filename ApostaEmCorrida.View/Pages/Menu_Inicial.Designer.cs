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
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            button_Cadastro_Cavalo = new Button();
            label2 = new Label();
            button_Cadastro_Apostador = new Button();
            button_Registro_Aposta = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 453);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 52);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 8);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 0;
            label1.Text = "Central de Serviços";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
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
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Location = new Point(9, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(137, 34);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // button_Cadastro_Cavalo
            // 
            button_Cadastro_Cavalo.Location = new Point(6, 51);
            button_Cadastro_Cavalo.Name = "button_Cadastro_Cavalo";
            button_Cadastro_Cavalo.Size = new Size(131, 28);
            button_Cadastro_Cavalo.TabIndex = 0;
            button_Cadastro_Cavalo.Text = "Cadastrar Cavalo";
            button_Cadastro_Cavalo.UseVisualStyleBackColor = true;
            button_Cadastro_Cavalo.Click += button_Cadastro_Cavalo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 0;
            label2.Text = "Cadastro";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button_Cadastro_Apostador
            // 
            button_Cadastro_Apostador.Location = new Point(6, 92);
            button_Cadastro_Apostador.Name = "button_Cadastro_Apostador";
            button_Cadastro_Apostador.Size = new Size(131, 28);
            button_Cadastro_Apostador.TabIndex = 1;
            button_Cadastro_Apostador.Text = "Cadastrar Apostador";
            button_Cadastro_Apostador.UseVisualStyleBackColor = true;
            button_Cadastro_Apostador.Click += button_Cadastro_Apostador_Click;
            // 
            // button_Registro_Aposta
            // 
            button_Registro_Aposta.Location = new Point(5, 132);
            button_Registro_Aposta.Name = "button_Registro_Aposta";
            button_Registro_Aposta.Size = new Size(131, 28);
            button_Registro_Aposta.TabIndex = 2;
            button_Registro_Aposta.Text = "Registrar Aposta";
            button_Registro_Aposta.UseVisualStyleBackColor = true;
            button_Registro_Aposta.Click += button_Registro_Aposta_Click;
            // 
            // Menu_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 450);
            Controls.Add(panel1);
            Name = "Menu_Inicial";
            Text = "Menu_Inicial";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
    }
}