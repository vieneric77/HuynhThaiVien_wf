using System;
using System.Drawing;
using System.Windows.Forms;

namespace Form6
{
    public partial class Form6 : Form
    {
        private Form menuForm;

        double currentValue = 0;
        double memoryValue = 0;
        string operation = "";
        bool isNewNumber = true;

        // ===== CONSTRUCTOR MẶC ĐỊNH =====
        public Form6()
        {
            InitializeComponent();
            CreateButtons();
        }

        // ===== CONSTRUCTOR NHẬN MENU (QUAN TRỌNG) =====
        public Form6(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
            CreateButtons();
        }

        // ===== QUAY LẠI MENU KHI ĐÓNG FORM =====
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuForm != null)
                menuForm.Show();
        }

        private void CreateButtons()
        {
            string[,] keys =
            {
                { "MC","MR","MS","M+","M-" },
                { "CE","C","±","√","%" },
                { "7","8","9","/","1/x" },
                { "4","5","6","*","" },
                { "1","2","3","-","=" },
                { "0",".","+","","" }
            };

            int startX = 12, startY = 70;

            for (int r = 0; r < keys.GetLength(0); r++)
            {
                for (int c = 0; c < keys.GetLength(1); c++)
                {
                    if (keys[r, c] == "") continue;

                    Button b = new Button();
                    b.Text = keys[r, c];
                    b.Size = new Size(70, 45);
                    b.Location = new Point(startX + c * 72, startY + r * 47);

                    if (char.IsDigit(b.Text[0])) b.Click += Number_Click;
                    else if (b.Text == ".") b.Click += Dot_Click;
                    else if ("+-*/".Contains(b.Text)) b.Click += Operator_Click;
                    else if (b.Text == "=") b.Click += Equal_Click;
                    else if (b.Text == "C") b.Click += Clear_Click;
                    else if (b.Text == "CE") b.Click += ClearEntry_Click;
                    else if (b.Text == "±") b.Click += Sign_Click;
                    else if (b.Text == "√") b.Click += Sqrt_Click;
                    else if (b.Text == "%") b.Click += Percent_Click;
                    else if (b.Text == "1/x") b.Click += Invert_Click;
                    else if (b.Text == "MC") b.Click += (s, e) => memoryValue = 0;
                    else if (b.Text == "MR") b.Click += (s, e) => txtDisplay.Text = memoryValue.ToString();
                    else if (b.Text == "MS") b.Click += (s, e) => memoryValue = double.Parse(txtDisplay.Text);
                    else if (b.Text == "M+") b.Click += (s, e) => memoryValue += double.Parse(txtDisplay.Text);
                    else if (b.Text == "M-") b.Click += (s, e) => memoryValue -= double.Parse(txtDisplay.Text);

                    Controls.Add(b);
                }
            }
        }

        // ===== EVENTS =====
        private void Number_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (isNewNumber)
            {
                txtDisplay.Text = b.Text;
                isNewNumber = false;
            }
            else txtDisplay.Text += b.Text;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            currentValue = double.Parse(txtDisplay.Text);
            operation = (sender as Button).Text;
            isNewNumber = true;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double v = double.Parse(txtDisplay.Text);
            double r = 0;

            if (operation == "+") r = currentValue + v;
            if (operation == "-") r = currentValue - v;
            if (operation == "*") r = currentValue * v;
            if (operation == "/") r = v != 0 ? currentValue / v : 0;

            txtDisplay.Text = r.ToString();
            isNewNumber = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            currentValue = 0;
            operation = "";
            isNewNumber = true;
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            isNewNumber = true;
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (-double.Parse(txtDisplay.Text)).ToString();
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.Sqrt(double.Parse(txtDisplay.Text)).ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (double.Parse(txtDisplay.Text) / 100).ToString();
        }

        private void Invert_Click(object sender, EventArgs e)
        {
            double v = double.Parse(txtDisplay.Text);
            if (v != 0) txtDisplay.Text = (1 / v).ToString();
        }
    }
}
