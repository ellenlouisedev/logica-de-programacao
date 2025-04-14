namespace notas
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
            this.tbxN1 = new System.Windows.Forms.TextBox();
            this.tbxN2 = new System.Windows.Forms.TextBox();
            this.tbxN3 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.Maior = new System.Windows.Forms.Button();
            this.Menor = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nota 3";
            // 
            // tbxN1
            // 
            this.tbxN1.Location = new System.Drawing.Point(150, 115);
            this.tbxN1.Name = "tbxN1";
            this.tbxN1.Size = new System.Drawing.Size(212, 20);
            this.tbxN1.TabIndex = 1;
            // 
            // tbxN2
            // 
            this.tbxN2.Location = new System.Drawing.Point(150, 158);
            this.tbxN2.Name = "tbxN2";
            this.tbxN2.Size = new System.Drawing.Size(212, 20);
            this.tbxN2.TabIndex = 1;
            // 
            // tbxN3
            // 
            this.tbxN3.Location = new System.Drawing.Point(150, 204);
            this.tbxN3.Name = "tbxN3";
            this.tbxN3.Size = new System.Drawing.Size(212, 20);
            this.tbxN3.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(98, 275);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // Maior
            // 
            this.Maior.Location = new System.Drawing.Point(410, 116);
            this.Maior.Name = "Maior";
            this.Maior.Size = new System.Drawing.Size(88, 23);
            this.Maior.TabIndex = 2;
            this.Maior.Text = "Maior número";
            this.Maior.UseVisualStyleBackColor = true;
            this.Maior.Click += new System.EventHandler(this.Maior_Click);
            // 
            // Menor
            // 
            this.Menor.Location = new System.Drawing.Point(410, 159);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(88, 23);
            this.Menor.TabIndex = 2;
            this.Menor.Text = "Menor número";
            this.Menor.UseVisualStyleBackColor = true;
            this.Menor.Click += new System.EventHandler(this.Maior_Click);
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(410, 204);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(88, 23);
            this.Soma.TabIndex = 2;
            this.Soma.Text = "Soma";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Maior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 462);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Menor);
            this.Controls.Add(this.Maior);
            this.Controls.Add(this.tbxN3);
            this.Controls.Add(this.tbxN2);
            this.Controls.Add(this.tbxN1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxN1;
        private System.Windows.Forms.TextBox tbxN2;
        private System.Windows.Forms.TextBox tbxN3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button Maior;
        private System.Windows.Forms.Button Menor;
        private System.Windows.Forms.Button Soma;
    }
}

