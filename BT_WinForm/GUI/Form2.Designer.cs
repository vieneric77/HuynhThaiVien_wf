namespace BT_WinForm.GUI
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            tbYear = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();

            // label1 - Year
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.Text = "Year";

            // tbYear
            tbYear.Location = new Point(150, 27);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(200, 27);

            // label2 - Phone
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.Text = "Phone Number";

            // textBox2
            textBox2.Location = new Point(150, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);

            // Form2
            ClientSize = new Size(380, 140);
            Controls.Add(label1);
            Controls.Add(tbYear);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Name = "Form2";
            Text = "Form2";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbYear;
        private TextBox textBox2;
    }
}
