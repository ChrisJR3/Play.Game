using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play.Game
{
    public partial class BlackGreen : Form
    {
        public BlackGreen()
        {
            InitializeComponent();
        }

        private void PlayGame_Click(object sender, EventArgs e)
        {
            GameStart.ForeColor = Color.White;
            PlayGame.Visible = false;

            GameStart.Text = "Game Will Start in: 3";
            Refresh();
            Thread.Sleep(1000);

            GameStart.Text = "Game Will Start in: 2";
            Refresh();
            Thread.Sleep(600);

            GameStart.Text = "Game Will Start in: 1";
            SoundPlayer player = new SoundPlayer(Properties.Resources.DingSound1);
            player.Play();
            Refresh();
            Thread.Sleep(400);

            GameStart.Visible = true;
            GameStart.Text = "GO!!";
            GameStart.BackColor = Color.Green;
            GameStart.ForeColor = Color.White;
            BackColor = Color.Green;
            Refresh();
            Thread.Sleep(500);

            GameStart.Text = ".";
            GameStart.Visible = false;
            BackColor = Color.Black;
            Refresh();
            Thread.Sleep(300);

            GameStart.Visible = true;
            GameStart.Text = "GO!!";
            GameStart.BackColor = Color.Green;
            GameStart.ForeColor = Color.White;
            BackColor = Color.Green;
            Refresh();
            Thread.Sleep(500);

            GameStart.Visible = false;
            BackColor = Color.Black;
            Refresh();
            Thread.Sleep(300);

            GameStart.Visible = true;
            GameStart.Text = "GO!!";
            GameStart.BackColor = Color.Green;
            GameStart.ForeColor = Color.White;
            BackColor = Color.Green;
            Refresh();
            Thread.Sleep(500);

            GameStart.Visible = false;
            BackColor = Color.Black;
            Refresh();

            //Start of Pac Man Code

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redbrush = new SolidBrush(Color.Red);
            SolidBrush greenbrush = new SolidBrush(Color.Green);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Italic);
            Font Large = new Font("TimesNewRoman", 40, FontStyle.Italic);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 45, 45, 60, 60, 25, 315);

            Thread.Sleep(250);


            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 55, 45, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 65, 45, 60, 60, 25, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 75, 45, 60, 60, 0, 360);

            Thread.Sleep(250);


            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 85, 45, 60, 60, 25, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 95, 45, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 105, 45, 60, 60, 25, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 115, 45, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 125, 45, 60, 60, 25, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 135, 45, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 155, 45, 60, 60, 25, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 165, 45, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 175, 45, 60, 60, 25, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 185, 45, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 195, 45, 60, 60, 25, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 205, 45, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 45, 60, 60, 25, 315);

            Thread.Sleep(250);

            //This is the middlle

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 55, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 65, 60, 60, 113, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 75, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 85, 60, 60, 113, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 95, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 105, 60, 60, 113, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 115, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 125, 60, 60, 113, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 135, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 145, 60, 60, 113, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 155, 60, 60, 0, 360);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 165, 60, 60, 113, 315);

            Thread.Sleep(250);

            g.Clear(Color.Black);

            g.DrawLine(drawPen, 25, 25, 300, 25);

            g.DrawLine(drawPen, 25, 125, 200, 125);

            g.DrawLine(drawPen, 300, 20, 300, 225);

            g.DrawLine(drawPen, 200, 120, 200, 225);

            g.FillPie(yellowBrush, 215, 175, 60, 60, 0, 360);

            g.DrawString("Congratulations", drawFont, whiteBrush, 25, 50);

            Thread.Sleep(2500);

            g.Clear(Color.Green);

            g.DrawEllipse(drawPen, Width / 2 - 100, 100, 300, Height / 2 - 100);
            g.FillEllipse(redbrush, Width / 2 - 100, 100, 300, Height / 2 - 100);

            g.DrawString("C", Large, whiteBrush, Width / 2 - 100, Height / 2 - 100);
            g.DrawString("Rams", drawFont, whiteBrush, Width / 2 - 50, Height / 2 - 75);

            Thread.Sleep(7500);

            BackColor = Color.Black;

            PlayGame.Visible = true;
        }
    }
}
