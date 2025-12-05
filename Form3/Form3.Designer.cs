namespace Form3
{
    partial class Form3
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

        private void InitializeComponent()
        {
            labelName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            numValue = new System.Windows.Forms.NumericUpDown();
            checkBox1 = new System.Windows.Forms.CheckBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            comboBox1 = new System.Windows.Forms.ComboBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            listBox1 = new System.Windows.Forms.ListBox();
            btnOK1 = new System.Windows.Forms.Button();
            btnOK2 = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            SuspendLayout();

            labelName.Location = new System.Drawing.Point(25, 20);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(60, 20);
            labelName.Text = "Name";

            txtName.Location = new System.Drawing.Point(90, 20);
            txtName.Size = new System.Drawing.Size(200, 20);

            numValue.Location = new System.Drawing.Point(300, 20);
            numValue.Size = new System.Drawing.Size(60, 20);

            checkBox1.Location = new System.Drawing.Point(90, 55);
            checkBox1.Text = "checkBox1";

            radioButton1.Location = new System.Drawing.Point(200, 55);
            radioButton1.Text = "radioButton1";

            comboBox1.Location = new System.Drawing.Point(90, 90);
            comboBox1.Size = new System.Drawing.Size(200, 20);

            dateTimePicker1.Location = new System.Drawing.Point(90, 125);
            dateTimePicker1.Size = new System.Drawing.Size(200, 20);

            listBox1.Location = new System.Drawing.Point(90, 160);
            listBox1.Size = new System.Drawing.Size(200, 100);

            btnExit.Location = new System.Drawing.Point(60, 280);
            btnExit.Size = new System.Drawing.Size(70, 25);
            btnExit.Text = "Thoát";
            btnExit.Click += new System.EventHandler(this.btnExit_Click);

            btnOK1.Location = new System.Drawing.Point(150, 280);
            btnOK1.Size = new System.Drawing.Size(70, 25);
            btnOK1.Text = "OK";
            btnOK1.Click += new System.EventHandler(this.btnOK1_Click);

            btnOK2.Location = new System.Drawing.Point(240, 280);
            btnOK2.Size = new System.Drawing.Size(70, 25);
            btnOK2.Text = "OK";
            btnOK2.Click += new System.EventHandler(this.btnOK2_Click);

            ClientSize = new System.Drawing.Size(400, 330);
            Controls.Add(this.labelName);
            Controls.Add(this.txtName);
            Controls.Add(this.numValue);
            Controls.Add(this.checkBox1);
            Controls.Add(this.radioButton1);
            Controls.Add(this.comboBox1);
            Controls.Add(this.dateTimePicker1);
            Controls.Add(this.listBox1);
            Controls.Add(this.btnExit);
            Controls.Add(this.btnOK1);
            Controls.Add(this.btnOK2);
            Text = "Form3";

            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.Button btnExit;
    }
}
