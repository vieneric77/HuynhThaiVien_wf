namespace BT_WinForm
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
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            labelTitle = new Label();
            SuspendLayout();

            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(240, 20);
            labelTitle.Text = "MENU QUẢN LÝ BÀI TẬP";

            // ===== ROW 1 =====
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(60, 90);
            button1.Size = new Size(160, 60);
            button1.Text = "Form 1";
            button1.Click += button1_Click;

            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(320, 90);
            button2.Size = new Size(160, 60);
            button2.Text = "Form 2";
            button2.Click += button2_Click;

            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(580, 90);
            button3.Size = new Size(160, 60);
            button3.Text = "Form 3";
            button3.Click += button3_Click;

            // ===== ROW 2 =====
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.Location = new Point(60, 180);
            button4.Size = new Size(160, 60);
            button4.Text = "Form 4";
            button4.Click += button4_Click;

            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.Location = new Point(320, 180);
            button5.Size = new Size(160, 60);
            button5.Text = "Form 5";
            button5.Click += button5_Click;

            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button6.Location = new Point(580, 180);
            button6.Size = new Size(160, 60);
            button6.Text = "Form 6";
            button6.Click += button6_Click;

            // ===== ROW 3 =====
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button7.Location = new Point(60, 270);
            button7.Size = new Size(160, 60);
            button7.Text = "Form 7";
            button7.Click += button7_Click;

            button8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button8.Location = new Point(320, 270);
            button8.Size = new Size(160, 60);
            button8.Text = "Form 8";
            button8.Click += button8_Click;

            button9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button9.Location = new Point(580, 270);
            button9.Size = new Size(160, 60);
            button9.Text = "Form 9";
            button9.Click += button9_Click;

            // ===== ROW 4 =====
            button10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button10.Location = new Point(60, 350);
            button10.Size = new Size(160, 60);
            button10.Text = "Form 10";
            button10.Click += button10_Click;

            button11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button11.Location = new Point(320, 350);
            button11.Size = new Size(160, 60);
            button11.Text = "Form 11";
            button11.Click += button11_Click;

            button12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button12.Location = new Point(580, 350);
            button12.Size = new Size(160, 60);
            button12.Text = "Form 12";
            button12.Click += button12_Click;

            // ===== ROW 5 =====
            button13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button13.Location = new Point(60, 430);
            button13.Size = new Size(160, 60);
            button13.Text = "Form 13";
            button13.Click += button13_Click;

            button14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button14.Location = new Point(320, 430);   
            button14.Size = new Size(160, 60);
            button14.Text = "Form 14";
            button14.Click += button14_Click;

            button15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button15.Location = new Point(580, 430); 
            button15.Size = new Size(160, 60);
            button15.Text = "Form 15";
            button15.Click += button15_Click;


            // thêm vào Controls
            Controls.Add(button14);


            // ===== Menu =====
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560); 
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Quản Lý";

            Controls.AddRange(new Control[]
            {
                labelTitle,
                button1, button2, button3,
                button4, button5, button6,
                button7, button8, button9,
                button10, button11, button12,
                button13, button14, button15
            });

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1, button2, button3, button4, button5, button6;
        private Button button7, button8, button9, button10, button11, button12;
        private Button button13, button14, button15;
        private Label labelTitle;
    }
}
