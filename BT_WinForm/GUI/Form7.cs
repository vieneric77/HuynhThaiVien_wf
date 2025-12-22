using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BT_WinForm
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // Di chuyển ảnh sang trái
        private void btLeft_Click(object sender, EventArgs e)
        {
            // Kiểm tra để ảnh không chạy ra ngoài lề trái của Form
            if (pbImage.Left > 10)
            {
                pbImage.Left -= 20; // Mỗi lần nhấn lùi lại 20 pixel
            }
        }

        // Di chuyển ảnh sang phải
        private void btRight_Click(object sender, EventArgs e)
        {
            // Kiểm tra để ảnh không chạy ra ngoài lề phải của Form
            if (pbImage.Right < this.ClientSize.Width - 10)
            {
                pbImage.Left += 20; // Mỗi lần nhấn tiến lên 20 pixel
            }
        }

        // Chọn file ảnh từ máy tính
        private void btFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh cho game";
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Load ảnh vào PictureBox
                    pbImage.Image = new Bitmap(ofd.FileName);
                }
            }
        }
    }
}