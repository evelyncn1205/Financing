namespace ExercicioFinanciamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_outros = new System.Windows.Forms.Button();
            this.btn_carro = new System.Windows.Forms.Button();
            this.btn_casa = new System.Windows.Forms.Button();
            this.bto_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_outros
            // 
            this.btn_outros.FlatAppearance.BorderSize = 0;
            this.btn_outros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_outros.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_outros.ForeColor = System.Drawing.Color.Black;
            this.btn_outros.Location = new System.Drawing.Point(0, 254);
            this.btn_outros.Name = "btn_outros";
            this.btn_outros.Size = new System.Drawing.Size(273, 48);
            this.btn_outros.TabIndex = 0;
            this.btn_outros.Text = "Outros Financiamentos";
            this.btn_outros.UseVisualStyleBackColor = true;
            this.btn_outros.Click += new System.EventHandler(this.btn_outros_Click);
            // 
            // btn_carro
            // 
            this.btn_carro.FlatAppearance.BorderSize = 0;
            this.btn_carro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carro.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_carro.ForeColor = System.Drawing.Color.Black;
            this.btn_carro.Location = new System.Drawing.Point(0, 185);
            this.btn_carro.Name = "btn_carro";
            this.btn_carro.Size = new System.Drawing.Size(274, 63);
            this.btn_carro.TabIndex = 1;
            this.btn_carro.Text = "Simular Financiamento de Carro";
            this.btn_carro.UseVisualStyleBackColor = true;
            this.btn_carro.Click += new System.EventHandler(this.btn_carro_Click);
            // 
            // btn_casa
            // 
            this.btn_casa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_casa.FlatAppearance.BorderSize = 0;
            this.btn_casa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_casa.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_casa.ForeColor = System.Drawing.Color.Black;
            this.btn_casa.Location = new System.Drawing.Point(0, 108);
            this.btn_casa.Name = "btn_casa";
            this.btn_casa.Size = new System.Drawing.Size(292, 71);
            this.btn_casa.TabIndex = 2;
            this.btn_casa.Text = "Simular Financiamento  de Imóvel";
            this.btn_casa.UseVisualStyleBackColor = true;
            this.btn_casa.Click += new System.EventHandler(this.btn_casa_Click);
            // 
            // bto_fechar
            // 
            this.bto_fechar.FlatAppearance.BorderSize = 0;
            this.bto_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bto_fechar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bto_fechar.ForeColor = System.Drawing.Color.Black;
            this.bto_fechar.Location = new System.Drawing.Point(-1, 308);
            this.bto_fechar.Name = "bto_fechar";
            this.bto_fechar.Size = new System.Drawing.Size(274, 45);
            this.bto_fechar.TabIndex = 3;
            this.bto_fechar.Text = "Fechar";
            this.bto_fechar.UseVisualStyleBackColor = true;
            this.bto_fechar.Click += new System.EventHandler(this.bto_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Simulador de Financiamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 78);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Copyrights © 2023, All rights Reserved By  Evelyn Nunes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(559, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bto_fechar);
            this.Controls.Add(this.btn_casa);
            this.Controls.Add(this.btn_carro);
            this.Controls.Add(this.btn_outros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_outros;
        private Button btn_carro;
        private Button btn_casa;
        private Button bto_fechar;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}