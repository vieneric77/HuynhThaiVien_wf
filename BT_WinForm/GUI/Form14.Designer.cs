namespace BT_WinForm
{
    partial class Form14
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private PictureBox pictureBox1;
        private Button btnChonAnh;

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
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            pictureBox1 = new PictureBox();
            btnChonAnh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Ảnh 3 x 4";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(120, 30);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(200, 27);
            txtMaNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(120, 70);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(200, 27);
            txtTenNV.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(120, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(260, 180);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(80, 32);
            btnChonAnh.TabIndex = 6;
            btnChonAnh.Text = "Chọn ảnh...";
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // Form14
            // 
            ClientSize = new Size(400, 320);
            Controls.Add(label1);
            Controls.Add(txtMaNV);
            Controls.Add(label2);
            Controls.Add(txtTenNV);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnChonAnh);
            Name = "Form14";
            Text = "Quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
