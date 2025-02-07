using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pegar o número de vitórias
            double vitorias = Convert.ToDouble(tbxVitorias.Text);
            // Pegar o número de empates
            double empates = Convert.ToDouble(tbxEmpates.Text);
            // Pegar o número de derrotas
            double derrotas = Convert.ToDouble(tbxDerrotas.Text);
            // Calcular a pontuação
            double resultado = vitorias * 3 + empates;
            // Mostrar o resultado
            lblresultado.Text = resultado.ToString();
        }
    }
}