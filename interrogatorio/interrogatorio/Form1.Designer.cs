namespace interrogatorio
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.cbP1 = new System.Windows.Forms.RadioButton();
            this.cbP2 = new System.Windows.Forms.RadioButton();
            this.cbP3 = new System.Windows.Forms.RadioButton();
            this.cbP4 = new System.Windows.Forms.RadioButton();
            this.cbP5 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interrogatório";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(360, 325);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(135, 16);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado da análise";
            // 
            // cbP1
            // 
            this.cbP1.AutoSize = true;
            this.cbP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP1.Location = new System.Drawing.Point(78, 109);
            this.cbP1.Name = "cbP1";
            this.cbP1.Size = new System.Drawing.Size(173, 20);
            this.cbP1.TabIndex = 1;
            this.cbP1.TabStop = true;
            this.cbP1.Text = "Telefonou para a vítima?";
            this.cbP1.UseVisualStyleBackColor = true;
            // 
            // cbP2
            // 
            this.cbP2.AutoSize = true;
            this.cbP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP2.Location = new System.Drawing.Point(78, 148);
            this.cbP2.Name = "cbP2";
            this.cbP2.Size = new System.Drawing.Size(179, 20);
            this.cbP2.TabIndex = 1;
            this.cbP2.TabStop = true;
            this.cbP2.Text = "Esteve no local do crime?";
            this.cbP2.UseVisualStyleBackColor = true;
            // 
            // cbP3
            // 
            this.cbP3.AutoSize = true;
            this.cbP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP3.Location = new System.Drawing.Point(78, 185);
            this.cbP3.Name = "cbP3";
            this.cbP3.Size = new System.Drawing.Size(154, 20);
            this.cbP3.TabIndex = 1;
            this.cbP3.TabStop = true;
            this.cbP3.Text = "Mora perto da vítima?";
            this.cbP3.UseVisualStyleBackColor = true;
            // 
            // cbP4
            // 
            this.cbP4.AutoSize = true;
            this.cbP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP4.Location = new System.Drawing.Point(78, 218);
            this.cbP4.Name = "cbP4";
            this.cbP4.Size = new System.Drawing.Size(148, 20);
            this.cbP4.TabIndex = 1;
            this.cbP4.TabStop = true;
            this.cbP4.Text = "Devia para a vítima?";
            this.cbP4.UseVisualStyleBackColor = true;
            // 
            // cbP5
            // 
            this.cbP5.AutoSize = true;
            this.cbP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP5.Location = new System.Drawing.Point(78, 254);
            this.cbP5.Name = "cbP5";
            this.cbP5.Size = new System.Drawing.Size(184, 20);
            this.cbP5.TabIndex = 1;
            this.cbP5.TabStop = true;
            this.cbP5.Text = "Já trabalhou com a vítima?";
            this.cbP5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(78, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Analisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::interrogatorio.Properties.Resources.culpado;
            this.pictureBox1.Location = new System.Drawing.Point(363, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbP5);
            this.Controls.Add(this.cbP4);
            this.Controls.Add(this.cbP3);
            this.Controls.Add(this.cbP2);
            this.Controls.Add(this.cbP1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton cbP1;
        private System.Windows.Forms.RadioButton cbP2;
        private System.Windows.Forms.RadioButton cbP3;
        private System.Windows.Forms.RadioButton cbP4;
        private System.Windows.Forms.RadioButton cbP5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

