namespace Form2
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox groupBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tbName = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            ckDiscount = new CheckBox();
            tbDiscount = new TextBox();
            tbResult = new TextBox();
            btRun = new Button();
            btExit = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(20, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(220, 27);
            tbName.TabIndex = 0;
            // 
            // rbMale
            // 
            rbMale.Location = new Point(10, 25);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(70, 24);
            rbMale.TabIndex = 0;
            rbMale.Text = "Nam";
            // 
            // rbFemale
            // 
            rbFemale.Location = new Point(100, 25);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(104, 24);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Nữ";
            // 
            // ckDiscount
            // 
            ckDiscount.Location = new Point(20, 140);
            ckDiscount.Name = "ckDiscount";
            ckDiscount.Size = new Size(104, 24);
            ckDiscount.TabIndex = 2;
            ckDiscount.Text = "Giảm giá";
            ckDiscount.CheckedChanged += ckDiscount_CheckedChanged;
            // 
            // tbDiscount
            // 
            tbDiscount.Enabled = false;
            tbDiscount.Location = new Point(120, 140);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(120, 27);
            tbDiscount.TabIndex = 3;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(20, 180);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(220, 60);
            tbResult.TabIndex = 4;
            // 
            // btRun
            // 
            btRun.Location = new Point(20, 260);
            btRun.Name = "btRun";
            btRun.Size = new Size(80, 30);
            btRun.TabIndex = 5;
            btRun.Text = "Tính tiền";
            btRun.Click += btRun_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(160, 260);
            btExit.Name = "btExit";
            btExit.Size = new Size(80, 30);
            btExit.TabIndex = 6;
            btExit.Text = "Thoát";
            btExit.Click += btExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Location = new Point(20, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 60);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // Form2
            // 
            ClientSize = new Size(270, 310);
            Controls.Add(tbName);
            Controls.Add(groupBox1);
            Controls.Add(ckDiscount);
            Controls.Add(tbDiscount);
            Controls.Add(tbResult);
            Controls.Add(btRun);
            Controls.Add(btExit);
            Name = "Form2";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
