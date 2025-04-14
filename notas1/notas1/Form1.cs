using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            // Criar um vetor com 3 espaços
            double[] notas = new double[3];
            // Inserir informações em locais diferentes do vetor
            notas[0] = Convert.ToDouble(tbxN1.Text);
            notas[1] = Convert.ToDouble(tbxN2.Text);
            notas[2] = Convert.ToDouble(tbxN3.Text);

            if (notas[0] > notas[1] && notas[0] > notas[2])
            {
                lblResultado.Text = notas[0] + " é a maior nota";
            }
            if (notas[1] > notas[0] && notas[1] > notas[2])
            {
                lblResultado.Text = notas[1] + " é a maior nota";
            }
            if (notas[2] > notas[0] && notas[2] > notas[1])
            {
                lblResultado.Text = notas[2] + " é a maior nota";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double[] notas = new double[3];
            notas[0] = Convert.ToDouble(tbxN1.Text);
            notas[1] = Convert.ToDouble(tbxN2.Text);
            notas[2] = Convert.ToDouble(tbxN3.Text);

            if (notas[0] < notas[1] && notas[0] < notas[2])
            {
                lblResultado.Text = notas[0] + " é a menor nota";
            }
            if (notas[1] < notas[0] && notas[1] < notas[2])
            {
                lblResultado.Text = notas[1] + " é a menor nota";
            }
            if (notas[2] < notas[0] && notas[2] < notas[1])
            {
                lblResultado.Text = notas[2] + " é a menor nota";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double[] notas = new double[3];
            notas[0] = Convert.ToDouble(tbxN1.Text);
            notas[1] = Convert.ToDouble(tbxN2.Text);
            notas[2] = Convert.ToDouble(tbxN3.Text);

            double soma = notas[0] + notas[1] + notas[2];

            lblResultado.Text = soma + " é a soma das notas";
        }*/
    }
}
