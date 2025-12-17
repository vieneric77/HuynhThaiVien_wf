namespace Form1
{
    partial class Form1
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
            cb_Faculty = new System.Windows.Forms.ComboBox();
            tbDisplay = new System.Windows.Forms.TextBox();
            btOK = new System.Windows.Forms.Button();
            btExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Location = new System.Drawing.Point(40, 30);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new System.Drawing.Size(250, 24);
            cb_Faculty.TabIndex = 0;
            cb_Faculty.SelectedValueChanged += new System.EventHandler(this.cb_Faculty_SelectedValueChanged);
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new System.Drawing.Point(40, 80);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.ReadOnly = true;
            tbDisplay.Size = new System.Drawing.Size(250, 80);
            tbDisplay.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.Location = new System.Drawing.Point(40, 180);
            btOK.Name = "btOK";
            btOK.Size = new System.Drawing.Size(250, 35);
            btOK.TabIndex = 2;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btExit
            // 
            btExit.Location = new System.Drawing.Point(40, 225);
            btExit.Name = "btExit";
            btExit.Size = new System.Drawing.Size(250, 35);
            btExit.TabIndex = 3;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(350, 290);
            Controls.Add(this.btExit);
            Controls.Add(this.btOK);
            Controls.Add(this.tbDisplay);
            Controls.Add(this.cb_Faculty);
            Name = "Form1";
            Text = "Faculty Form";
            Load += new System.EventHandler(this.Form1_Load);
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btExit;
    }
}
