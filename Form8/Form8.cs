using System;
using System.Windows.Forms;

namespace Form8
{
    public partial class Form8 : Form
    {
        private Form menuForm;

        // ===== CONSTRUCTOR MẶC ĐỊNH =====
        public Form8()
        {
            InitializeComponent();
        }

        // ===== CONSTRUCTOR NHẬN MENU =====
        public Form8(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
        }

        // ===== LOAD FORM =====
        private void Form8_Load(object sender, EventArgs e)
        {
            listBoxAll.Items.AddRange(new string[]
            {
                "Giấc mơ Chapi",
                "Đôi Mắt Pleiku",
                "Em Muốn Sống Bên Anh Trọn Đời",
                "H’Zen Lên Rẫy",
                "Còn Thương Nhau Thì Về Buôn Mê Thuột",
                "Ly Cà Phê Ban Mê",
                "Đi tìm lời ru mặt trời"
            });
        }

        // ===== > =====
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxAll.SelectedItem != null)
            {
                listBoxFav.Items.Add(listBoxAll.SelectedItem);
                listBoxAll.Items.Remove(listBoxAll.SelectedItem);
            }
        }

        // ===== < =====
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxFav.SelectedItem != null)
            {
                listBoxAll.Items.Add(listBoxFav.SelectedItem);
                listBoxFav.Items.Remove(listBoxFav.SelectedItem);
            }
        }

        // ===== >> =====
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxAll.Items)
            {
                listBoxFav.Items.Add(item);
            }
            listBoxAll.Items.Clear();
        }

        // ===== << =====
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxFav.Items)
            {
                listBoxAll.Items.Add(item);
            }
            listBoxFav.Items.Clear();
        }
        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuForm != null)
                menuForm.Show();
        }

    }
}
