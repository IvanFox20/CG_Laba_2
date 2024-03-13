using CG_Laba_2.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CG_Laba_2
{
    public partial class Ping_Pong : Form
    {

        Graphics g;
        Timer timer = new Timer();
        Circle ball;
        Rect player;

        int FPS = 144;
        float playerY;
        int score;

        int ballSpeedX = 3;
        int ballSpeedY = 3;
        public Ping_Pong()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            timer.Enabled = true;
            timer.Interval = 1000 / FPS;
            timer.Tick += new EventHandler(TimerCallback);
            this.KeyDown += Ping_Pong_KeyDown;
            ball = new Circle(this.Width / 2 - 15, this.Height / 2 - 30);
            player = new Rect(20, this.Height / 2 - 60);
        }

        void UpdateBall()
        {
            ball.TransferX(ballSpeedX);
            ball.TransferY(ballSpeedY);
            float ballX = ball.GetX();
            float ballY = ball.GetY();

            if (ballX + 30 > this.Width)
            {
                ballSpeedX = -ballSpeedX;
            }

            if (ballY < 0 || ballY + 60 > this.Height)
            {
                ballSpeedY = -ballSpeedY;
            }

            if (IsCollided())
            {
                score += 1;
                ballSpeedX = -ballSpeedX;
            }

            if (ballX < 0)
            {
                gameOver_label.Visible = true;
                timer.Stop();
            }
        }

        bool IsCollided()
        {
            playerY = player.GetY();
            return (ball.GetX() < player.GetX() + 30 && ball.GetY() > playerY && ball.GetY() < playerY + 130);
        }

        void TimerCallback(object sender, EventArgs e)
        {
            player.Draw(g);
            ball.Draw(g);
            score_label.Text = $"Score: {score}";
            UpdateBall();
            this.Invalidate();
            return;
        }

        private void Ping_Pong_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = (Keys)e.KeyValue;
            if (key == Keys.Up && player.GetY() > 0)
            {
                player.TransferY(-10);
            }

            if (key == Keys.Down && player.GetY() < Height - 150)
            {
                player.TransferY(10);
            }

        }
        void Ping_PongFormPaint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            ball.Draw(g);
            player.Draw(g);
        }

    }
}
