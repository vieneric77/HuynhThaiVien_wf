using System;
using System.Windows.Forms;

namespace Form5
{
    public partial class Form5 : Form
    {
        private Form menuForm;

        double num1 = 0;
        string op = "";
        bool isNewNumber = true;

        // ===== CONSTRUCTOR MẶC ĐỊNH =====
        public Form5()
        {
            InitializeComponent();
        }

        // ===== CONSTRUCTOR NHẬN MENU =====
        public Form5(Form menu)
        {
            InitializeComponent();
            menuForm = menu;
        }

        // ===== QUAY LẠI MENU KHI ĐÓNG FORM =====
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuForm != null)
                menuForm.Show();
        }

        // ===== CLICK SỐ =====
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (isNewNumber)
            {
                txtDisplay.Text = btn.Text;
                isNewNumber = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        // ===== CLICK DẤU . =====
        private void Dot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        // ===== CLICK TOÁN TỬ =====
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            num1 = double.Parse(txtDisplay.Text);
            op = btn.Text;
            isNewNumber = true;
        }

        // ===== CLICK = =====
        private void Equal_Click(object sender, EventArgs e)
        {
            double num2 = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
            }

            txtDisplay.Text = result.ToString();
            isNewNumber = true;
        }
    }
}
