namespace BT_WinForm.GUI
{
    partial class Form1
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
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            lb1 = new Label();
            txtBox1 = new TextBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();

            // lb1 - Name
            lb1.AutoSize = true;
            lb1.Location = new Point(20, 25);
            lb1.Text = "Name";

            // txtBox1
            txtBox1.Location = new Point(120, 22);
            txtBox1.Size = new Size(230, 27);
            txtBox1.TextChanged += txtBox1_TextChanged;

            // numericUpDown1
            numericUpDown1.Location = new Point(120, 60);
            numericUpDown1.Size = new Size(120, 27);

            // checkBox1
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 100);
            checkBox1.Text = "CheckBox";

            // radioButton1
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(150, 100);
            radioButton1.Text = "RadioButton";

            // comboBox1
            comboBox1.Location = new Point(20, 135);
            comboBox1.Size = new Size(330, 28);

            // listBox1
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H" });
            listBox1.Location = new Point(20, 175);
            listBox1.Size = new Size(200, 104);

            // button1
            button1.Location = new Point(80, 295);
            button1.Size = new Size(80, 30);
            button1.Text = "OK";

            // button2
            button2.Location = new Point(190, 295);
            button2.Size = new Size(80, 30);
            button2.Text = "Cancel";

            // Form2
            ClientSize = new Size(380, 350);
            Controls.Add(lb1);
            Controls.Add(txtBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form2";
            Text = "Form2";

            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private Label lb1;
        private TextBox txtBox1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}