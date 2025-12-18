namespace BT_WinForm.GUI
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            btnLuu = new Button();
            btnCong = new Button();
            btnNhan = new Button();
            btnThoat = new Button();
            SuspendLayout();

            // label1 - Số x
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Text = "Số x";

            // tbSoX
            tbSoX.Location = new Point(120, 22);
            tbSoX.Size = new Size(260, 27);

            // label2 - Số y
            label2.AutoSize = true;
            label2.Location = new Point(20, 65);
            label2.Text = "Số y";

            // tbSoY
            tbSoY.Location = new Point(120, 62);
            tbSoY.Size = new Size(260, 27);

            // label3 - Kết quả
            label3.AutoSize = true;
            label3.Location = new Point(20, 105);
            label3.Text = "Kết quả";

            // tbKetQua
            tbKetQua.Location = new Point(120, 102);
            tbKetQua.Size = new Size(260, 90);
            tbKetQua.Multiline = true;
            tbKetQua.ReadOnly = true;

            // btnLuu
            btnLuu.Location = new Point(20, 210);
            btnLuu.Size = new Size(80, 30);
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;

            // btnCong
            btnCong.Location = new Point(110, 210);
            btnCong.Size = new Size(80, 30);
            btnCong.Text = "Cộng";
            btnCong.Click += btnCong_Click;

            // btnNhan
            btnNhan.Location = new Point(200, 210);
            btnNhan.Size = new Size(80, 30);
            btnNhan.Text = "Nhân";
            btnNhan.Click += btnNhan_Click;

            // btnThoat
            btnThoat.Location = new Point(300, 210);
            btnThoat.Size = new Size(80, 30);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;

            // Form8
            ClientSize = new Size(410, 260);
            Controls.AddRange(new Control[]
            {
        label1, tbSoX,
        label2, tbSoY,
        label3, tbKetQua,
        btnLuu, btnCong, btnNhan, btnThoat
            });

            Name = "Caculator_2";
            Text = "Calculator 2";
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button btnCong;
        private Button btnNhan;
        private Button btnThoat;
        private Button btnLuu;
    }
}