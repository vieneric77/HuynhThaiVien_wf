namespace BT_WinForm.GUI
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            cboKhoa = new ComboBox();
            lstThongTin = new ListBox();
            btnThem = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 65);
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 105);
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 155);
            label4.Text = "Khoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 195);
            label5.Text = "Trạng thái";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(100, 22);
            txtHoTen.Size = new Size(220, 27);
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(100, 62);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoNam);
            groupBox1.Controls.Add(rdoNu);
            groupBox1.Location = new Point(100, 95);
            groupBox1.Size = new Size(220, 45);
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(20, 15);
            rdoNam.Text = "Nam";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(120, 15);
            rdoNu.Text = "Nữ";
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.Location = new Point(100, 152);
            cboKhoa.Size = new Size(220, 28);
            // 
            // lstThongTin
            // 
            lstThongTin.Location = new Point(100, 195);
            lstThongTin.Size = new Size(350, 120);
            // 
            // btnThem
            // 
            btnThem.Location = new Point(120, 330);
            btnThem.Size = new Size(100, 35);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(260, 330);
            btnThoat.Size = new Size(100, 35);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 390);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtHoTen);
            Controls.Add(dtpNgaySinh);
            Controls.Add(groupBox1);
            Controls.Add(cboKhoa);
            Controls.Add(lstThongTin);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private ComboBox cboKhoa;
        private ListBox lstThongTin;
        private Button btnThem;
        private Button btnThoat;
        private GroupBox groupBox1;
    }
}
