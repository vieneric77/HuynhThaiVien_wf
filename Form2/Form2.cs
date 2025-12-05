using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Form2
{
    public partial class Form2 : Form
    {
        private Form menuForm;
        public Form2(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btRun_Click(object sender, EventArgs e)
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
                else
                    disc = 0;
            }

            tbResult.Text = msg + tbName.Text + " được giảm " + disc + "%";
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            tbDiscount.Enabled = ckDiscount.Checked;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (menuForm != null)
            {
                menuForm.Show();
            }

            this.Close(); 
        }
    }
}
