using System;
using System.Windows.Forms;

namespace Form7
{
    public partial class Form7 : Form
    {
        private Form menuForm;

        // ===== CONSTRUCTOR MẶC ĐỊNH =====
        public Form7()
        {
            InitializeComponent();
            LoadKhoa();
        }

        // ===== CONSTRUCTOR NHẬN MENU =====
        public Form7(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
            LoadKhoa();
        }

        // ===== LOAD KHOA =====
        private void LoadKhoa()
        {
            cbKhoa.Items.Clear();
            cbKhoa.Items.Add("Công nghệ thông tin");
            cbKhoa.Items.Add("Quản trị kinh doanh");
            cbKhoa.Items.Add("Kế toán");
            cbKhoa.SelectedIndex = 0;
        }

        // ===== NÚT THÊM =====
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            string gender = rbNam.Checked ? "Nam" : "Nữ";
            string birth = dtpBirth.Value.ToShortDateString();
            string khoa = cbKhoa.Text;

            // Đếm số sinh viên hiện có
            int index = txtStatus.Lines.Length;
            if (txtStatus.Text.Trim() != "") index++;

            txtStatus.AppendText(
                $"{index}. {name}\r\n" +
                $"- Giới tính: {gender}\r\n" +
                $"- Ngày sinh: {birth}\r\n" +
                $"- Khoa: {khoa}\r\n\r\n"
            );

            txtName.Clear();
            txtName.Focus();
        }

        // ===== NÚT THOÁT =====
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===== ĐÓNG FORM → QUAY VỀ MENU =====
        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuForm != null)
                menuForm.Show();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            // không cần code
        }
    }
}
