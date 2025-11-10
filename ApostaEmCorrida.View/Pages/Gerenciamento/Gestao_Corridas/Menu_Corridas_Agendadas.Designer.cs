namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas
{
    partial class Menu_Corridas_Agendadas
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
            panel10 = new Panel();
            label2 = new Label();
            dataGridView_Corridas_Agendadas = new DataGridView();
            panel7 = new Panel();
            button_voltar = new Button();
            panel3 = new Panel();
            button_Cancelar_Corrida = new Button();
            button_Editar_Corrida = new Button();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Agendadas).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Location = new Point(12, 12);
            panel10.Name = "panel10";
            panel10.Size = new Size(339, 57);
            panel10.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 12);
            label2.Name = "label2";
            label2.Size = new Size(244, 32);
            label2.TabIndex = 1;
            label2.Text = "Corridas Agendadas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView_Corridas_Agendadas
            // 
            dataGridView_Corridas_Agendadas.BackgroundColor = SystemColors.Control;
            dataGridView_Corridas_Agendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Corridas_Agendadas.Location = new Point(13, 75);
            dataGridView_Corridas_Agendadas.Name = "dataGridView_Corridas_Agendadas";
            dataGridView_Corridas_Agendadas.Size = new Size(339, 160);
            dataGridView_Corridas_Agendadas.TabIndex = 26;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(12, 287);
            panel7.Name = "panel7";
            panel7.Size = new Size(339, 60);
            panel7.TabIndex = 29;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(118, 17);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(131, 28);
            button_voltar.TabIndex = 14;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Cancelar_Corrida);
            panel3.Controls.Add(button_Editar_Corrida);
            panel3.Location = new Point(13, 241);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 40);
            panel3.TabIndex = 31;
            // 
            // button_Cancelar_Corrida
            // 
            button_Cancelar_Corrida.Location = new Point(181, 9);
            button_Cancelar_Corrida.Name = "button_Cancelar_Corrida";
            button_Cancelar_Corrida.Size = new Size(134, 23);
            button_Cancelar_Corrida.TabIndex = 1;
            button_Cancelar_Corrida.Text = "Cancelar Corrida";
            button_Cancelar_Corrida.UseVisualStyleBackColor = true;
            button_Cancelar_Corrida.Click += button_Cancelar_Corrida_Click;
            // 
            // button_Editar_Corrida
            // 
            button_Editar_Corrida.Location = new Point(16, 9);
            button_Editar_Corrida.Name = "button_Editar_Corrida";
            button_Editar_Corrida.Size = new Size(134, 23);
            button_Editar_Corrida.TabIndex = 0;
            button_Editar_Corrida.Text = "Editar Corrida";
            button_Editar_Corrida.UseVisualStyleBackColor = true;
            button_Editar_Corrida.Click += button_Editar_Corrida_Click;
            // 
            // Menu_Corridas_Agendadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 350);
            Controls.Add(panel3);
            Controls.Add(panel7);
            Controls.Add(dataGridView_Corridas_Agendadas);
            Controls.Add(panel10);
            Name = "Menu_Corridas_Agendadas";
            Text = "Menu_Corridas_Agendadas";
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Agendadas).EndInit();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            this.Activated += Recarregar_Lista;
        }

        #endregion

        private Panel panel10;
        private Label label2;
        private DataGridView dataGridView_Corridas_Agendadas;
        private Panel panel7;
        private Button button_voltar;
        private Panel panel3;
        private Button button_Cancelar_Corrida;
        private Button button_Editar_Corrida;
    }
}