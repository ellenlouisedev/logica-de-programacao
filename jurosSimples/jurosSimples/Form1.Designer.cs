namespace jurosSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCapital = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxTaxa = new System.Windows.Forms.TextBox();
            this.tbxTempo = new System.Windows.Forms.TextBox();
            this.tbxJuros = new System.Windows.Forms.TextBox();
            this.tbxMontante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::jurosSimples.Properties.Resources.logo_senac;
            this.pictureBox1.Location = new System.Drawing.Point(301, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capital";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Montante";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Taxa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Juros";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbxCapital
            // 
            this.tbxCapital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxCapital.Location = new System.Drawing.Point(291, 194);
            this.tbxCapital.Name = "tbxCapital";
            this.tbxCapital.Size = new System.Drawing.Size(190, 20);
            this.tbxCapital.TabIndex = 6;
            this.tbxCapital.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(291, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxTaxa
            // 
            this.tbxTaxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTaxa.Location = new System.Drawing.Point(291, 220);
            this.tbxTaxa.Name = "tbxTaxa";
            this.tbxTaxa.Size = new System.Drawing.Size(190, 20);
            this.tbxTaxa.TabIndex = 6;
            this.tbxTaxa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxTempo
            // 
            this.tbxTempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTempo.Location = new System.Drawing.Point(291, 246);
            this.tbxTempo.Name = "tbxTempo";
            this.tbxTempo.Size = new System.Drawing.Size(190, 20);
            this.tbxTempo.TabIndex = 6;
            // 
            // tbxJuros
            // 
            this.tbxJuros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxJuros.Enabled = false;
            this.tbxJuros.Location = new System.Drawing.Point(291, 310);
            this.tbxJuros.Name = "tbxJuros";
            this.tbxJuros.Size = new System.Drawing.Size(190, 20);
            this.tbxJuros.TabIndex = 6;
            this.tbxJuros.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbxMontante
            // 
            this.tbxMontante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxMontante.Enabled = false;
            this.tbxMontante.Location = new System.Drawing.Point(291, 336);
            this.tbxMontante.Name = "tbxMontante";
            this.tbxMontante.Size = new System.Drawing.Size(190, 20);
            this.tbxMontante.TabIndex = 6;
            this.tbxMontante.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(809, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxTempo);
            this.Controls.Add(this.tbxTaxa);
            this.Controls.Add(this.tbxMontante);
            this.Controls.Add(this.tbxJuros);
            this.Controls.Add(this.tbxCapital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCapital;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxTaxa;
        private System.Windows.Forms.TextBox tbxTempo;
        private System.Windows.Forms.TextBox tbxJuros;
        private System.Windows.Forms.TextBox tbxMontante;
    }
}

