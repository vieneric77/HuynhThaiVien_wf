namespace BT_WinForm
{
    partial class Form12
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
            label1 = new Label();
            dtpDate = new DateTimePicker();
            btnOK = new Button();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.Text = "Date";

            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(80, 22);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(150, 27);
            dtpDate.ValueChanged += dtpDate_ValueChanged;

            // 
            // btnOK
            // 
            btnOK.Location = new Point(155, 65);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 30);
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;

            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 120);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(btnOK);
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DateTimePicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Button btnOK;
    }
}
