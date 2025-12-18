using BT_WinForm.GUI;

namespace BT_WinForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form f = new Form1();
                f.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Form6();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Form7();
            f.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Form5();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new Form4();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new Form8();
            f.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new Form9();
            f.Show();
        }
    }

}
