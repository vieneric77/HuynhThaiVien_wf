using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tbYear.KeyPress += tbYear_KeyPress;
            tbYear.Validating += tbYear_Validating;
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbYear.Text, out int year))
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            if (year < 2000)
            {
                MessageBox.Show("Năm phải lớn hơn hoặc bằng 2000!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
