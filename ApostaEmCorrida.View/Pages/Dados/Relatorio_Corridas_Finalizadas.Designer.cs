namespace ApostaEmCorrida.View.Pages.Dados
{
    partial class Relatorio_Corridas_Finalizadas
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
            dataGridView_Corridas_Finalizadas = new DataGridView();
            button_Voltar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Finalizadas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_Corridas_Finalizadas);
            panel1.Controls.Add(button_Voltar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 582);
            panel1.TabIndex = 3;
            // 
            // dataGridView_Corridas_Finalizadas
            // 
            dataGridView_Corridas_Finalizadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Corridas_Finalizadas.Location = new Point(3, 61);
            dataGridView_Corridas_Finalizadas.Name = "dataGridView_Corridas_Finalizadas";
            dataGridView_Corridas_Finalizadas.Size = new Size(951, 471);
            dataGridView_Corridas_Finalizadas.TabIndex = 8;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(399, 548);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(130, 23);
            button_Voltar.TabIndex = 7;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
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
            label1.Size = new Size(242, 32);
            label1.TabIndex = 0;
            label1.Text = "Corridas Finalizadas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Relatorio_Corridas_Finalizadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 586);
            Controls.Add(panel1);
            Name = "Relatorio_Corridas_Finalizadas";
            Text = "Relatorio_Corridas_Finalizadas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Finalizadas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView_Corridas_Finalizadas;
        private Button button_Voltar;
        private Panel panel2;
        private Label label1;
    }
}