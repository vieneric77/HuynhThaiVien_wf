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
            // Thêm danh sách bài hát ban đầu
            lbSong.Items.Add("Giấc mơ Chapi");
            lbSong.Items.Add("Đôi mắt Pleiku");
            lbSong.Items.Add("Em muốn sống bên anh trọn đời");
            lbSong.Items.Add("H’Zen lên rẫy");
            lbSong.Items.Add("Còn thương nhau thì về Buôn Mê Thuột");
            lbSong.Items.Add("Ly cà phê Ban Mê");
            lbSong.Items.Add("Đi tìm lời ru mặt trời");
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                lbFavorite.Items.Add(lbSong.SelectedItem);
                lbSong.Items.Remove(lbSong.SelectedItem);
            }
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                lbSong.Items.Add(lbFavorite.SelectedItem);
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lbSong.Items)
                lbFavorite.Items.Add(item);

            lbSong.Items.Clear();
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lbFavorite.Items)
                lbSong.Items.Add(item);

            lbFavorite.Items.Clear();
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                lbFavorite.Items.Add(lbSong.SelectedItem);
                lbSong.Items.Remove(lbSong.SelectedItem);
            }
        }

        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                lbSong.Items.Add(lbFavorite.SelectedItem);
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }

        private void lbSong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
