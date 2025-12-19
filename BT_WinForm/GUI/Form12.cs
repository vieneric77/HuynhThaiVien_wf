using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace BT_WinForm
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        // Click OK → Long Date
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // Change Date → Short Date
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}
