namespace ApostaEmCorrida.View.Pages
{
    partial class Menu_Cadastro_Cavalo
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
            panel7 = new Panel();
            button_Cadastrar = new Button();
            panel6 = new Panel();
            button_Numero = new Button();
            label_Numero = new Label();
            panel5 = new Panel();
            textBox_PesoCavalo = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            textBox_AlturaCavalo = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            textBox_NomeCavalo = new TextBox();
            label2 = new Label();
            resultado_Cadastro = new Label();
            button_Voltar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel8 = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 317);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_Cadastrar);
            panel7.Location = new Point(3, 264);
            panel7.Name = "panel7";
            panel7.Size = new Size(256, 106);
            panel7.TabIndex = 5;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Location = new Point(94, 3);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 0;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button_Numero);
            panel6.Controls.Add(label_Numero);
            panel6.Location = new Point(3, 213);
            panel6.Name = "panel6";
            panel6.Size = new Size(260, 45);
            panel6.TabIndex = 4;
            // 
            // button_Numero
            // 
            button_Numero.Location = new Point(7, 13);
            button_Numero.Name = "button_Numero";
            button_Numero.Size = new Size(92, 23);
            button_Numero.TabIndex = 1;
            button_Numero.Text = "Gerar Numero";
            button_Numero.UseVisualStyleBackColor = true;
            button_Numero.Click += button_Numero_Click;
            // 
            // label_Numero
            // 
            label_Numero.AutoSize = true;
            label_Numero.BorderStyle = BorderStyle.FixedSingle;
            label_Numero.Location = new Point(115, 17);
            label_Numero.MaximumSize = new Size(100, 15);
            label_Numero.MinimumSize = new Size(100, 15);
            label_Numero.Name = "label_Numero";
            label_Numero.Size = new Size(100, 15);
            label_Numero.TabIndex = 0;
            label_Numero.TextAlign = ContentAlignment.MiddleCenter;
            label_Numero.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_PesoCavalo);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 162);
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
            textBox_PesoCavalo.TextChanged += textBox_PesoCavalo_TextChanged;
            textBox_PesoCavalo.KeyPress += TextBox_PesoCavalo_KeyPress;
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
            panel4.Location = new Point(3, 111);
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
            textBox_AlturaCavalo.TextChanged += textBox_AlturaCavalo_TextChanged;
            textBox_AlturaCavalo.KeyPress += TextBox_AlturaCavalo_KeyPress;
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
            panel3.Location = new Point(3, 60);
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
            textBox_NomeCavalo.TextChanged += textBox_NomeCavalo_TextChanged;
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
            // resultado_Cadastro
            // 
            resultado_Cadastro.AutoSize = true;
            resultado_Cadastro.BorderStyle = BorderStyle.Fixed3D;
            resultado_Cadastro.Location = new Point(12, 295);
            resultado_Cadastro.MaximumSize = new Size(240, 60);
            resultado_Cadastro.MinimumSize = new Size(240, 60);
            resultado_Cadastro.Name = "resultado_Cadastro";
            resultado_Cadastro.Size = new Size(240, 60);
            resultado_Cadastro.TabIndex = 1;
            resultado_Cadastro.TextAlign = ContentAlignment.MiddleCenter;
            resultado_Cadastro.Visible = false;
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
            panel2.Controls.Add(label1);
            panel2.Location = new Point(5, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 54);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cavalos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Voltar);
            panel8.Location = new Point(5, 371);
            panel8.Name = "panel8";
            panel8.Size = new Size(256, 41);
            panel8.TabIndex = 2;
            // 
            // Menu_Cadastro_Cavalo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 413);
            Controls.Add(resultado_Cadastro);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Menu_Cadastro_Cavalo";
            Text = "Menu_Cadastro_Cavalo";
            Load += Menu_Cadastro_Cavalo_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private TextBox textBox_AlturaCavalo;
        private Label label3;
        private Panel panel5;
        private TextBox textBox_PesoCavalo;
        private Label label4;
        private TextBox textBox_NomeCavalo;
        private Panel panel6;
        private Label label_Numero;
        private Button button_Numero;
        private Panel panel7;
        private Button button_Voltar;
        private Button button_Cadastrar;
        private Label resultado_Cadastro;
        private Panel panel8;
    }
}