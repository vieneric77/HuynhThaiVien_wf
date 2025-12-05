using System;
using System.Windows.Forms;

namespace Form3
{
    public partial class Form3 : Form
    {
        private Form menuForm;
        public Form3(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
        }
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Item 1", "Item 2", "Item 3" });
            listBox1.Items.AddRange(new string[] { "A", "B", "C", "D", "E", "F" });
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK 1 Clicked!");
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK 2 Clicked!");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (menuForm != null)
            {
                menuForm.Show();
            }

            this.Close();
        }
    }
}
