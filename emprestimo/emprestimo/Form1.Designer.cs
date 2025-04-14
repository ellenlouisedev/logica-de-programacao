namespace emprestimo
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
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRenda = new System.Windows.Forms.TextBox();
            this.rbId1 = new System.Windows.Forms.RadioButton();
            this.rbId2 = new System.Windows.Forms.RadioButton();
            this.rbId3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb1ano = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNP = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análise de crédito";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor do empréstimo";
            // 
            // tbxValor
            // 
            this.tbxValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxValor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxValor.Location = new System.Drawing.Point(329, 129);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(146, 20);
            this.tbxValor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Score";
            // 
            // tbxScore
            // 
            this.tbxScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxScore.Location = new System.Drawing.Point(329, 205);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(146, 20);
            this.tbxScore.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Renda mensal";
            // 
            // tbxRenda
            // 
            this.tbxRenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxRenda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxRenda.Location = new System.Drawing.Point(329, 242);
            this.tbxRenda.Name = "tbxRenda";
            this.tbxRenda.Size = new System.Drawing.Size(146, 20);
            this.tbxRenda.TabIndex = 1;
            // 
            // rbId1
            // 
            this.rbId1.AutoSize = true;
            this.rbId1.Location = new System.Drawing.Point(49, 30);
            this.rbId1.Name = "rbId1";
            this.rbId1.Size = new System.Drawing.Size(89, 17);
            this.rbId1.TabIndex = 2;
            this.rbId1.TabStop = true;
            this.rbId1.Text = "Entre 14 e 20";
            this.rbId1.UseVisualStyleBackColor = true;
            // 
            // rbId2
            // 
            this.rbId2.AutoSize = true;
            this.rbId2.Location = new System.Drawing.Point(49, 53);
            this.rbId2.Name = "rbId2";
            this.rbId2.Size = new System.Drawing.Size(89, 17);
            this.rbId2.TabIndex = 2;
            this.rbId2.TabStop = true;
            this.rbId2.Text = "Entre 21 e 65";
            this.rbId2.UseVisualStyleBackColor = true;
            // 
            // rbId3
            // 
            this.rbId3.AutoSize = true;
            this.rbId3.Location = new System.Drawing.Point(49, 76);
            this.rbId3.Name = "rbId3";
            this.rbId3.Size = new System.Drawing.Size(110, 17);
            this.rbId3.TabIndex = 2;
            this.rbId3.TabStop = true;
            this.rbId3.Text = "Acima de 65 anos";
            this.rbId3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbId2);
            this.groupBox1.Controls.Add(this.rbId3);
            this.groupBox1.Controls.Add(this.rbId1);
            this.groupBox1.Location = new System.Drawing.Point(280, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faixa etária";
            // 
            // cb1ano
            // 
            this.cb1ano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb1ano.AutoSize = true;
            this.cb1ano.Location = new System.Drawing.Point(265, 432);
            this.cb1ano.Name = "cb1ano";
            this.cb1ano.Size = new System.Drawing.Size(210, 17);
            this.cb1ano.TabIndex = 4;
            this.cb1ano.Text = "Está a mais de 1 ano no atual emprego";
            this.cb1ano.UseVisualStyleBackColor = true;
            this.cb1ano.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(389, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Analisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número de parcelas";
            // 
            // cbxNP
            // 
            this.cbxNP.FormattingEnabled = true;
            this.cbxNP.Items.AddRange(new object[] {
            "12",
            "24",
            "36",
            "48"});
            this.cbxNP.Location = new System.Drawing.Point(329, 163);
            this.cbxNP.Name = "cbxNP";
            this.cbxNP.Size = new System.Drawing.Size(146, 21);
            this.cbxNP.TabIndex = 6;
            this.cbxNP.Text = "24";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 605);
            this.Controls.Add(this.cbxNP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb1ano);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxRenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRenda;
        private System.Windows.Forms.RadioButton rbId1;
        private System.Windows.Forms.RadioButton rbId2;
        private System.Windows.Forms.RadioButton rbId3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb1ano;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNP;
    }
}

