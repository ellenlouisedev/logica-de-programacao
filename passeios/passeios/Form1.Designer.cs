namespace passeios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxClima = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSugestao = new System.Windows.Forms.Label();
            this.tbxDinheiro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sugestão de passeio";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clima";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dinheiro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbxClima
            // 
            this.cbxClima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxClima.FormattingEnabled = true;
            this.cbxClima.Items.AddRange(new object[] {
            "Sol",
            "Chuva"});
            this.cbxClima.Location = new System.Drawing.Point(327, 128);
            this.cbxClima.Name = "cbxClima";
            this.cbxClima.Size = new System.Drawing.Size(201, 21);
            this.cbxClima.TabIndex = 1;
            this.cbxClima.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(352, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Receber Sugestão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSugestao
            // 
            this.lblSugestao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSugestao.AutoSize = true;
            this.lblSugestao.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugestao.Location = new System.Drawing.Point(263, 253);
            this.lblSugestao.Name = "lblSugestao";
            this.lblSugestao.Size = new System.Drawing.Size(43, 26);
            this.lblSugestao.TabIndex = 3;
            this.lblSugestao.Text = "label4";
            // 
            // tbxDinheiro
            // 
            this.tbxDinheiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxDinheiro.Location = new System.Drawing.Point(327, 174);
            this.tbxDinheiro.Name = "tbxDinheiro";
            this.tbxDinheiro.Size = new System.Drawing.Size(201, 20);
            this.tbxDinheiro.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::passeios.Properties.Resources.londres;
            this.pictureBox1.Location = new System.Drawing.Point(266, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxDinheiro);
            this.Controls.Add(this.lblSugestao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxClima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxClima;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSugestao;
        private System.Windows.Forms.TextBox tbxDinheiro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

