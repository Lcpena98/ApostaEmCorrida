namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Cavalo
{
    partial class Menu_AlterarDados
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
            comboBox_Cavalos = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            panel8 = new Panel();
            button_Voltar = new Button();
            panel9 = new Panel();
            textBox_Raca = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            button_Alterar = new Button();
            panel5 = new Panel();
            textBox_PesoCavalo = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            textBox_AlturaCavalo = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            textBox_NomeCavalo = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 380);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox_Cavalos);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(4, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 45);
            panel2.TabIndex = 8;
            // 
            // comboBox_Cavalos
            // 
            comboBox_Cavalos.FormattingEnabled = true;
            comboBox_Cavalos.Location = new Point(60, 12);
            comboBox_Cavalos.Name = "comboBox_Cavalos";
            comboBox_Cavalos.Size = new Size(155, 23);
            comboBox_Cavalos.TabIndex = 1;
            comboBox_Cavalos.SelectedIndexChanged += comboBox_Cavalos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Cavalo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 8);
            label6.Name = "label6";
            label6.Size = new Size(172, 32);
            label6.TabIndex = 7;
            label6.Text = "Alterar Dados";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Voltar);
            panel8.Location = new Point(4, 336);
            panel8.Name = "panel8";
            panel8.Size = new Size(256, 41);
            panel8.TabIndex = 2;
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
            // panel9
            // 
            panel9.Controls.Add(textBox_Raca);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(3, 141);
            panel9.Name = "panel9";
            panel9.Size = new Size(260, 45);
            panel9.TabIndex = 6;
            // 
            // textBox_Raca
            // 
            textBox_Raca.Location = new Point(60, 12);
            textBox_Raca.Name = "textBox_Raca";
            textBox_Raca.Size = new Size(155, 23);
            textBox_Raca.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 15);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 0;
            label5.Text = "Raça:";
            // 
            // panel7
            // 
            panel7.Controls.Add(button_Alterar);
            panel7.Location = new Point(3, 289);
            panel7.Name = "panel7";
            panel7.Size = new Size(256, 41);
            panel7.TabIndex = 5;
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
            // panel5
            // 
            panel5.Controls.Add(textBox_PesoCavalo);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 243);
            panel5.Name = "panel5";
            panel5.Size = new Size(260, 45);
            panel5.TabIndex = 3;
            // 
            // textBox_PesoCavalo
            // 
            textBox_PesoCavalo.Location = new Point(60, 12);
            textBox_PesoCavalo.Name = "textBox_PesoCavalo";
            textBox_PesoCavalo.Size = new Size(155, 23);
            textBox_PesoCavalo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 15);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 0;
            label4.Text = "Peso:";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox_AlturaCavalo);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(4, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 45);
            panel4.TabIndex = 2;
            // 
            // textBox_AlturaCavalo
            // 
            textBox_AlturaCavalo.Location = new Point(60, 12);
            textBox_AlturaCavalo.Name = "textBox_AlturaCavalo";
            textBox_AlturaCavalo.Size = new Size(155, 23);
            textBox_AlturaCavalo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 15);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Altura:";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox_NomeCavalo);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 45);
            panel3.TabIndex = 0;
            // 
            // textBox_NomeCavalo
            // 
            textBox_NomeCavalo.Location = new Point(60, 15);
            textBox_NomeCavalo.Name = "textBox_NomeCavalo";
            textBox_NomeCavalo.Size = new Size(155, 23);
            textBox_NomeCavalo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 15);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // Menu_AlterarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 384);
            Controls.Add(panel1);
            Name = "Menu_AlterarDados";
            Text = "Menu_AlterarDados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel8;
        private Button button_Voltar;
        private Panel panel9;
        private TextBox textBox_Raca;
        private Label label5;
        private Panel panel7;
        private Label resultado_Alteracao;
        private Button button_Alterar;
        private Panel panel5;
        private TextBox textBox_PesoCavalo;
        private Label label4;
        private Panel panel4;
        private TextBox textBox_AlturaCavalo;
        private Label label3;
        private Panel panel3;
        private TextBox textBox_NomeCavalo;
        private Label label2;
        private Label label6;
        private Panel panel2;
        private ComboBox comboBox_Cavalos;
        private Label label1;
    }
}