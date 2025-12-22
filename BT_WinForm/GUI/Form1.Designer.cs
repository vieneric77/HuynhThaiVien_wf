namespace BT_WinForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private TextBox txtName;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private Button btnOK1;
        private Button btnOK2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            btnOK1 = new Button();
            btnOK2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 27);
            txtName.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(345, 18);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(114, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(20, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(151, 55);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 4;
            radioButton1.Text = "radioButton1";
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            comboBox1.Location = new Point(20, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            listBox1.Location = new Point(20, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 84);
            listBox1.TabIndex = 7;
            // 
            // btnOK1
            // 
            btnOK1.Location = new Point(270, 270);
            btnOK1.Name = "btnOK1";
            btnOK1.Size = new Size(89, 27);
            btnOK1.TabIndex = 8;
            btnOK1.Text = "OK";
            btnOK1.Click += btnOK_Click;
            // 
            // btnOK2
            // 
            btnOK2.Location = new Point(375, 270);
            btnOK2.Name = "btnOK2";
            btnOK2.Size = new Size(84, 27);
            btnOK2.TabIndex = 9;
            btnOK2.Text = "OK";
            // 
            // Form1
            // 
            ClientSize = new Size(482, 320);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBox1);
            Controls.Add(btnOK1);
            Controls.Add(btnOK2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
