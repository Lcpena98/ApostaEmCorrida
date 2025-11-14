namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas
{
    partial class Menu_Gerenciar_Corridas
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
            panel7 = new Panel();
            button_voltar = new Button();
            panel9 = new Panel();
            button_Corridas_Andamento = new Button();
            button_Corridas_Finalizadas = new Button();
            button_Nova_Corrida = new Button();
            panel10 = new Panel();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(3, 184);
            panel7.Name = "panel7";
            panel7.Size = new Size(336, 60);
            panel7.TabIndex = 27;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(104, 17);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(131, 28);
            button_voltar.TabIndex = 14;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(button_Corridas_Andamento);
            panel9.Controls.Add(button_Corridas_Finalizadas);
            panel9.Controls.Add(button_Nova_Corrida);
            panel9.Location = new Point(3, 64);
            panel9.Name = "panel9";
            panel9.Size = new Size(336, 114);
            panel9.TabIndex = 25;
            // 
            // button_Corridas_Andamento
            // 
            button_Corridas_Andamento.Location = new Point(175, 14);
            button_Corridas_Andamento.Name = "button_Corridas_Andamento";
            button_Corridas_Andamento.Size = new Size(155, 44);
            button_Corridas_Andamento.TabIndex = 11;
            button_Corridas_Andamento.Text = "Corridas Agendadas e em Andamento";
            button_Corridas_Andamento.UseVisualStyleBackColor = true;
            button_Corridas_Andamento.Click += button_Corridas_Andamento_Click;
            // 
            // button_Corridas_Finalizadas
            // 
            button_Corridas_Finalizadas.Location = new Point(106, 73);
            button_Corridas_Finalizadas.Name = "button_Corridas_Finalizadas";
            button_Corridas_Finalizadas.Size = new Size(137, 28);
            button_Corridas_Finalizadas.TabIndex = 10;
            button_Corridas_Finalizadas.Text = "Corridas Finalizadas";
            button_Corridas_Finalizadas.UseVisualStyleBackColor = true;
            button_Corridas_Finalizadas.Click += button_Corridas_Finalizadas_Click;
            // 
            // button_Nova_Corrida
            // 
            button_Nova_Corrida.Location = new Point(9, 22);
            button_Nova_Corrida.Name = "button_Nova_Corrida";
            button_Nova_Corrida.Size = new Size(155, 28);
            button_Nova_Corrida.TabIndex = 9;
            button_Nova_Corrida.Text = "Agendar Nova Corrida";
            button_Nova_Corrida.UseVisualStyleBackColor = true;
            button_Nova_Corrida.Click += button_Nova_Corrida_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Location = new Point(0, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(339, 57);
            panel10.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 14);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 1;
            label2.Text = "Corridas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Menu_Gerenciar_Corridas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 250);
            Controls.Add(panel7);
            Controls.Add(panel9);
            Controls.Add(panel10);
            Name = "Menu_Gerenciar_Corridas";
            Text = "Menu_Gerenciar_Corridas";
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button button_voltar;
        private Panel panel9;
        private Button button_Corridas_Andamento;
        private Button button_Corridas_Finalizadas;
        private Button button_Nova_Corrida;
        private Panel panel10;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}