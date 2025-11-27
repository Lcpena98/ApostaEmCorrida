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
            panel2 = new Panel();
            button_Iniciar_Corrida = new Button();
            button_Editar_Corrida = new Button();
            dataGridView_Corridas_Em_Andamento = new DataGridView();
            dataGridView_Corridas_Agendadas = new DataGridView();
            panel7 = new Panel();
            button_voltar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel10 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Em_Andamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Agendadas).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView_Corridas_Em_Andamento);
            panel1.Controls.Add(dataGridView_Corridas_Agendadas);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel10);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 449);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_Iniciar_Corrida);
            panel2.Controls.Add(button_Editar_Corrida);
            panel2.Location = new Point(12, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 60);
            panel2.TabIndex = 32;
            // 
            // button_Iniciar_Corrida
            // 
            button_Iniciar_Corrida.Location = new Point(374, 20);
            button_Iniciar_Corrida.Name = "button_Iniciar_Corrida";
            button_Iniciar_Corrida.Size = new Size(307, 23);
            button_Iniciar_Corrida.TabIndex = 37;
            button_Iniciar_Corrida.Text = "Iniciar Corrida Em Andamento";
            button_Iniciar_Corrida.UseVisualStyleBackColor = true;
            button_Iniciar_Corrida.Click += button_Iniciar_Corrida_Click;
            // 
            // button_Editar_Corrida
            // 
            button_Editar_Corrida.Location = new Point(9, 20);
            button_Editar_Corrida.Name = "button_Editar_Corrida";
            button_Editar_Corrida.Size = new Size(307, 23);
            button_Editar_Corrida.TabIndex = 36;
            button_Editar_Corrida.Text = "Editar Corrida Agendada";
            button_Editar_Corrida.UseVisualStyleBackColor = true;
            button_Editar_Corrida.Click += button_Editar_Corrida_Click;
            // 
            // dataGridView_Corridas_Em_Andamento
            // 
            dataGridView_Corridas_Em_Andamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Corridas_Em_Andamento.Location = new Point(377, 66);
            dataGridView_Corridas_Em_Andamento.Name = "dataGridView_Corridas_Em_Andamento";
            dataGridView_Corridas_Em_Andamento.Size = new Size(325, 160);
            dataGridView_Corridas_Em_Andamento.TabIndex = 35;
            // 
            // dataGridView_Corridas_Agendadas
            // 
            dataGridView_Corridas_Agendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Corridas_Agendadas.Location = new Point(12, 66);
            dataGridView_Corridas_Agendadas.Name = "dataGridView_Corridas_Agendadas";
            dataGridView_Corridas_Agendadas.Size = new Size(325, 160);
            dataGridView_Corridas_Agendadas.TabIndex = 32;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(3, 386);
            panel7.Name = "panel7";
            panel7.Size = new Size(718, 60);
            panel7.TabIndex = 31;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(201, 23);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(308, 28);
            button_voltar.TabIndex = 14;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(377, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 57);
            panel3.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(293, 32);
            label1.TabIndex = 1;
            label1.Text = "Corridas Em Andamento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            label2.Location = new Point(49, 14);
            label2.Name = "label2";
            label2.Size = new Size(244, 32);
            label2.TabIndex = 1;
            label2.Text = "Corridas Agendadas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu_Exibicao_Corridas_Em_Andamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(panel1);
            Name = "Menu_Exibicao_Corridas_Em_Andamento";
            Text = "Menu_Exibicao_Corridas_Em_Andamento";
            Activated += Recarregar_Lista;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Em_Andamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Corridas_Agendadas).EndInit();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView_Corridas_Agendadas;
        private Panel panel7;
        private Button button_voltar;
        private Panel panel10;
        private Label label2;
        private DataGridView dataGridView_Corridas_Em_Andamento;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Button button_Iniciar_Corrida;
        private Button button_Editar_Corrida;
    }
}