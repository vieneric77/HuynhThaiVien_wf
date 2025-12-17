namespace Menu
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Chức Năng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 30);
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.Text = "Mở Form 1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 90);
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.Text = "Mở Form 2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 150);
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.Text = "Mở Form 3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(50, 210);
            this.button4.Size = new System.Drawing.Size(200, 40);
            this.button4.Text = "Mở Form 4";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 270);
            this.button5.Size = new System.Drawing.Size(200, 40);
            this.button5.Text = "Mở Form 5 (Calculator)";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(50, 330);
            this.button6.Size = new System.Drawing.Size(200, 40);
            this.button6.Text = "Mở Form 6 (Calculator Full)";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(50, 390);
            this.button7.Size = new System.Drawing.Size(200, 40);
            this.button7.Text = "Mở Form 7 (QL Sinh Viên)";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Controls
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}
