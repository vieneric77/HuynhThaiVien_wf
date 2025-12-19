namespace BT_WinForm
{
    partial class Form15
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblDisplay;
        private Button btStart;
        private Button btStop;
        private System.Windows.Forms.Timer tmStopwatch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDisplay = new Label();
            btStart = new Button();
            btStop = new Button();
            tmStopwatch = new System.Windows.Forms.Timer(components);
            SuspendLayout();

            // lblDisplay
            lblDisplay.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblDisplay.Location = new Point(90, 40);
            lblDisplay.Size = new Size(200, 70);
            lblDisplay.Text = "00:00";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;

            // btStart
            btStart.Location = new Point(80, 140);
            btStart.Size = new Size(90, 35);
            btStart.Text = "Start";
            btStart.Click += btStart_Click;

            // btStop
            btStop.Location = new Point(200, 140);
            btStop.Size = new Size(90, 35);
            btStop.Text = "Stop";
            btStop.Click += btStop_Click;

            // tmStopwatch
            tmStopwatch.Interval = 1000;
            tmStopwatch.Tick += tmStopwatch_Tick;

            // Form15
            ClientSize = new Size(380, 220);
            Controls.Add(lblDisplay);
            Controls.Add(btStart);
            Controls.Add(btStop);
            Text = "Timer Article";
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
        }
    }
}
