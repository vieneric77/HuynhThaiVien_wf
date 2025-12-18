namespace BT_WinForm.GUI
{
    public partial class Form8 : Form
    {
        int dem = 0;

        public Form8()
        {
            InitializeComponent();
            LoadKhoa();
        }

        void LoadKhoa()
        {
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Kế toán");
            cboKhoa.Items.Add("Quản trị kinh doanh");
            cboKhoa.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dem++;

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            lstThongTin.Items.Add($"{dem}. {txtHoTen.Text}");
            lstThongTin.Items.Add($"- Giới tính: {gioiTinh}");
            lstThongTin.Items.Add($"- Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}");
            lstThongTin.Items.Add($"- Khoa: {cboKhoa.Text}");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
