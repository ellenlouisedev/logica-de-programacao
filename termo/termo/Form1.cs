using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termo
{
    public partial class Form1 : Form
    {
        // Vetor com 10 palavras
        String[] palavras = { "carta", "vento", "pluma", "festa", "nuvem", "tigre", "verde", "ramos", "folha", "bravo" };
        String termo;
        int contLinhas = 1;
        private int j;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Gerar número aleátorio entre 0 e 8
            Random random = new Random();
            int i = random.Next(-0, 10);
            // Definir o termo
            termo = palavras[i];
            lblTeste.Text = termo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Char[] letras = new Char[5];
            if (contLinhas == 1)
            {
                letras[0] = Convert.ToChar(tbx1.Text);
                letras[1] = Convert.ToChar(tbx2.Text);
                letras[2] = Convert.ToChar(tbx3.Text);
                letras[3] = Convert.ToChar(tbx4.Text);
                letras[4] = Convert.ToChar(tbx5.Text);
                // Verificar por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };

                // Verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }

                }

                // Verificar letra por letra
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }

                // Mudar a cor

                // Primeira linha
                if (gabarito[0] == "tem")
                {
                    tbx1.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx1.BackColor = Color.Green;
                }
                if (gabarito[1] == "tem")
                {
                    tbx2.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx2.BackColor = Color.Green;
                }
                if (gabarito[2] == "tem")
                {
                    tbx3.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx3.BackColor = Color.Green;
                }
                if (gabarito[3] == "tem")
                {
                    tbx4.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx4.BackColor = Color.Green;
                }
                if (gabarito[4] == "tem")
                {
                    tbx5.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx5.BackColor = Color.Green;
                }

                // Desbloquear os textbox da linha 2
                tbx6.Enabled = true;
                tbx7.Enabled = true;
                tbx8.Enabled = true;
                tbx9.Enabled = true;
                tbx10.Enabled = true;

            }
            // Segunda linha
            if (contLinhas == 2)
            {
                letras[0] = Convert.ToChar(tbx6.Text);
                letras[1] = Convert.ToChar(tbx7.Text);
                letras[2] = Convert.ToChar(tbx8.Text);
                letras[3] = Convert.ToChar(tbx9.Text);
                letras[4] = Convert.ToChar(tbx10.Text);
                // Verificar por letra
                String[] gabarito = { "não", "não", "não", "não", "não"};

                // Verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }

                }

                // Verificar letra por letra
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }

                // Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx6.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx6.BackColor = Color.Green;
                }
                if (gabarito[1] == "tem")
                {
                    tbx7.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx7.BackColor = Color.Green;
                }
                if (gabarito[2] == "tem")
                {
                    tbx8.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx8.BackColor = Color.Green;
                }
                if (gabarito[3] == "tem")
                {
                    tbx9.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx9.BackColor = Color.Green;
                }
                if (gabarito[4] == "tem")
                {
                    tbx10.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx10.BackColor = Color.Green;
                }
                // Desbloquear os textbox da linha 3
                tbx11.Enabled = true;
                tbx12.Enabled = true;
                tbx13.Enabled = true;
                tbx14.Enabled = true;
                tbx15.Enabled = true;

            }
            // Terceira linha
            if (contLinhas == 3)
            {
                letras[0] = Convert.ToChar(tbx11.Text);
                letras[1] = Convert.ToChar(tbx12.Text);
                letras[2] = Convert.ToChar(tbx13.Text);
                letras[3] = Convert.ToChar(tbx14.Text);
                letras[4] = Convert.ToChar(tbx15.Text);
                // Verificar por letra
                String[] gabarito = { "não", "não", "não", "não", "não"};

                // Verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }

                }

                // Verificar letra por letra
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }

                // Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx11.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx11.BackColor = Color.Green;
                }
                if (gabarito[1] == "tem")
                {
                    tbx12.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx12.BackColor = Color.Green;
                }
                if (gabarito[2] == "tem")
                {
                    tbx13.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx13.BackColor = Color.Green;
                }
                if (gabarito[3] == "tem")
                {
                    tbx14.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx14.BackColor = Color.Green;
                }
                if (gabarito[4] == "tem")
                {
                    tbx15.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx15.BackColor = Color.Green;
                }
                // Desbloquear os textbox da linha 4
                tbx16.Enabled = true;
                tbx17.Enabled = true;
                tbx18.Enabled = true;
                tbx19.Enabled = true;
                tbx20.Enabled = true;

            }
            // Quarta linha
            if (contLinhas == 4)
            {
                letras[0] = Convert.ToChar(tbx16.Text);
                letras[1] = Convert.ToChar(tbx17.Text);
                letras[2] = Convert.ToChar(tbx18.Text);
                letras[3] = Convert.ToChar(tbx19.Text);
                letras[4] = Convert.ToChar(tbx20.Text);
                // Verificar por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };

                // Verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }

                }

                // Verificar letra por letra
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }

                // Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx16.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx16.BackColor = Color.Green;
                }
                if (gabarito[1] == "tem")
                {
                    tbx17.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx17.BackColor = Color.Green;
                }
                if (gabarito[2] == "tem")
                {
                    tbx18.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx18.BackColor = Color.Green;
                }
                if (gabarito[3] == "tem")
                {
                    tbx19.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx19.BackColor = Color.Green;
                }
                if (gabarito[4] == "tem")
                {
                    tbx20.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx20.BackColor = Color.Green;
                }
                // Desbloquear os textbox da linha 5
                tbx21.Enabled = true;
                tbx22.Enabled = true;
                tbx23.Enabled = true;
                tbx24.Enabled = true;
                tbx25.Enabled = true;
            }
            // Quinta linha
            if (contLinhas == 5)
            {
                letras[0] = Convert.ToChar(tbx21.Text);
                letras[1] = Convert.ToChar(tbx22.Text);
                letras[2] = Convert.ToChar(tbx23.Text);
                letras[3] = Convert.ToChar(tbx24.Text);
                letras[4] = Convert.ToChar(tbx25.Text);
                // Verificar por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };

                // Verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }

                }

                // Verificar letra por letra
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }

                // Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx21.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx21.BackColor = Color.Green;
                }
                if (gabarito[1] == "tem")
                {
                    tbx22.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx22.BackColor = Color.Green;
                }
                if (gabarito[2] == "tem")
                {
                    tbx23.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx23.BackColor = Color.Green;
                }
                if (gabarito[3] == "tem")
                {
                    tbx24.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx24.BackColor = Color.Green;
                }
                if (gabarito[4] == "tem")
                {
                    tbx25.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx25.BackColor = Color.Green;
                }
                // Desbloquear os textbox da linha 6
                tbx26.Enabled = true;
                tbx27.Enabled = true;
                tbx28.Enabled = true;
                tbx29.Enabled = true;
                tbx30.Enabled = true;
            }
            // Sexta linha
            if (contLinhas == 6)
            {
                letras[0] = Convert.ToChar(tbx26.Text);
                letras[1] = Convert.ToChar(tbx27.Text);
                letras[2] = Convert.ToChar(tbx28.Text);
                letras[3] = Convert.ToChar(tbx29.Text);
                letras[4] = Convert.ToChar(tbx30.Text);
                // Verificar por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };

                // Verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }

                }

                // Verificar letra por letra
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }

                // Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx26.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx26.BackColor = Color.Green;
                }
                if (gabarito[1] == "tem")
                {
                    tbx27.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx27.BackColor = Color.Green;
                }
                if (gabarito[2] == "tem")
                {
                    tbx28.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx28.BackColor = Color.Green;
                }
                if (gabarito[3] == "tem")
                {
                    tbx29.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx29.BackColor = Color.Green;
                }
                if (gabarito[4] == "tem")
                {
                    tbx30.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx30.BackColor = Color.Green;
                }
            }


            // Verificar se ganhou
            int acertos = 0;
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == termo[i])
                {
                    acertos++;
                }
            }
            if (acertos == 5)
            {
                MessageBox.Show("Você ganhou", "Termo");
            }
            else if (contLinhas < 6)
            {
                contLinhas++;
            }
            else
            {
                MessageBox.Show("Você perdeu", "Termo");
            }
        }
    }
}