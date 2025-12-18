namespace BT_WinForm.GUI
{
    partial class Form5
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
            tbDisplay = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btnPlus = new Button();
            btMul = new Button();
            btDoc = new Button();
            btEquals = new Button();
            SuspendLayout();

            // tbDisplay
            tbDisplay.Font = new Font("Segoe UI", 16F);
            tbDisplay.Location = new Point(20, 20);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.ReadOnly = true;
            tbDisplay.Size = new Size(260, 43);
            tbDisplay.TextAlign = HorizontalAlignment.Right;
            tbDisplay.Text = "0";

            // bt0
            bt0.Location = new Point(20, 80);
            bt0.Size = new Size(60, 50);
            bt0.Text = "0";
            bt0.Click += bt0_Click;

            // bt1
            bt1.Location = new Point(90, 80);
            bt1.Size = new Size(60, 50);
            bt1.Text = "1";
            bt1.Click += bt1_Click;

            // bt2
            bt2.Location = new Point(160, 80);
            bt2.Size = new Size(60, 50);
            bt2.Text = "2";
            bt2.Click += bt2_Click;

            // bt3
            bt3.Location = new Point(230, 80);
            bt3.Size = new Size(60, 50);
            bt3.Text = "3";
            bt3.Click += bt3_Click;

            // btnPlus
            btnPlus.Location = new Point(20, 140);
            btnPlus.Size = new Size(60, 50);
            btnPlus.Text = "+";
            btnPlus.Click += btnPlus_Click;

            // btMul
            btMul.Location = new Point(90, 140);
            btMul.Size = new Size(60, 50);
            btMul.Text = "*";
            btMul.Click += btMul_Click;

            // btDoc
            btDoc.Location = new Point(160, 140);
            btDoc.Size = new Size(60, 50);
            btDoc.Text = ".";
            btDoc.Click += btDoc_Click;

            // btEquals
            btEquals.Location = new Point(230, 140);
            btEquals.Size = new Size(60, 50);
            btEquals.Text = "=";
            btEquals.Click += btEquals_Click;

            // Form6
            ClientSize = new Size(310, 210);
            Controls.AddRange(new Control[]
            {
        tbDisplay, bt0, bt1, bt2, bt3,
        btnPlus, btMul, btDoc, btEquals
            });

            Name = "Form6";
            Text = "Simple Calculator";
            Load += Form6_Load;

            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btnPlus;
        private Button btMul;
        private Button btDoc;
        private Button btEquals;
    }
}