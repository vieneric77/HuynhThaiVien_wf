namespace Form5
{
    partial class Form5
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtDisplay.Location = new System.Drawing.Point(20, 20);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(260, 47);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(20, 90);
            this.btn0.Size = new System.Drawing.Size(60, 50);
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(90, 90);
            this.btn1.Size = new System.Drawing.Size(60, 50);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(160, 90);
            this.btn2.Size = new System.Drawing.Size(60, 50);
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(230, 90);
            this.btn3.Size = new System.Drawing.Size(60, 50);
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(20, 150);
            this.btnPlus.Size = new System.Drawing.Size(60, 50);
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(90, 150);
            this.btnMul.Size = new System.Drawing.Size(60, 50);
            this.btnMul.Text = "*";
            this.btnMul.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(160, 150);
            this.btnDot.Size = new System.Drawing.Size(60, 50);
            this.btnDot.Text = ".";
            this.btnDot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(230, 150);
            this.btnEqual.Size = new System.Drawing.Size(60, 50);
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(310, 230);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form5";
            this.Text = "Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
    }
}
