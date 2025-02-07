namespace calculadora
{
    partial class Calculadora
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
            this.tbxN1 = new System.Windows.Forms.TextBox();
            this.tbxResultado = new System.Windows.Forms.TextBox();
            this.tbxN2 = new System.Windows.Forms.TextBox();
            this.tbxSoma = new System.Windows.Forms.Button();
            this.tbxSubtracao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxN1
            // 
            this.tbxN1.Location = new System.Drawing.Point(255, 136);
            this.tbxN1.Name = "tbxN1";
            this.tbxN1.Size = new System.Drawing.Size(172, 20);
            this.tbxN1.TabIndex = 3;
            // 
            // tbxResultado
            // 
            this.tbxResultado.Location = new System.Drawing.Point(255, 210);
            this.tbxResultado.Name = "tbxResultado";
            this.tbxResultado.Size = new System.Drawing.Size(172, 20);
            this.tbxResultado.TabIndex = 4;
            // 
            // tbxN2
            // 
            this.tbxN2.Location = new System.Drawing.Point(255, 173);
            this.tbxN2.Name = "tbxN2";
            this.tbxN2.Size = new System.Drawing.Size(172, 20);
            this.tbxN2.TabIndex = 5;
            this.tbxN2.TextChanged += new System.EventHandler(this.tbxN2_TextChanged);
            // 
            // tbxSoma
            // 
            this.tbxSoma.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxSoma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSoma.Location = new System.Drawing.Point(255, 236);
            this.tbxSoma.Name = "tbxSoma";
            this.tbxSoma.Size = new System.Drawing.Size(83, 23);
            this.tbxSoma.TabIndex = 6;
            this.tbxSoma.Text = "Soma";
            this.tbxSoma.UseVisualStyleBackColor = false;
            this.tbxSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxSubtracao
            // 
            this.tbxSubtracao.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubtracao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSubtracao.Location = new System.Drawing.Point(344, 236);
            this.tbxSubtracao.Name = "tbxSubtracao";
            this.tbxSubtracao.Size = new System.Drawing.Size(83, 23);
            this.tbxSubtracao.TabIndex = 7;
            this.tbxSubtracao.Text = "Subtração";
            this.tbxSubtracao.UseVisualStyleBackColor = false;
            this.tbxSubtracao.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(255, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Multiplicação";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(344, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Divisão";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(663, 417);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxSubtracao);
            this.Controls.Add(this.tbxSoma);
            this.Controls.Add(this.tbxN2);
            this.Controls.Add(this.tbxResultado);
            this.Controls.Add(this.tbxN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxN1;
        private System.Windows.Forms.TextBox tbxResultado;
        private System.Windows.Forms.TextBox tbxN2;
        private System.Windows.Forms.Button tbxSoma;
        private System.Windows.Forms.Button tbxSubtracao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

