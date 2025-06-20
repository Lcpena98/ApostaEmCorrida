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
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            textBox_NomeCavalo = new TextBox();
            panel4 = new Panel();
            textBox_AlturaCavalo = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            textBox_PesoCavalo = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 448);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(5, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 54);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 7);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 0;
            label1.Text = "Central de Serviços";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox_NomeCavalo);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 45);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 15);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // textBox_NomeCavalo
            // 
            textBox_NomeCavalo.Location = new Point(60, 12);
            textBox_NomeCavalo.Name = "textBox_NomeCavalo";
            textBox_NomeCavalo.Size = new Size(155, 23);
            textBox_NomeCavalo.TabIndex = 1;
            textBox_NomeCavalo.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox_AlturaCavalo);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 45);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // textBox_AlturaCavalo
            // 
            textBox_AlturaCavalo.Location = new Point(60, 12);
            textBox_AlturaCavalo.Name = "textBox_AlturaCavalo";
            textBox_AlturaCavalo.Size = new Size(155, 23);
            textBox_AlturaCavalo.TabIndex = 1;
            textBox_AlturaCavalo.TextChanged += textBox_AlturaCavalo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 15);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Altura:";
            label3.Click += label3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_PesoCavalo);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 162);
            panel5.Name = "panel5";
            panel5.Size = new Size(260, 45);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // textBox_PesoCavalo
            // 
            textBox_PesoCavalo.Location = new Point(60, 12);
            textBox_PesoCavalo.Name = "textBox_PesoCavalo";
            textBox_PesoCavalo.Size = new Size(155, 23);
            textBox_PesoCavalo.TabIndex = 1;
            textBox_PesoCavalo.TextChanged += textBox_PesoCavalo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 15);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 0;
            label4.Text = "Peso:";
            label4.Click += label4_Click;
            // 
            // Menu_Cadastro_Cavalo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Menu_Cadastro_Cavalo";
            Text = "Menu_Cadastro_Cavalo";
            Load += Menu_Cadastro_Cavalo_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private TextBox textBox_NomeCavalo;
        private Panel panel4;
        private TextBox textBox_AlturaCavalo;
        private Label label3;
        private Panel panel5;
        private TextBox textBox_PesoCavalo;
        private Label label4;
    }
}