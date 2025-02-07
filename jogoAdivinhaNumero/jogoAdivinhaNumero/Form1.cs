using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoAdivinhaNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gerar um número aleatório entre 1 e 10
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 11);

            int numeroEscolhido = Convert.ToInt32(tbxNumero.Text);
            int creditos = Convert.ToInt32(lblCreditos.Text);

            if (creditos > 0)
            {
                if (numeroAleatorio == numeroEscolhido)
                {
                    creditos = creditos + 5;
                    lblCreditos.Text = creditos.ToString();
                    lblResultado.ForeColor = Color.Green;
                    lblResultado.Text = "Resultado: Parabéns você acertou!";
                }
                else
                {
                    creditos = creditos - 2;
                    lblCreditos.Text = creditos.ToString();
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Text = "Resultado: Você errou, número sorteado: " + numeroAleatorio;
                }
            }
            if (creditos == 0)
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Você está sem créditos. Clique no botão recarregar.";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            tbxNumero.Clear();
            lblResultado.Text = "Resultado: ";
            lblCreditos.Text = "10";
        }
    }
}
