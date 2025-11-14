namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas
{
    partial class Menu_Gerenciar_Corrida_Agendada_Selecionada
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
            panel3 = new Panel();
            button_Cadastrar_Cavalo = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView_Cavalos = new DataGridView();
            panel10 = new Panel();
            textBox_Percurso = new TextBox();
            label5 = new Label();
            panel9 = new Panel();
            numericUpDown_Numero_Voltas = new NumericUpDown();
            label4 = new Label();
            panel7 = new Panel();
            button_voltar = new Button();
            panel6 = new Panel();
            data_Inicio_Corrida = new DateTimePicker();
            label2 = new Label();
            panel5 = new Panel();
            button_Gerenciar_Corrida = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            button_Gerenciar_Cavalo = new Button();
            panel8 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cavalos).BeginInit();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Numero_Voltas).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Cadastrar_Cavalo);
            panel3.Location = new Point(6, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 40);
            panel3.TabIndex = 8;
            // 
            // button_Cadastrar_Cavalo
            // 
            button_Cadastrar_Cavalo.Location = new Point(17, 9);
            button_Cadastrar_Cavalo.Name = "button_Cadastrar_Cavalo";
            button_Cadastrar_Cavalo.Size = new Size(350, 23);
            button_Cadastrar_Cavalo.TabIndex = 0;
            button_Cadastrar_Cavalo.Text = "Cadastrar Cavalo";
            button_Cadastrar_Cavalo.UseVisualStyleBackColor = true;
            button_Cadastrar_Cavalo.Click += button_Cadastrar_Cavalo_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 54);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 6);
            label1.Name = "label1";
            label1.Size = new Size(326, 32);
            label1.TabIndex = 0;
            label1.Text = "Gerenciamento de Corridas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView_Cavalos
            // 
            dataGridView_Cavalos.BackgroundColor = SystemColors.Control;
            dataGridView_Cavalos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Cavalos.Location = new Point(0, 2);
            dataGridView_Cavalos.Name = "dataGridView_Cavalos";
            dataGridView_Cavalos.Size = new Size(374, 160);
            dataGridView_Cavalos.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(textBox_Percurso);
            panel10.Controls.Add(label5);
            panel10.Location = new Point(4, 317);
            panel10.Name = "panel10";
            panel10.Size = new Size(375, 45);
            panel10.TabIndex = 31;
            // 
            // textBox_Percurso
            // 
            textBox_Percurso.Location = new Point(184, 15);
            textBox_Percurso.Name = "textBox_Percurso";
            textBox_Percurso.Size = new Size(100, 23);
            textBox_Percurso.TabIndex = 2;
            textBox_Percurso.TextChanged += textBox_Percurso_TextChanged;
            textBox_Percurso.KeyPress += textBox_Percurso_TextKeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 19);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 0;
            label5.Text = "Distancia do percurso";
            // 
            // panel9
            // 
            panel9.Controls.Add(numericUpDown_Numero_Voltas);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(5, 366);
            panel9.Name = "panel9";
            panel9.Size = new Size(374, 53);
            panel9.TabIndex = 30;
            // 
            // numericUpDown_Numero_Voltas
            // 
            numericUpDown_Numero_Voltas.Location = new Point(167, 15);
            numericUpDown_Numero_Voltas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_Numero_Voltas.Name = "numericUpDown_Numero_Voltas";
            numericUpDown_Numero_Voltas.Size = new Size(120, 23);
            numericUpDown_Numero_Voltas.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 17);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Nº Voltas:";
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(1, 514);
            panel7.Name = "panel7";
            panel7.Size = new Size(377, 49);
            panel7.TabIndex = 28;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(121, 12);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(131, 28);
            button_voltar.TabIndex = 14;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(data_Inicio_Corrida);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(6, 422);
            panel6.Name = "panel6";
            panel6.Size = new Size(371, 45);
            panel6.TabIndex = 10;
            // 
            // data_Inicio_Corrida
            // 
            data_Inicio_Corrida.Format = DateTimePickerFormat.Custom;
            data_Inicio_Corrida.Location = new Point(126, 12);
            data_Inicio_Corrida.Name = "data_Inicio_Corrida";
            data_Inicio_Corrida.Size = new Size(159, 23);
            data_Inicio_Corrida.TabIndex = 2;
            data_Inicio_Corrida.Value = new DateTime(2025, 11, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 15);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 0;
            label2.Text = "Data-Hora Inicio:";
            // 
            // panel5
            // 
            panel5.Controls.Add(button_Gerenciar_Corrida);
            panel5.Location = new Point(5, 470);
            panel5.Name = "panel5";
            panel5.Size = new Size(374, 42);
            panel5.TabIndex = 9;
            // 
            // button_Gerenciar_Corrida
            // 
            button_Gerenciar_Corrida.Location = new Point(123, 11);
            button_Gerenciar_Corrida.Name = "button_Gerenciar_Corrida";
            button_Gerenciar_Corrida.Size = new Size(134, 23);
            button_Gerenciar_Corrida.TabIndex = 0;
            button_Gerenciar_Corrida.Text = "Alterar Dados";
            button_Gerenciar_Corrida.UseVisualStyleBackColor = true;
            button_Gerenciar_Corrida.Click += button_Gerenciar_Corrida_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 568);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button_Gerenciar_Cavalo);
            panel4.Location = new Point(4, 277);
            panel4.Name = "panel4";
            panel4.Size = new Size(379, 42);
            panel4.TabIndex = 32;
            // 
            // button_Gerenciar_Cavalo
            // 
            button_Gerenciar_Cavalo.Location = new Point(123, 11);
            button_Gerenciar_Cavalo.Name = "button_Gerenciar_Cavalo";
            button_Gerenciar_Cavalo.Size = new Size(134, 23);
            button_Gerenciar_Cavalo.TabIndex = 0;
            button_Gerenciar_Cavalo.Text = "Gerenciar Cavalo";
            button_Gerenciar_Cavalo.UseVisualStyleBackColor = true;
            button_Gerenciar_Cavalo.Click += button_Gerenciar_Cavalo_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(dataGridView_Cavalos);
            panel8.Location = new Point(4, 109);
            panel8.Name = "panel8";
            panel8.Size = new Size(377, 166);
            panel8.TabIndex = 29;
            // 
            // Menu_Gerenciar_Corrida_Agendada_Selecionada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 569);
            Controls.Add(panel1);
            Name = "Menu_Gerenciar_Corrida_Agendada_Selecionada";
            Text = "Menu_Gerenciar_Corrida_Agendada";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cavalos).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Numero_Voltas).EndInit();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button_Cadastrar_Cavalo;
        private Panel panel4;
        private ComboBox comboBox_Cavalo;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView_Cavalos;
        private Panel panel10;
        private TextBox textBox_Percurso;
        private Label label5;
        private Panel panel9;
        private NumericUpDown numericUpDown_Numero_Voltas;
        private Label label4;
        private Panel panel7;
        private Button button_voltar;
        private Panel panel6;
        private DateTimePicker data_Inicio_Corrida;
        private Label label2;
        private Panel panel5;
        private Button button_Gerenciar_Corrida;
        private Panel panel1;
        private Panel panel8;
        private Button button_Gerenciar_Cavalo;
    }
}