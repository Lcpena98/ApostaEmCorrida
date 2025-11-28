namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Apostador.Gestao_Saldo
{
    partial class Menu_Gestao_Saldo
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
            panel8 = new Panel();
            button_Sacar = new Button();
            button_Depositar = new Button();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(3, 125);
            panel7.Name = "panel7";
            panel7.Size = new Size(343, 60);
            panel7.TabIndex = 25;
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
            panel10.Location = new Point(3, 2);
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
            label2.Size = new Size(134, 32);
            label2.TabIndex = 1;
            label2.Text = "Apostador";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Sacar);
            panel8.Controls.Add(button_Depositar);
            panel8.Location = new Point(3, 65);
            panel8.Name = "panel8";
            panel8.Size = new Size(343, 54);
            panel8.TabIndex = 26;
            // 
            // button_Sacar
            // 
            button_Sacar.Location = new Point(11, 14);
            button_Sacar.Name = "button_Sacar";
            button_Sacar.Size = new Size(131, 28);
            button_Sacar.TabIndex = 9;
            button_Sacar.Text = "Sacar";
            button_Sacar.UseVisualStyleBackColor = true;
            button_Sacar.Click += button_Sacar_Click;
            // 
            // button_Depositar
            // 
            button_Depositar.Location = new Point(176, 14);
            button_Depositar.Name = "button_Depositar";
            button_Depositar.Size = new Size(131, 28);
            button_Depositar.TabIndex = 9;
            button_Depositar.Text = "Depositar";
            button_Depositar.UseVisualStyleBackColor = true;
            button_Depositar.Click += button_Depositar_Click;
            // 
            // Menu_Gestao_Saldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 188);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel10);
            Name = "Menu_Gestao_Saldo";
            Text = "Menu_Gestao_Saldo";
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button button_voltar;
        private Panel panel10;
        private Label label2;
        private Panel panel8;
        private Button button_Sacar;
        private Button button_Depositar;
    }
}