using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Urna : Form
    {
        string c = WindowsFormsApp4.candidatos.img;
        public Urna()
        {
            InitializeComponent();
        }

        /* 
       10 Urisnho Rosa
    20 Ursinho Roxo
    30 Ursinho Amarelo
    40 Ursinho Marrom
    50 Ursinho Azul
        */

        private void text_number_TextChanged(object sender, EventArgs e)
        {
            if (text_number.Text.Length == 2)
            {

                if (text_number.Text == "")
                {
                    lab_1.Text = WindowsFormsApp4.candidatos.vota;
                    pictureBox1.Image = Image.FromFile(c + "vota.jfif");
                }

                else if (text_number.Text == "10")
                {
                    lab_1.Text = WindowsFormsApp4.candidatos.UrisnhoRosa;
                    pictureBox1.Image = Image.FromFile(c + "rosa.jpg");
                }


                else if (text_number.Text == "20")
                {
                    lab_1.Text = WindowsFormsApp4.candidatos.UrsinhoRoxo;
                    pictureBox1.Image = Image.FromFile(c + "roxo.jfif");

                }
                else if (text_number.Text == "30")
                {
                    lab_1.Text = WindowsFormsApp4.candidatos.UrsinhoAmarelo;
                    pictureBox1.Image = Image.FromFile(c + "amarelo.jfif");

                }
                else if (text_number.Text == "40")
                {
                    lab_1.Text = WindowsFormsApp4.candidatos.UrsinhoMarrom;
                    pictureBox1.Image = Image.FromFile(c + "marrom.jfif");

                }
                else if (text_number.Text == "50")
                {
                    lab_1.Text = WindowsFormsApp4.candidatos.UrsinhoAzul;
                    pictureBox1.Image = Image.FromFile(c + "azul.png");

                }
                else
                {
                    MessageBox.Show("Candidato Invalido");
                }
            }
        }
        private void text_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (button_confirm.Enabled == true)
                {
                    votar();
                }
            }
        }

        private void votar()
        {
            if (text_number.Text == "10")
            {
                WindowsFormsApp4.candidatos.vUrsinhoRosa++;
            }
            else if (text_number.Text == "20")
            {
                WindowsFormsApp4.candidatos.vUrsinhoRoxo++;
            }
            else if (text_number.Text == "30")
            {
                WindowsFormsApp4.candidatos.vUrsinhoAmarelo++;
            }
            else if (text_number.Text == "40")
            {
                WindowsFormsApp4.candidatos.vUrsinhoMarrom++;
            }
            else if (text_number.Text == "50")
            {
                WindowsFormsApp4.candidatos.vUrsinhoAzul++;
            }
            else if (button_branco.Enabled == true)
            {
                WindowsFormsApp4.candidatos.vbranco++;
            }
            WindowsFormsApp4.candidatos.totalVotos++;
            MessageBox.Show("Votação Finalizada");
            text_number.Text = "";
            pictureBox1.Image = Image.FromFile(c + "vota.jfif");
        }

        private void Urna_Load(object sender, EventArgs e)
        {
            apuracao frmapuracao = new apuracao();
            frmapuracao.Show();
        }
    }
}

