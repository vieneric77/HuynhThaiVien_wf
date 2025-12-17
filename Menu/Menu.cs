using System;
using System.Windows.Forms;


namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Form1 f = new Form1.Form1(this);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.Form2 f = new Form2.Form2(this);
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3.Form3 f = new Form3.Form3(this);
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4.Form4 f = new Form4.Form4(this);
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5.Form5 f = new Form5.Form5(this);
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6.Form6 f = new Form6.Form6(this);
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7.Form7 f = new Form7.Form7(this);
            f.Show();
            this.Hide();
        }


    }
}
