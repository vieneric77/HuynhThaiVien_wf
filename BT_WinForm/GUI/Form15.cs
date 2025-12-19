using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BT_WinForm
{
    public partial class Form15 : Form
    {
        int seconds = 0;

        public Form15()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            seconds++;
            int min = seconds / 60;
            int sec = seconds % 60;
            lblDisplay.Text = min.ToString("00") + ":" + sec.ToString("00");
        }
    }
}
