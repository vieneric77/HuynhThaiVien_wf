using System;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class Form3 : Form
    {
        private Form menuForm;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            int disc = 0;

            // Giới tính
            if (rbMale.Checked)
                msg += "Ông ";
            if (rbFemale.Checked)
                msg += "Bà ";

            // Giảm giá
            if (ckDiscount.Checked)
            {
                if (int.TryParse(tbDiscount.Text, out int d))
                    disc = d;
            }

            tbResult.Text = msg + tbName.Text + " được giảm " + disc + "%";
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            tbDiscount.Enabled = ckDiscount.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menuForm != null)
                menuForm.Show();

            this.Close();
        }

        // ❌ Không cần dùng nhưng Designer sinh → để trống
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void tbDiscount_TextChanged(object sender, EventArgs e) { }
    }
}
