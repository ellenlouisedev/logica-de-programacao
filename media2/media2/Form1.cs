using System;
using System.Drawing;
using System.Windows.Forms;

namespace media2
{
    public partial class Form1 : Form
    {
        public int cont = 0;
        public Form1()
        {
            InitializeComponent();
            lblRecuperacao.Visible = false;
            tbxRecuperacao.Visible = false;
            btnRecuperacao.Visible = false;
            lblResultadoRec.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double n3 = Convert.ToDouble(tbxN3.Text);

            double media = (n1 + n2 + n3) / 3;
            tbxMedia.Text = media.ToString("F1");

            if (media < 4) //reprovado
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Resultado: Aluno reprovado sem chance de recuperação.";
            }

            if (media >= 7) // aprovado
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "Resultado: Aluno aprovado";
            }

            if (media >= 4 && media < 7) // recuperação
            {
                lblResultado.ForeColor = Color.Orange;
                lblResultado.Text = "Resultado: Aluno de recuperação";
                lblRecuperacao.Visible = true;
                tbxRecuperacao.Visible = true;
                btnRecuperacao.Visible = true;
                lblResultadoRec.Visible = true;
            }
        
        }

        private void tbxMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Regra para a recuperação: Média + notaRecuperação >= 10
            if (cont == 0)
            {
                cont++;

                double media = Convert.ToDouble(tbxMedia.Text);
                double notaRec = Convert.ToDouble(tbxRecuperacao.Text);

                double total = media + notaRec;
                tbxRecuperacao.Text = total.ToString("F1");

                if (total >= 10)
                {
                    lblResultado.ForeColor = Color.Green;
                    lblResultadoRec.Text = "Resultado: Aprovado com recuperação";
                }
                else
                {
                    lblResultado.ForeColor = Color.Red;
                    lblResultadoRec.Text = "Resultado: Reprovado";
                }
            }
        }

        private void tbxRecuperacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
