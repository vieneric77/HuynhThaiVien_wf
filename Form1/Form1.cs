using System;
using System.Collections;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        private Form menuForm;

        // ===== CONSTRUCTOR MẶC ĐỊNH (Visual Studio cần để run Form1 trực tiếp) =====
        public Form1()
        {
            InitializeComponent();
        }

        // ===== CONSTRUCTOR NHẬN MENU =====
        public Form1(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
        }

        // ===== TRỞ VỀ MENU =====
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuForm != null)
                menuForm.Show();
        }

        // ===== GET DATA =====
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // ===== LOAD =====
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
        }

        // ===== CHỌN MÃ =====
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Id";
            string id = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
        }

        // ===== CHỌN TÊN =====
        private void btOK_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
        }
        //private void btExit_Click(object sender, EventArgs e)
        //{
        //    if (menuForm != null)
        //    {
        //        menuForm.Show();
        //    }

        //    this.Close();
        //}
    }
}
