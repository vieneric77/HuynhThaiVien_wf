namespace BT_WinForm.GUI
{
    partial class Form10
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDisplay;
        private Button[] numberButtons;
        private Button btnAdd, btnSub, btnMul, btnDiv, btnEqual;
        private Button btnClear, btnCE, btnDot, btnPercent, btnReciprocal, btnSign;
        private Button btnMC, btnMR, btnMS, btnMPlus, btnMMinus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            numberButtons = new Button[10];
            SuspendLayout();

            // Display
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Size = new Size(310, 47);
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.Text = "0";

            // Memory buttons
            string[] mem = { "MC", "MR", "MS", "M+", "M-" };
            for (int i = 0; i < 5; i++)
            {
                Button b = new Button();
                b.Text = mem[i];
                b.Size = new Size(56, 35);
                b.Location = new Point(12 + i * 62, 70);
                b.Click += Memory_Click;
                Controls.Add(b);
            }

            // Number buttons
            int x = 12, y = 120, n = 1;
            for (int i = 1; i <= 9; i++)
            {
                numberButtons[i] = new Button();
                numberButtons[i].Text = i.ToString();
                numberButtons[i].Size = new Size(56, 45);
                numberButtons[i].Location = new Point(x, y);
                numberButtons[i].Click += Number_Click;
                Controls.Add(numberButtons[i]);
                x += 62;
                if (i % 3 == 0) { x = 12; y += 50; }
            }

            numberButtons[0] = new Button();
            numberButtons[0].Text = "0";
            numberButtons[0].Size = new Size(118, 45);
            numberButtons[0].Location = new Point(12, y);
            numberButtons[0].Click += Number_Click;
            Controls.Add(numberButtons[0]);

            // Operators
            btnAdd = CreateOp("+", 200, 270);
            btnSub = CreateOp("-", 200, 220);
            btnMul = CreateOp("*", 200, 170);
            btnDiv = CreateOp("/", 200, 120);
            btnEqual = CreateOp("=", 262, 220);
            btnEqual.Size = new Size(56, 95);

            btnDot = CreateOp(".", 138, 270);
            btnCE = CreateOp("CE", 262, 120);
            btnClear = CreateOp("C", 262, 170);
            btnPercent = CreateOp("%", 138, 120);
            btnReciprocal = CreateOp("1/x", 138, 170);
            btnSign = CreateOp("±", 138, 220);

            Controls.AddRange(new Control[] {
                txtDisplay, btnAdd, btnSub, btnMul, btnDiv, btnEqual,
                btnDot, btnCE, btnClear, btnPercent, btnReciprocal, btnSign
            });

            ClientSize = new Size(335, 340);
            Text = "My Calculator";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        private Button CreateOp(string text, int x, int y)
        {
            Button b = new Button();
            b.Text = text;
            b.Size = new Size(56, 45);
            b.Location = new Point(x, y);
            b.Click += Operator_Click;
            return b;
        }
    }
}
