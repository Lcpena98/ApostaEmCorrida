namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Cavalo
{
    partial class Menu_ExcluirCavalo
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
            label1 = new Label();
            panel3 = new Panel();
            comboBox_Cavalos = new ComboBox();
            button_Excluir_Cavalo = new Button();
            panel4 = new Panel();
            button_Voltar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 57);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "Excluir Cavalo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox_Cavalos);
            panel3.Controls.Add(button_Excluir_Cavalo);
            panel3.Location = new Point(3, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 107);
            panel3.TabIndex = 3;
            // 
            // comboBox_Cavalos
            // 
            comboBox_Cavalos.FormattingEnabled = true;
            comboBox_Cavalos.Location = new Point(33, 27);
            comboBox_Cavalos.Name = "comboBox_Cavalos";
            comboBox_Cavalos.Size = new Size(177, 23);
            comboBox_Cavalos.TabIndex = 13;
            // 
            // button_Excluir_Cavalo
            // 
            button_Excluir_Cavalo.Location = new Point(59, 68);
            button_Excluir_Cavalo.Name = "button_Excluir_Cavalo";
            button_Excluir_Cavalo.Size = new Size(131, 28);
            button_Excluir_Cavalo.TabIndex = 12;
            button_Excluir_Cavalo.Text = "Excluir Cavalo";
            button_Excluir_Cavalo.UseVisualStyleBackColor = true;
            button_Excluir_Cavalo.Click += button_Excluir_Cavalo_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button_Voltar);
            panel4.Location = new Point(3, 179);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 60);
            panel4.TabIndex = 4;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(59, 19);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(131, 28);
            button_Voltar.TabIndex = 14;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // Menu_ExcluirCavalo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 243);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Menu_ExcluirCavalo";
            Text = "Menu_ExcluirCavalo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private ComboBox comboBox_Cavalos;
        private Button button_Excluir_Cavalo;
        private Panel panel4;
        private Button button_Voltar;
    }
}