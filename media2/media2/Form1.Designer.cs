namespace media2
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tbxN1 = new System.Windows.Forms.TextBox();
            this.tbxN2 = new System.Windows.Forms.TextBox();
            this.tbxN3 = new System.Windows.Forms.TextBox();
            this.tbxMedia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxRecuperacao = new System.Windows.Forms.TextBox();
            this.btnRecuperacao = new System.Windows.Forms.Button();
            this.lblRecuperacao = new System.Windows.Forms.Label();
            this.lblResultadoRec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(193, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(193, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(193, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nota 3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(194, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Média";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(193, 359);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(75, 16);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado: ";
            // 
            // tbxN1
            // 
            this.tbxN1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxN1.Location = new System.Drawing.Point(245, 159);
            this.tbxN1.Name = "tbxN1";
            this.tbxN1.Size = new System.Drawing.Size(176, 20);
            this.tbxN1.TabIndex = 1;
            // 
            // tbxN2
            // 
            this.tbxN2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxN2.Location = new System.Drawing.Point(245, 200);
            this.tbxN2.Name = "tbxN2";
            this.tbxN2.Size = new System.Drawing.Size(176, 20);
            this.tbxN2.TabIndex = 1;
            // 
            // tbxN3
            // 
            this.tbxN3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxN3.Location = new System.Drawing.Point(245, 238);
            this.tbxN3.Name = "tbxN3";
            this.tbxN3.Size = new System.Drawing.Size(176, 20);
            this.tbxN3.TabIndex = 1;
            // 
            // tbxMedia
            // 
            this.tbxMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxMedia.Location = new System.Drawing.Point(245, 315);
            this.tbxMedia.Name = "tbxMedia";
            this.tbxMedia.Size = new System.Drawing.Size(176, 20);
            this.tbxMedia.TabIndex = 1;
            this.tbxMedia.TextChanged += new System.EventHandler(this.tbxMedia_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(270, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxRecuperacao
            // 
            this.tbxRecuperacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxRecuperacao.Location = new System.Drawing.Point(601, 159);
            this.tbxRecuperacao.Name = "tbxRecuperacao";
            this.tbxRecuperacao.Size = new System.Drawing.Size(176, 20);
            this.tbxRecuperacao.TabIndex = 3;
            this.tbxRecuperacao.TextChanged += new System.EventHandler(this.tbxRecuperacao_TextChanged);
            // 
            // btnRecuperacao
            // 
            this.btnRecuperacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecuperacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecuperacao.Location = new System.Drawing.Point(631, 195);
            this.btnRecuperacao.Name = "btnRecuperacao";
            this.btnRecuperacao.Size = new System.Drawing.Size(122, 26);
            this.btnRecuperacao.TabIndex = 2;
            this.btnRecuperacao.Text = "Calcular";
            this.btnRecuperacao.UseVisualStyleBackColor = false;
            this.btnRecuperacao.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRecuperacao
            // 
            this.lblRecuperacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecuperacao.AutoSize = true;
            this.lblRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecuperacao.Location = new System.Drawing.Point(505, 160);
            this.lblRecuperacao.Name = "lblRecuperacao";
            this.lblRecuperacao.Size = new System.Drawing.Size(90, 16);
            this.lblRecuperacao.TabIndex = 0;
            this.lblRecuperacao.Text = "Recuperação";
            // 
            // lblResultadoRec
            // 
            this.lblResultadoRec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultadoRec.AutoSize = true;
            this.lblResultadoRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoRec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultadoRec.Location = new System.Drawing.Point(505, 243);
            this.lblResultadoRec.Name = "lblResultadoRec";
            this.lblResultadoRec.Size = new System.Drawing.Size(75, 16);
            this.lblResultadoRec.TabIndex = 0;
            this.lblResultadoRec.Text = "Resultado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(973, 619);
            this.Controls.Add(this.tbxRecuperacao);
            this.Controls.Add(this.btnRecuperacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxMedia);
            this.Controls.Add(this.tbxN3);
            this.Controls.Add(this.tbxN2);
            this.Controls.Add(this.tbxN1);
            this.Controls.Add(this.lblRecuperacao);
            this.Controls.Add(this.lblResultadoRec);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox tbxN1;
        private System.Windows.Forms.TextBox tbxN2;
        private System.Windows.Forms.TextBox tbxN3;
        private System.Windows.Forms.TextBox tbxMedia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxRecuperacao;
        private System.Windows.Forms.Button btnRecuperacao;
        private System.Windows.Forms.Label lblRecuperacao;
        private System.Windows.Forms.Label lblResultadoRec;
    }
}

