using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passeios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSugestao.Visible = false;
            pictureBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clima = (cbxClima.Text);
            double dinheiro = Convert.ToDouble(tbxDinheiro.Text);

            if (clima == "Sol" && dinheiro < 3000)
            {
                lblSugestao.Visible = true;
                lblSugestao.Text = "Sua sujestão de passeio: Fortaleza, Brasil";
                pictureBox1.Image = Properties.Resources.fortaleza;
                pictureBox1.Visible = true;
            }
            if (clima == "Sol" && dinheiro >= 3000)
            {
                lblSugestao.Visible = true;
                lblSugestao.Text = "Sua sujestão de passeio: Cancún, Mexico";
                pictureBox1.Image = Properties.Resources.cancun;
                pictureBox1.Visible = true;
            }
            if (clima == "Chuva" && dinheiro < 3000)
            {
                lblSugestao.Visible = true;
                lblSugestao.Text = "Sua sujestão de passeio: Belém, Brasil";
                pictureBox1.Image = Properties.Resources.belem;
                pictureBox1.Visible = true;
            }
            if (clima == "Chuva" && dinheiro >= 3000)
            {
                lblSugestao.Visible = true;
                lblSugestao.Text = "Sua sujestão de passeio: Londres, Reino Unido";
                pictureBox1.Image = Properties.Resources.londres;
                pictureBox1.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
