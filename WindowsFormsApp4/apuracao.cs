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
    public partial class apuracao : Form
    {
        public apuracao()
        {
            InitializeComponent();
        }

        private void apuracao_Load(object sender, EventArgs e)
        {
            listarImagem();
        }

        private void listarImagem()
        {
            string c = WindowsFormsApp4.candidatos.img;

            pictureBox6.Image = Image.FromFile(c + "rosa.jpg");
            pictureBox7.Image = Image.FromFile(c + "roxo.jfif");
            pictureBox8.Image = Image.FromFile(c + "amarelo.jfif");
            pictureBox9.Image = Image.FromFile(c + "marrom.jfif");
            pictureBox10.Image = Image.FromFile(c + "azul.png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tack();
        }

        private void tack()
        {
            double votos = 0, totalVotos = 0, resultado = 0;

            if (WindowsFormsApp4.candidatos.totalVotos > 0)
            {
                totalVotos = WindowsFormsApp4.candidatos.totalVotos;
                votos = WindowsFormsApp4.candidatos.vUrsinhoRosa;
                resultado = votos / totalVotos *100;
                lbl_totalVotos.Text += " " + WindowsFormsApp4.candidatos.totalVotos;
                lbl_rosa.Text = "" + WindowsFormsApp4.candidatos.vUrsinhoRosa + " / " + resultado.ToString() + "%";


                votos = WindowsFormsApp4.candidatos.vUrsinhoRoxo;
                resultado = votos / totalVotos * 100;
                lbl_totalVotos.Text += " " + WindowsFormsApp4.candidatos.totalVotos;
                lbl_roxo.Text = "" + WindowsFormsApp4.candidatos.vUrsinhoRoxo + " / " + resultado.ToString() + "%";

                votos = WindowsFormsApp4.candidatos.vUrsinhoAmarelo;
                resultado = votos / totalVotos * 100;
                lbl_totalVotos.Text += " " + WindowsFormsApp4.candidatos.totalVotos;
                lbl_amarelo.Text = "" + WindowsFormsApp4.candidatos.vUrsinhoAmarelo + " / " + resultado.ToString() + "%";

                votos = WindowsFormsApp4.candidatos.vUrsinhoMarrom;
                resultado = votos / totalVotos * 100;
                lbl_totalVotos.Text += " " + WindowsFormsApp4.candidatos.totalVotos;
                lbl_marrom.Text = "" + WindowsFormsApp4.candidatos.vUrsinhoMarrom + " / " + resultado.ToString() + "%";

                votos = WindowsFormsApp4.candidatos.vUrsinhoAzul;
                resultado = votos / totalVotos * 100;
                lbl_totalVotos.Text += " " + WindowsFormsApp4.candidatos.totalVotos;
                lbl_azul.Text = "" + WindowsFormsApp4.candidatos.vUrsinhoAzul + " / " + resultado.ToString() + "%";
            }
            lbl_totalVotos.Text= "Total De Votos: " + WindowsFormsApp4.candidatos.totalVotos;
        }


        private double calcPorc(int votos, int totalVotos)
        {
            return (votos / totalVotos) * 100;
        }
    }
}
