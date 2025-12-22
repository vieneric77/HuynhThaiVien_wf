using System;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BT_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Name: {txtName.Text}\n" +
                $"Value: {numericUpDown1.Value}\n" +
                $"CheckBox: {checkBox1.Checked}\n" +
                $"Radio: {radioButton1.Checked}\n" +
                $"Date: {dateTimePicker1.Value.ToShortDateString()}",
                "Thông tin"
            );
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
