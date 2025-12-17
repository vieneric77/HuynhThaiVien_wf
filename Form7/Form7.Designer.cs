namespace Form7
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();

            txtName = new TextBox();
            dtpBirth = new DateTimePicker();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            cbKhoa = new ComboBox();

            txtStatus = new TextBox();

            btnAdd = new Button();
            btnExit = new Button();

            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Text = "Họ và tên";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(20, 65);
            label2.Text = "Ngày sinh";

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(20, 105);
            label3.Text = "Giới tính";

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(20, 145);
            label4.Text = "Khoa";

            // label5
            label5.AutoSize = true;
            label5.Location = new Point(20, 185);
            label5.Text = "Trạng thái";

            // txtName
            txtName.Location = new Point(120, 22);
            txtName.Size = new Size(240, 27);

            // dtpBirth
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(120, 62);
            dtpBirth.Size = new Size(240, 27);

            // rbNam
            // 
            rbNam.Checked = true;
            rbNam.Location = new Point(120, 103);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(70, 24);
            rbNam.TabIndex = 7;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.CheckedChanged += rbNam_CheckedChanged;
            // 
            // rbNu
            // 
            rbNu.Location = new Point(190, 103);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(104, 24);
            rbNu.TabIndex = 8;
            rbNu.Text = "Nữ";

            // cbKhoa
            cbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoa.Location = new Point(120, 142);
            cbKhoa.Size = new Size(240, 28);

            // txtStatus (THAY LISTBOX)
            txtStatus.Location = new Point(120, 182);
            txtStatus.Size = new Size(240, 130);
            txtStatus.Multiline = true;
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.ReadOnly = true;

            // btnAdd
            btnAdd.Location = new Point(120, 325);
            btnAdd.Size = new Size(90, 32);
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;

            // btnExit
            btnExit.Location = new Point(270, 325);
            btnExit.Size = new Size(90, 32);
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;

            // Form7
            ClientSize = new Size(420, 380);
            Controls.AddRange(new Control[]
            {
                label1, label2, label3, label4, label5,
                txtName, dtpBirth, rbNam, rbNu, cbKhoa,
                txtStatus, btnAdd, btnExit
            });
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            FormClosed += Form7_FormClosed;

            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1, label2, label3, label4, label5;
        private TextBox txtName;
        private DateTimePicker dtpBirth;
        private RadioButton rbNam, rbNu;
        private ComboBox cbKhoa;
        private TextBox txtStatus;
        private Button btnAdd, btnExit;
    }
}
