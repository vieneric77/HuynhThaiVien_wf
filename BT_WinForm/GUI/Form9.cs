namespace BT_WinForm.GUI
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Columns.Add("Ma", "Mã nhân viên");
            dgvNhanVien.Columns.Add("Ten", "Tên nhân viên");
            dgvNhanVien.Columns.Add("Tuoi", "Tuổi");

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Giới tính (Nam)";
            chk.Name = "GioiTinh";
            dgvNhanVien.Columns.Add(chk);

            // dữ liệu mẫu
            dgvNhanVien.Rows.Add("53418", "Trần Tiến", 20, true);
            dgvNhanVien.Rows.Add("53416", "Nguyễn Cường", 25, false);
            dgvNhanVien.Rows.Add("53417", "Nguyễn Hào", 23, true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.Rows.Add(
                txtMa.Text,
                txtTen.Text,
                txtTuoi.Text,
                chkNam.Checked
            );
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                dgvNhanVien.Rows.RemoveAt(dgvNhanVien.SelectedRows[0].Index);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtTuoi.Text = row.Cells[2].Value.ToString();
                chkNam.Checked = (bool)row.Cells[3].Value;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
