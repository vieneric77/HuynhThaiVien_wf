using System;
using System.Windows.Forms;

namespace Form9
{
    public partial class Form9 : Form
    {
        private Form menuForm;

        // ===== CONSTRUCTOR MẶC ĐỊNH =====
        public Form9()
        {
            InitializeComponent();
        }

        // ===== CONSTRUCTOR NHẬN MENU =====
        public Form9(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
        }

        // ===== NÚT CHỌN ẢNH =====
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        // ===== ĐÓNG FORM → QUAY VỀ MENU =====
        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuForm != null)
                menuForm.Show();
        }
    }
}
