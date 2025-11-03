namespace ApostaEmCorrida.View.Pages.Gerenciamento.Gestao_Corridas
{
    partial class Menu_Cadastro_Corrida
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
            panel10 = new Panel();
            textBox_Percurso = new TextBox();
            label5 = new Label();
            panel9 = new Panel();
            numericUpDown_Numero_Voltas = new NumericUpDown();
            label4 = new Label();
            panel8 = new Panel();
            dataGridView_Cavalos = new DataGridView();
            panel7 = new Panel();
            button_voltar = new Button();
            panel6 = new Panel();
            data_Inicio_Corrida = new DateTimePicker();
            label2 = new Label();
            panel5 = new Panel();
            button_Cadastrar_Corrida = new Button();
            panel3 = new Panel();
            button_Cadastrar_Cavalo = new Button();
            panel4 = new Panel();
            comboBox_Cavalo = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Numero_Voltas).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cavalos).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 591);
            panel1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(textBox_Percurso);
            panel10.Controls.Add(label5);
            panel10.Location = new Point(6, 312);
            panel10.Name = "panel10";
            panel10.Size = new Size(304, 45);
            panel10.TabIndex = 31;
            // 
            // textBox_Percurso
            // 
            textBox_Percurso.Location = new Point(151, 15);
            textBox_Percurso.Name = "textBox_Percurso";
            textBox_Percurso.Size = new Size(100, 23);
            textBox_Percurso.TabIndex = 2;
            textBox_Percurso.TextChanged += textBox_Percurso_TextChanged;
            textBox_Percurso.KeyPress += textBox_Percurso_TextKeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 15);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 0;
            label5.Text = "Distancia do percurso";
            // 
            // panel9
            // 
            panel9.Controls.Add(numericUpDown_Numero_Voltas);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(8, 363);
            panel9.Name = "panel9";
            panel9.Size = new Size(304, 45);
            panel9.TabIndex = 30;
            // 
            // numericUpDown_Numero_Voltas
            // 
            numericUpDown_Numero_Voltas.Location = new Point(121, 13);
            numericUpDown_Numero_Voltas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_Numero_Voltas.Name = "numericUpDown_Numero_Voltas";
            numericUpDown_Numero_Voltas.Size = new Size(120, 23);
            numericUpDown_Numero_Voltas.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 15);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Nº Voltas:";
            // 
            // panel8
            // 
            panel8.Controls.Add(dataGridView_Cavalos);
            panel8.Location = new Point(0, 143);
            panel8.Name = "panel8";
            panel8.Size = new Size(315, 166);
            panel8.TabIndex = 29;
            // 
            // dataGridView_Cavalos
            // 
            dataGridView_Cavalos.BackgroundColor = SystemColors.Control;
            dataGridView_Cavalos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Cavalos.Location = new Point(0, 3);
            dataGridView_Cavalos.Name = "dataGridView_Cavalos";
            dataGridView_Cavalos.Size = new Size(312, 160);
            dataGridView_Cavalos.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_voltar);
            panel7.Location = new Point(3, 521);
            panel7.Name = "panel7";
            panel7.Size = new Size(312, 60);
            panel7.TabIndex = 28;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(101, 17);
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
            panel6.Location = new Point(9, 422);
            panel6.Name = "panel6";
            panel6.Size = new Size(306, 45);
            panel6.TabIndex = 10;
            // 
            // data_Inicio_Corrida
            // 
            data_Inicio_Corrida.Format = DateTimePickerFormat.Custom;
            data_Inicio_Corrida.Location = new Point(120, 9);
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
            panel5.Controls.Add(button_Cadastrar_Corrida);
            panel5.Location = new Point(6, 473);
            panel5.Name = "panel5";
            panel5.Size = new Size(309, 42);
            panel5.TabIndex = 9;
            // 
            // button_Cadastrar_Corrida
            // 
            button_Cadastrar_Corrida.Location = new Point(94, 10);
            button_Cadastrar_Corrida.Name = "button_Cadastrar_Corrida";
            button_Cadastrar_Corrida.Size = new Size(134, 23);
            button_Cadastrar_Corrida.TabIndex = 0;
            button_Cadastrar_Corrida.Text = "Cadastrar Corrida";
            button_Cadastrar_Corrida.UseVisualStyleBackColor = true;
            button_Cadastrar_Corrida.Click += button_Cadastrar_Corrida_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Cadastrar_Cavalo);
            panel3.Location = new Point(3, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 40);
            panel3.TabIndex = 8;
            // 
            // button_Cadastrar_Cavalo
            // 
            button_Cadastrar_Cavalo.Location = new Point(98, 9);
            button_Cadastrar_Cavalo.Name = "button_Cadastrar_Cavalo";
            button_Cadastrar_Cavalo.Size = new Size(134, 23);
            button_Cadastrar_Cavalo.TabIndex = 0;
            button_Cadastrar_Cavalo.Text = "Cadastrar Cavalo";
            button_Cadastrar_Cavalo.UseVisualStyleBackColor = true;
            button_Cadastrar_Cavalo.Click += button_Cadastrar_Cavalo_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox_Cavalo);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 45);
            panel4.TabIndex = 7;
            // 
            // comboBox_Cavalo
            // 
            comboBox_Cavalo.FormattingEnabled = true;
            comboBox_Cavalo.Location = new Point(105, 9);
            comboBox_Cavalo.Name = "comboBox_Cavalo";
            comboBox_Cavalo.Size = new Size(177, 23);
            comboBox_Cavalo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 9);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Cavalo:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 54);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 6);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Corridas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu_Cadastro_Corrida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 593);
            Controls.Add(panel1);
            Name = "Menu_Cadastro_Corrida";
            Text = "Menu_Cadastro_Corrida";
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Numero_Voltas).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cavalos).EndInit();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private ComboBox comboBox_Cavalo;
        private Label label3;
        private Panel panel7;
        private Button button_voltar;
        private Panel panel5;
        private Button button_Cadastrar_Corrida;
        private Panel panel3;
        private Button button_Cadastrar_Cavalo;
        private Panel panel6;
        private Label label2;
        private DateTimePicker data_Inicio_Corrida;
        private Panel panel8;
        private DataGridView dataGridView_Cavalos;
        private Panel panel9;
        private NumericUpDown numericUpDown_Numero_Voltas;
        private Label label4;
        private Panel panel10;
        private Label label5;
        private TextBox textBox_Percurso;
    }
}