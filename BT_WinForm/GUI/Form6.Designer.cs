namespace BT_WinForm.GUI
{
    partial class Form6
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
            tbSoX.Size = new Size(200, 27);

            // label2 - Số y
            label2.AutoSize = true;
            label2.Location = new Point(20, 65);
            label2.Text = "Số y";

            // tbSoY
            tbSoY.Location = new Point(120, 62);
            tbSoY.Size = new Size(200, 27);

            // label3 - Kết quả
            label3.AutoSize = true;
            label3.Location = new Point(20, 105);
            label3.Text = "Kết quả";

            // tbKetQua
            tbKetQua.Location = new Point(120, 102);
            tbKetQua.Size = new Size(200, 27);
            tbKetQua.ReadOnly = true;

            // btnCong
            btnCong.Location = new Point(20, 150);
            btnCong.Size = new Size(90, 30);
            btnCong.Text = "Cộng";
            btnCong.Click += btnCong_Click;

            // btnNhan
            btnNhan.Location = new Point(125, 150);
            btnNhan.Size = new Size(90, 30);
            btnNhan.Text = "Nhân";
            btnNhan.Click += btnNhan_Click;

            // btnThoat
            btnThoat.Location = new Point(230, 150);
            btnThoat.Size = new Size(90, 30);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;

            // Form7
            ClientSize = new Size(360, 210);
            Controls.Add(label1);
            Controls.Add(tbSoX);
            Controls.Add(label2);
            Controls.Add(tbSoY);
            Controls.Add(label3);
            Controls.Add(tbKetQua);
            Controls.Add(btnCong);
            Controls.Add(btnNhan);
            Controls.Add(btnThoat);
            Name = "Form7";
            Text = "Calculator";

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
    }
}