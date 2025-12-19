using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BT_WinForm
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            LoadFaculty();
        }

        private void LoadFaculty()
        {
            List<Faculty> list = new List<Faculty>()
            {
                new Faculty("Công nghệ thông tin"),
                new Faculty("Ngoại ngữ"),
                new Faculty("Quản trị kinh doanh"),
                new Faculty("Cơ khí"),
                new Faculty("Điện"),
                new Faculty("Cơ khí động lực")
            };

            cbFaculty.DataSource = list;
            cbFaculty.DisplayMember = "Name";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbFaculty.SelectedIndex = -1;
            txtResult.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbFaculty.SelectedItem is Faculty f)
            {
                txtResult.Text = $"Bạn chọn khoa:\r\n{f.Name}";
            }
        }
    }
}
