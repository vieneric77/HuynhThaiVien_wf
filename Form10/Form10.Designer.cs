namespace Form10
{
    partial class Form10
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chicken = new System.Windows.Forms.PictureBox();
            this.egg = new System.Windows.Forms.PictureBox();
            this.basket = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chicken
            // 
            this.chicken.Location = new System.Drawing.Point(180, 10);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(80, 80);
            this.chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // egg
            // 
            this.egg.Location = new System.Drawing.Point(200, 90);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(30, 40);
            this.egg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // basket
            // 
            this.basket.Location = new System.Drawing.Point(180, 360);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(80, 60);
            this.basket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblScore.Location = new System.Drawing.Point(10, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 21);
            this.lblScore.Text = "Score: 0";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.chicken);
            this.KeyPreview = true;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catch Egg Game";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form10_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox chicken;
        private System.Windows.Forms.PictureBox egg;
        private System.Windows.Forms.PictureBox basket;
        private System.Windows.Forms.Label lblScore;
    }
}
