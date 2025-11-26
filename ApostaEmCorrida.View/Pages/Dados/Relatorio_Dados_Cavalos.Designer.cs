namespace ApostaEmCorrida.View.Pages.Dados
{
    partial class Relatorio_Dados_Cavalos
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
            panel1 = new Panel();
            dataGridView_Cavalos = new DataGridView();
            button_Sair = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cavalos).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 52);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 10);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 0;
            label1.Text = "Cavalos Cadastrados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_Cavalos);
            panel1.Controls.Add(button_Sair);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 582);
            panel1.TabIndex = 2;
            // 
            // dataGridView_Cavalos
            // 
            dataGridView_Cavalos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Cavalos.Location = new Point(3, 61);
            dataGridView_Cavalos.Name = "dataGridView_Cavalos";
            dataGridView_Cavalos.Size = new Size(951, 469);
            dataGridView_Cavalos.TabIndex = 8;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(399, 548);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(130, 23);
            button_Sair.TabIndex = 7;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // Relatorio_Dados_Cavalos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 585);
            Controls.Add(panel1);
            Name = "Relatorio_Dados_Cavalos";
            Text = "Relatorio_Dados_Cavalos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cavalos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView_Cavalos;
        private Button button_Sair;
    }
}