namespace BT_WinForm
{
    partial class Form11
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
            cbFaculty = new ComboBox();
            txtResult = new TextBox();
            btnClear = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // cbFaculty
            // 
            cbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(20, 20);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(300, 28);
            // 
            // txtResult
            // 
            txtResult.Location = new Point(20, 65);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(300, 120);
            // 
            // btnClear
            // 
            btnClear.Location = new Point(50, 200);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(180, 200);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 250);
            Controls.Add(btnOK);
            Controls.Add(btnClear);
            Controls.Add(txtResult);
            Controls.Add(cbFaculty);
            Name = "Form11";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComboBox Article";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbFaculty;
        private TextBox txtResult;
        private Button btnClear;
        private Button btnOK;
    }
}
