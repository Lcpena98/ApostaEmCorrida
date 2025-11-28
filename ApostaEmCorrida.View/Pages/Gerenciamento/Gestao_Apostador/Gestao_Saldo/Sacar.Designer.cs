namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador.Gestao_Saldo
{
    partial class Sacar
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
            panel10 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            button_Sacar = new Button();
            panel5 = new Panel();
            textBox_Valor = new TextBox();
            label4 = new Label();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(1, 163);
            panel7.Name = "panel7";
            panel7.Size = new Size(343, 60);
            panel7.TabIndex = 28;
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
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Location = new Point(1, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(339, 57);
            panel10.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 12);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 1;
            label2.Text = "Sacar";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Sacar);
            panel1.Location = new Point(1, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 42);
            panel1.TabIndex = 31;
            // 
            // button_Sacar
            // 
            button_Sacar.Location = new Point(104, 10);
            button_Sacar.Name = "button_Sacar";
            button_Sacar.Size = new Size(155, 23);
            button_Sacar.TabIndex = 0;
            button_Sacar.Text = "Sacar";
            button_Sacar.UseVisualStyleBackColor = true;
            button_Sacar.Click += button_Sacar_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_Valor);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(1, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(343, 45);
            panel5.TabIndex = 30;
            // 
            // textBox_Valor
            // 
            textBox_Valor.Location = new Point(135, 15);
            textBox_Valor.Name = "textBox_Valor";
            textBox_Valor.Size = new Size(100, 23);
            textBox_Valor.TabIndex = 1;
            textBox_Valor.KeyPress += textBox_Valor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 18);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "Valor:";
            // 
            // Sacar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 227);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel7);
            Controls.Add(panel10);
            Name = "Sacar";
            Text = "Sacar";
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel7;
        private Button button_voltar;
        private Panel panel10;
        private Label label2;
        private Panel panel1;
        private Button button_Sacar;
        private Panel panel5;
        private TextBox textBox_Valor;
        private Label label4;
    }
}