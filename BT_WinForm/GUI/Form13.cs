using System;
using System.Windows.Forms;

namespace BT_WinForm
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu bài hát
            lbSong.Items.Add(new Song { Id = 53418, Name = "Giấc mơ Chapi", Author = "Trần Tiến" });
            lbSong.Items.Add(new Song { Id = 52616, Name = "Đôi mắt Pleiku", Author = "Nguyễn Cường" });
            lbSong.Items.Add(new Song { Id = 51172, Name = "Em muốn sống bên anh trọn đời", Author = "Nguyễn Cường" });
            lbSong.Items.Add(new Song { Id = 50432, Name = "H’Zen lên rẫy", Author = "Nguyễn Cường" });
            lbSong.Items.Add(new Song { Id = 50123, Name = "Còn thương nhau thì về Buôn Mê Thuột", Author = "Nguyễn Cường" });
            lbSong.Items.Add(new Song { Id = 50789, Name = "Ly cà phê Ban Mê", Author = "Nguyễn Cường" });
            lbSong.Items.Add(new Song { Id = 50999, Name = "Đi tìm lời ru mặt trời", Author = "Nguyễn Cường" });

            // Hiển thị chỉ tên bài hát bên trái
            lbSong.DisplayMember = "DisplayName";
            lbFavorite.DisplayMember = "DisplayFull";
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                Song selected = lbSong.SelectedItem as Song;
                lbFavorite.Items.Add(selected);  // bên phải hiển thị đầy đủ
                lbSong.Items.Remove(selected);
            }
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                Song selected = lbFavorite.SelectedItem as Song;
                lbSong.Items.Add(selected);  // quay về hiển thị tên
                lbFavorite.Items.Remove(selected);
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Song s in lbSong.Items)
                lbFavorite.Items.Add(s);
            lbSong.Items.Clear();
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            foreach (Song s in lbFavorite.Items)
                lbSong.Items.Add(s);
            lbFavorite.Items.Clear();
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btSelect_Click(sender, e);
        }

        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btDeselect_Click(sender, e);
        }

        private void lbSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Không cần xử lý
        }
    }
}
