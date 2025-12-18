namespace BT_WinForm.GUI
{
    partial class Form9
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvNhanVien = new DataGridView();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtTuoi = new TextBox();
            chkNam = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(12, 12);
            dgvNhanVien.Size = new Size(560, 180);
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 215);
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 250);
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 285);
            label3.Text = "Tuổi";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(80, 212);
            txtMa.Size = new Size(150, 27);
            // 
            // txtTen
            // 
            txtTen.Location = new Point(80, 247);
            txtTen.Size = new Size(250, 27);
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(80, 282);
            txtTuoi.Size = new Size(150, 27);
            // 
            // chkNam
            // 
            chkNam.AutoSize = true;
            chkNam.Location = new Point(80, 320);
            chkNam.Text = "Nam";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(280, 315);
            btnThem.Size = new Size(90, 35);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(380, 315);
            btnXoa.Size = new Size(90, 35);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(480, 315);
            btnThoat.Size = new Size(90, 35);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 370);
            Controls.Add(dgvNhanVien);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtMa);
            Controls.Add(txtTen);
            Controls.Add(txtTuoi);
            Controls.Add(chkNam);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhanVien;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtTuoi;
        private CheckBox chkNam;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
    }
}
