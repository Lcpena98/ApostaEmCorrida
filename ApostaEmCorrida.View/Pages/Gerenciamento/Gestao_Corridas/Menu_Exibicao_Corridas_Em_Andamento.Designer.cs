namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas
{
    partial class Menu_Exibicao_Corridas_Em_Andamento
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
            dataGridView_Corridas_Em_Andamento = new DataGridView();
            panel7 = new Panel();
            button_voltar = new Button();
            panel10 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Em_Andamento).BeginInit();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_Corridas_Em_Andamento);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel10);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 449);
            panel1.TabIndex = 0;
            // 
            // dataGridView_Corridas_Em_Andamento
            // 
            dataGridView_Corridas_Em_Andamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Corridas_Em_Andamento.Location = new Point(3, 66);
            dataGridView_Corridas_Em_Andamento.Name = "dataGridView_Corridas_Em_Andamento";
            dataGridView_Corridas_Em_Andamento.Size = new Size(339, 150);
            dataGridView_Corridas_Em_Andamento.TabIndex = 32;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(3, 386);
            panel7.Name = "panel7";
            panel7.Size = new Size(339, 60);
            panel7.TabIndex = 31;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(100, 17);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(131, 28);
            button_voltar.TabIndex = 14;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(339, 57);
            panel10.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 13);
            label2.Name = "label2";
            label2.Size = new Size(293, 32);
            label2.TabIndex = 1;
            label2.Text = "Corridas Em Andamento";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu_Exibicao_Corridas_Em_Andamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 450);
            Controls.Add(panel1);
            Name = "Menu_Exibicao_Corridas_Em_Andamento";
            Text = "Menu_Exibicao_Corridas_Em_Andamento";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Em_Andamento).EndInit();
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView_Corridas_Em_Andamento;
        private Panel panel7;
        private Button button_voltar;
        private Panel panel10;
        private Label label2;
    }
}