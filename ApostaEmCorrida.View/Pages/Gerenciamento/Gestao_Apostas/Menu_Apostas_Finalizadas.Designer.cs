namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostas
{
    partial class Menu_Apostas_Finalizadas
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
            panel2 = new Panel();
            label1 = new Label();
            panel8 = new Panel();
            button_Voltar = new Button();
            panel1 = new Panel();
            dataGridView_Apostas = new DataGridView();
            panel3 = new Panel();
            button_Validar_Apostas = new Button();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Apostas).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 54);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 12);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Apostas Finalizadas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Voltar);
            panel8.Location = new Point(0, 341);
            panel8.Name = "panel8";
            panel8.Size = new Size(356, 41);
            panel8.TabIndex = 8;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(137, 7);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 1;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_Apostas);
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 223);
            panel1.TabIndex = 9;
            // 
            // dataGridView_Apostas
            // 
            dataGridView_Apostas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Apostas.Location = new Point(6, 13);
            dataGridView_Apostas.Name = "dataGridView_Apostas";
            dataGridView_Apostas.Size = new Size(343, 184);
            dataGridView_Apostas.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Validar_Apostas);
            panel3.Location = new Point(0, 301);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 39);
            panel3.TabIndex = 11;
            // 
            // button_Validar_Apostas
            // 
            button_Validar_Apostas.Location = new Point(85, 9);
            button_Validar_Apostas.Name = "button_Validar_Apostas";
            button_Validar_Apostas.Size = new Size(180, 23);
            button_Validar_Apostas.TabIndex = 1;
            button_Validar_Apostas.Text = "Validar Aposta";
            button_Validar_Apostas.UseVisualStyleBackColor = true;
            button_Validar_Apostas.Click += button_Validar_Apostas_Click;
            // 
            // Menu_Apostas_Finalizadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 388);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Name = "Menu_Apostas_Finalizadas";
            Text = "Menu_Apostas_Finalizadas";
            Activated += Recarregar_Lista;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Apostas).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel8;
        private Button button_Voltar;
        private Panel panel1;
        private DataGridView dataGridView_Apostas;
        private Panel panel3;
        private Button button_Validar_Apostas;
    }
}