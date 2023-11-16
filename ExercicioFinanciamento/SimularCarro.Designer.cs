namespace ExercicioFinanciamento
{
    partial class SimularCarro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valorFinanciado = new System.Windows.Forms.TextBox();
            this.txt_prazocarro = new System.Windows.Forms.TextBox();
            this.txt_valorMensal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalpagamento = new System.Windows.Forms.TextBox();
            this.btn_fecharcarro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_abertura = new System.Windows.Forms.TextBox();
            this.txt_residual = new System.Windows.Forms.TextBox();
            this.btn_calcularCarro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_jurosAnualcarro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Financiado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Mensal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prazo:";
            // 
            // txt_valorFinanciado
            // 
            this.txt_valorFinanciado.Location = new System.Drawing.Point(157, 92);
            this.txt_valorFinanciado.Name = "txt_valorFinanciado";
            this.txt_valorFinanciado.Size = new System.Drawing.Size(100, 23);
            this.txt_valorFinanciado.TabIndex = 3;
            // 
            // txt_prazocarro
            // 
            this.txt_prazocarro.Location = new System.Drawing.Point(157, 147);
            this.txt_prazocarro.Name = "txt_prazocarro";
            this.txt_prazocarro.Size = new System.Drawing.Size(100, 23);
            this.txt_prazocarro.TabIndex = 4;
            // 
            // txt_valorMensal
            // 
            this.txt_valorMensal.Location = new System.Drawing.Point(112, 309);
            this.txt_valorMensal.Name = "txt_valorMensal";
            this.txt_valorMensal.Size = new System.Drawing.Size(100, 23);
            this.txt_valorMensal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(278, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Total à pagar:";
            // 
            // txt_totalpagamento
            // 
            this.txt_totalpagamento.Location = new System.Drawing.Point(426, 311);
            this.txt_totalpagamento.Name = "txt_totalpagamento";
            this.txt_totalpagamento.Size = new System.Drawing.Size(102, 23);
            this.txt_totalpagamento.TabIndex = 7;
            // 
            // btn_fecharcarro
            // 
            this.btn_fecharcarro.FlatAppearance.BorderSize = 0;
            this.btn_fecharcarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fecharcarro.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fecharcarro.Location = new System.Drawing.Point(-1, 379);
            this.btn_fecharcarro.Name = "btn_fecharcarro";
            this.btn_fecharcarro.Size = new System.Drawing.Size(559, 41);
            this.btn_fecharcarro.TabIndex = 8;
            this.btn_fecharcarro.Text = "Fechar";
            this.btn_fecharcarro.UseVisualStyleBackColor = true;
            this.btn_fecharcarro.Click += new System.EventHandler(this.btn_fecharcarro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(269, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comissão de abertura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Residual:";
            // 
            // txt_abertura
            // 
            this.txt_abertura.Enabled = false;
            this.txt_abertura.Location = new System.Drawing.Point(426, 260);
            this.txt_abertura.Name = "txt_abertura";
            this.txt_abertura.Size = new System.Drawing.Size(100, 23);
            this.txt_abertura.TabIndex = 11;
            // 
            // txt_residual
            // 
            this.txt_residual.Enabled = false;
            this.txt_residual.Location = new System.Drawing.Point(112, 260);
            this.txt_residual.Name = "txt_residual";
            this.txt_residual.Size = new System.Drawing.Size(100, 23);
            this.txt_residual.TabIndex = 12;
            // 
            // btn_calcularCarro
            // 
            this.btn_calcularCarro.FlatAppearance.BorderSize = 0;
            this.btn_calcularCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcularCarro.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_calcularCarro.Location = new System.Drawing.Point(-1, 195);
            this.btn_calcularCarro.Name = "btn_calcularCarro";
            this.btn_calcularCarro.Size = new System.Drawing.Size(559, 41);
            this.btn_calcularCarro.TabIndex = 13;
            this.btn_calcularCarro.Text = "Calcular";
            this.btn_calcularCarro.UseVisualStyleBackColor = true;
            this.btn_calcularCarro.Click += new System.EventHandler(this.btn_calcularCarro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(274, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Taxa de Juros Anual:";
            // 
            // txt_jurosAnualcarro
            // 
            this.txt_jurosAnualcarro.Location = new System.Drawing.Point(422, 90);
            this.txt_jurosAnualcarro.Name = "txt_jurosAnualcarro";
            this.txt_jurosAnualcarro.Size = new System.Drawing.Size(100, 23);
            this.txt_jurosAnualcarro.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 69);
            this.panel1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(56, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(429, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Simulador Financiamento de Carro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Copyrights © 2023, All rights Reserved By  Evelyn Nunes";
            // 
            // SimularCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(541, 455);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_jurosAnualcarro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_calcularCarro);
            this.Controls.Add(this.txt_residual);
            this.Controls.Add(this.txt_abertura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_fecharcarro);
            this.Controls.Add(this.txt_totalpagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valorMensal);
            this.Controls.Add(this.txt_prazocarro);
            this.Controls.Add(this.txt_valorFinanciado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimularCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimularCarro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_valorFinanciado;
        private TextBox txt_prazocarro;
        private TextBox txt_valorMensal;
        private Label label4;
        private TextBox txt_totalpagamento;
        private Button btn_fecharcarro;
        private Label label5;
        private Label label6;
        private TextBox txt_abertura;
        private TextBox txt_residual;
        private Button btn_calcularCarro;
        private Label label7;
        private TextBox txt_jurosAnualcarro;
        private Panel panel1;
        private Label label8;
        private Label label9;
    }
}