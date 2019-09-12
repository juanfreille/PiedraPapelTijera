using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PiedraPapelTijera
{
    public partial class FrmPiedraPapelTijera : Form
    {
        public FrmPiedraPapelTijera()
        {
            InitializeComponent();
        }

        private void LblScore1_Click(object sender, EventArgs e)
        {

        }
        Int32 PPT = 0;
        Int32 Score1 = 0;
        Int32 Score2 = 0;
        Random R = new Random();

        private void CmdPiedra_Click(object sender, EventArgs e)
        {

            ImgJugador.Image = PiedraPapelTijera.Properties.Resources.piedra;
            PPT = R.Next(1, 4);
            switch (PPT)
            {
                case 1:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.piedra;
                    LblResultado.Text = "Empate";
                    break;
                case 2:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.Papel;
                    LblResultado.Text = "Perdiste";
                    Score2 = Score2 + 1;
                    break;
                case 3:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.Tijera;
                    LblResultado.Text = "Ganaste";
                    Score1 = Score1 + 1;
                    break;


            }
            
            LblScore1.Text = Convert.ToString(Score1);
            LblScore2.Text = Convert.ToString(Score2);
            if (Score1 == 3 ^ Score2 == 3)
            {
                Score1 = 0;
                Score2 = 0;
            }
        }

        private void CmdPapel_Click(object sender, EventArgs e)
        {
            ImgJugador.Image = PiedraPapelTijera.Properties.Resources.Papel;
            PPT = R.Next(1, 4);
            switch (PPT)
            {
                case 1:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.piedra;
                    LblResultado.Text = "Ganaste";
                    Score1 = Score1 + 1;
                    break;
                case 2:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.Papel;
                    LblResultado.Text = "Empate";
                    break;
                case 3:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.Tijera;
                    LblResultado.Text = "Perdiste";
                    Score2 = Score2 + 1;
                    break;
            }
            LblScore1.Text = Convert.ToString(Score1);
            LblScore2.Text = Convert.ToString(Score2);
            if (Score1 == 3 ^ Score2 == 3)
            {
                Score1 = 0;
                Score2 = 0;
            }
        }

        private void CmdTijera_Click(object sender, EventArgs e)
        {
            ImgJugador.Image = PiedraPapelTijera.Properties.Resources.Tijera;
            PPT = R.Next(1, 4);
            switch (PPT)
            {
                case 1:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.piedra;
                    LblResultado.Text = "Perdiste";
                    Score2 = Score2 + 1;
                    break;
                case 2:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.Papel;
                    LblResultado.Text = "Ganaste";
                    Score1 = Score1 + 1;
                    break;
                case 3:
                    ImgComputadora.Image = PiedraPapelTijera.Properties.Resources.Tijera;
                    LblResultado.Text = "Empate";
                    break;
            }
            LblScore1.Text = Convert.ToString(Score1);
            LblScore2.Text = Convert.ToString(Score2);
            if (Score1 == 3 ^ Score2 == 3)
            {
                Score1 = 0;
                Score2 = 0;
            }
        }
    }
}
