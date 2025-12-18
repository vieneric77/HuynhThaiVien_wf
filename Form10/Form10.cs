using System;
using System.Drawing;
using System.Windows.Forms;

namespace Form10
{
    public partial class Form10 : Form
    {
        int eggSpeed = 5;
        int score = 0;
        Random rand = new Random();

        bool isBroken = false;
        int brokenTime = 0;

        public Form10()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        //private void Form10_Load(object sender, EventArgs e)
        //{
        //    chicken.Image = Image.FromFile(@"images\chicken.png");
        //    egg.Image = Image.FromFile(@"images\egg_gold.png");
        //    basket.Image = Image.FromFile(@"images\basket.png");

        //    ResetEgg();
        //    timer1.Interval = 20;
        //    timer1.Start();
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Nếu trứng chưa vỡ → rơi
            if (!isBroken)
            {
                egg.Top += eggSpeed;
            }
            else
            {
                // Đếm thời gian trứng vỡ
                brokenTime += timer1.Interval;
                if (brokenTime >= 500)
                {
                    ResetEgg();
                }
                return;
            }

            // Hứng trứng
            if (egg.Bounds.IntersectsWith(basket.Bounds))
            {
                score++;
                lblScore.Text = "Score: " + score;
                ResetEgg();
            }

            // Trứng rơi xuống đất
            if (egg.Top > this.ClientSize.Height)
            {
                egg.Image = Image.FromFile(@"images\egg_gold_broken.png");
                isBroken = true;
                brokenTime = 0;
            }
        }

        private void ResetEgg()
        {
            egg.Image = Image.FromFile(@"images\egg_gold.png");
            egg.Top = chicken.Bottom;
            egg.Left = chicken.Left + rand.Next(0, 40);

            isBroken = false;
            brokenTime = 0;
        }

        private void Form10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && basket.Left > 0)
                basket.Left -= 15;

            if (e.KeyCode == Keys.Right && basket.Right < this.ClientSize.Width)
                basket.Left += 15;
        }
    }
}
