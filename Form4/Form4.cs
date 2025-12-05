using System;
using System.Windows.Forms;

namespace Form4
{
    public partial class Form4 : Form
    {
        private Form menuForm;
        public Form4(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            rbDefault.Checked = true;
            tbCustom.Enabled = false;
        }

        private void rbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDefault.Checked)
            {
                dtpBirth.Format = DateTimePickerFormat.Long;
                tbCustom.Enabled = false;
            }
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustom.Checked)
            {
                dtpBirth.Format = DateTimePickerFormat.Custom;
                tbCustom.Enabled = true;

                if (!string.IsNullOrWhiteSpace(tbCustom.Text))
                    dtpBirth.CustomFormat = tbCustom.Text;
            }
        }

        private void tbCustom_TextChanged(object sender, EventArgs e)
        {
            if (rbCustom.Checked)
            {
                dtpBirth.Format = DateTimePickerFormat.Custom;
                dtpBirth.CustomFormat = tbCustom.Text;
            }
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            tbResult.Text = dtpBirth.Value.ToString("dd/MM/yyyy");
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            tbResult.Text = "Ngày bạn chọn: " + dtpBirth.Value.ToString();
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
