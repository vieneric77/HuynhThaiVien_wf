namespace BT_WinForm.GUI
{
    partial class Form4
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
            cb_Faculty = new ComboBox();
            tbDisplay = new TextBox();
            button1 = new Button();
            btOK = new Button();
            SuspendLayout();

            // cb_Faculty
            cb_Faculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Faculty.Location = new Point(20, 20);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(300, 28);
            cb_Faculty.SelectedValueChanged += cb_Faculty_SelectedValueChanged;

            // tbDisplay
            tbDisplay.Location = new Point(20, 60);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(300, 120);

            // button1 (nếu chưa dùng có thể ẩn)
            button1.Location = new Point(20, 195);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // button1.Click += button1_Click; // nếu có xử lý thì mở lại

            // btOK
            btOK.Location = new Point(230, 195);
            btOK.Name = "btOK";
            btOK.Size = new Size(90, 30);
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;

            // Form5
            ClientSize = new Size(350, 250);
            Controls.Add(cb_Faculty);
            Controls.Add(tbDisplay);
            Controls.Add(button1);
            Controls.Add(btOK);
            Name = "Form5";
            Text = "Khoa";
            Load += Khoa_Load;

            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ComboBox cb_Faculty;
        private TextBox tbDisplay;
        private Button button1;
        private Button btOK;
    }
}