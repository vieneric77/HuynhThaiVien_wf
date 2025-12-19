namespace BT_WinForm.GUI
{
    public partial class Form10 : Form
    {
        double value = 0;
        string operation = "";
        bool isNew = true;
        double memory = 0;

        public Form10()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (isNew)
            {
                txtDisplay.Text = b.Text;
                isNew = false;
            }
            else
                txtDisplay.Text += b.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            switch (b.Text)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    value = double.Parse(txtDisplay.Text);
                    operation = b.Text;
                    isNew = true;
                    break;

                case "=":
                    Calculate();
                    break;

                case "C":
                    txtDisplay.Text = "0";
                    value = 0;
                    operation = "";
                    isNew = true;
                    break;

                case "CE":
                    txtDisplay.Text = "0";
                    isNew = true;
                    break;

                case ".":
                    if (!txtDisplay.Text.Contains("."))
                        txtDisplay.Text += ".";
                    break;

                case "±":
                    txtDisplay.Text = (-double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "%":
                    txtDisplay.Text = (double.Parse(txtDisplay.Text) / 100).ToString();
                    break;

                case "1/x":
                    txtDisplay.Text = (1 / double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void Calculate()
        {
            double second = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+": value += second; break;
                case "-": value -= second; break;
                case "*": value *= second; break;
                case "/": value /= second; break;
            }
            txtDisplay.Text = value.ToString();
            isNew = true;
        }

        private void Memory_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            double current = double.Parse(txtDisplay.Text);

            switch (b.Text)
            {
                case "MC": memory = 0; break;
                case "MR": txtDisplay.Text = memory.ToString(); break;
                case "MS": memory = current; break;
                case "M+": memory += current; break;
                case "M-": memory -= current; break;
            }
            isNew = true;
        }
    }
}
