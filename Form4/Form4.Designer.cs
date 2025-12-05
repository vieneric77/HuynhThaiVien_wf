namespace Form4
{
    partial class Form4
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
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.tbCustom = new System.Windows.Forms.TextBox();
            this.btShow = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(40, 30);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(250, 22);
            this.dtpBirth.TabIndex = 0;
            this.dtpBirth.ValueChanged += new System.EventHandler(this.dtpBirth_ValueChanged);
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(40, 80);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(113, 20);
            this.rbDefault.TabIndex = 1;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default format";
            this.rbDefault.CheckedChanged += new System.EventHandler(this.rbDefault_CheckedChanged);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(40, 110);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(113, 20);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.Text = "Custom format";
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // tbCustom
            // 
            this.tbCustom.Location = new System.Drawing.Point(170, 110);
            this.tbCustom.Name = "tbCustom";
            this.tbCustom.Size = new System.Drawing.Size(120, 22);
            this.tbCustom.TabIndex = 3;
            this.tbCustom.TextChanged += new System.EventHandler(this.tbCustom_TextChanged);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(40, 160);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(90, 30);
            this.btShow.TabIndex = 4;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(40, 210);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(250, 22);
            this.tbResult.TabIndex = 5;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(200, 160);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(90, 30);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(340, 270);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.tbCustom);
            this.Controls.Add(this.rbCustom);
            this.Controls.Add(this.rbDefault);
            this.Controls.Add(this.dtpBirth);
            this.Name = "Form4";
            this.Text = "Form4 - DateTimePicker";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.TextBox tbCustom;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btExit;
    }
}
