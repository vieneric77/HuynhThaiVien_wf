namespace BT_WinForm.GUI
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tbName = new TextBox();
            groupBox1 = new GroupBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            ckDiscount = new CheckBox();
            tbDiscount = new TextBox();
            tbResult = new TextBox();
            btRun_Click = new Button();
            button2 = new Button();

            groupBox1.SuspendLayout();
            SuspendLayout();

            // tbName
            tbName.Location = new Point(40, 30);
            tbName.Size = new Size(320, 27);

            // groupBox1
            groupBox1.Location = new Point(40, 70);
            groupBox1.Size = new Size(320, 90);
            groupBox1.Text = "Giới tính";

            // rbMale
            rbMale.Location = new Point(50, 40);
            rbMale.Text = "Nam";

            // rbFemale
            rbFemale.Location = new Point(180, 40);
            rbFemale.Text = "Nữ";

            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(rbFemale);

            // ckDiscount
            ckDiscount.Location = new Point(40, 175);
            ckDiscount.Text = "Giảm giá";

            // tbDiscount
            tbDiscount.Location = new Point(140, 172);
            tbDiscount.Size = new Size(220, 27);

            // tbResult
            tbResult.Location = new Point(40, 210);
            tbResult.Size = new Size(320, 100);
            tbResult.Multiline = true;

            // btRun_Click
            btRun_Click.Location = new Point(60, 330);
            btRun_Click.Size = new Size(100, 30);
            btRun_Click.Text = "Tính tiền";
            btRun_Click.Click += button1_Click;

            // button2
            button2.Location = new Point(220, 330);
            button2.Size = new Size(100, 30);
            button2.Text = "Thoát";
            button2.Click += button2_Click;

            // Form3
            ClientSize = new Size(410, 400);
            Controls.AddRange(new Control[]
            {
                 tbName, groupBox1, ckDiscount,
                 tbDiscount, tbResult, btRun_Click, button2
            });

            Text = "Giảm Giá";

            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox tbName;
        private GroupBox groupBox1;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private CheckBox ckDiscount;
        private TextBox tbDiscount;
        private TextBox tbResult;
        private Button btRun_Click;
        private Button button2;
    }
}
