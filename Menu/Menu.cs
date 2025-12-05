
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

    }
}
