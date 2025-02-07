using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbxNota1.Text);
            double n2 = Convert.ToDouble(tbxNota2.Text);
            double n3 = Convert.ToDouble(tbxNota3.Text);

            double media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {
                lblResultado.ForeColor = Color.LightGreen;
                lblResultado.Text = "Resultado: Aluno aprovado com média " + media.ToString("F1");
                pictureBox1.Image = Properties.Resources.aprovado;
                pictureBox1.Visible = true;
            }

            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Resultado: Aluno reprovado com média " + media.ToString("F1");
                pictureBox1.Image = Properties.Resources.reprovado;
                pictureBox1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbxNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
