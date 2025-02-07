using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pegar o valor do textbox tbxN1
            double n1 = Convert.ToDouble(tbxN1.Text);
            // Pegar o valor do textbox tbxN2
            double n2 = Convert.ToDouble(tbxN2.Text);
            // Somar
            double resultado = n1 + n2;
            // Inserir o resultado no tbxResultado
            tbxResultado.Text = resultado.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Pegar o valor do textbox tbxN1
            double n1 = Convert.ToDouble(tbxN1.Text);
            // Pegar o valor do textbox tbxN2
            double n2 = Convert.ToDouble(tbxN2.Text);
            // Subtrair
            double resultado = n1 - n2;
            // Inserir o resultado no tbxResultado
            tbxResultado.Text = resultado.ToString();
        }

        private void tbxN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Pegar o valor do textbox tbxN1
            double n1 = Convert.ToDouble(tbxN1.Text);
            // Pegar o valor do textbox tbxN2
            double n2 = Convert.ToDouble(tbxN2.Text);
            // Multiplicar
            double resultado = n1 * n2;
            // Inserir o resultado no tbxResultado
            tbxResultado.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pegar o valor do textbox tbxN1
            double n1 = Convert.ToDouble(tbxN1.Text);
            // Pegar o valor do textbox tbxN2
            double n2 = Convert.ToDouble(tbxN2.Text);
            // Dividir
            double resultado = n1 / n2;
            // Inserir o resultado no tbxResultado
            tbxResultado.Text = resultado.ToString();
        }
    }
}
