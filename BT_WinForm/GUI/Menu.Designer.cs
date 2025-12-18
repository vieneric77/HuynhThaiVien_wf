namespace BT_WinForm
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            labelTitle = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(250, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(297, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "MENU QUẢN LÝ BÀI TẬP";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(60, 90);
            button1.Name = "button1";
            button1.Size = new Size(160, 60);
            button1.TabIndex = 1;
            button1.Text = "Form 1";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(320, 90);
            button2.Name = "button2";
            button2.Size = new Size(160, 60);
            button2.TabIndex = 2;
            button2.Text = "Form 2";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(580, 90);
            button3.Name = "button3";
            button3.Size = new Size(160, 60);
            button3.TabIndex = 3;
            button3.Text = "Form 6";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.Location = new Point(60, 180);
            button4.Name = "button4";
            button4.Size = new Size(160, 60);
            button4.TabIndex = 4;
            button4.Text = "Form 7";
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.Location = new Point(320, 180);
            button5.Name = "button5";
            button5.Size = new Size(160, 60);
            button5.TabIndex = 5;
            button5.Text = "Form 5";
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button6.Location = new Point(580, 180);
            button6.Name = "button6";
            button6.Size = new Size(160, 60);
            button6.TabIndex = 6;
            button6.Text = "Form 4";
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button7.Location = new Point(60, 270);
            button7.Name = "button7";
            button7.Size = new Size(160, 60);
            button7.TabIndex = 7;
            button7.Text = "Form 3";
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button8.Location = new Point(320, 270);
            button8.Name = "button8";
            button8.Size = new Size(160, 60);
            button8.TabIndex = 8;
            button8.Text = "Form 8";
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button9.Location = new Point(580, 270);
            button9.Name = "button9";
            button9.Size = new Size(160, 60);
            button9.TabIndex = 9;
            button9.Text = "Form 9";
            button9.Click += button9_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(labelTitle);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Quản Lý";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label labelTitle;
    }
}
