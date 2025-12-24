using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Game
{
    public partial class F1 : Form
    {
        enum GameState { Home, Playing, GameOver, Win, Setting }
        GameState currentState = GameState.Home;

        System.Windows.Forms.Timer gameTimer;
        Rectangle rectSonic, rectObstacle, rectDragon, rectFireball, rectSonicShot;

        int sonicW, sonicH, dragonSize, obstacleSize;
        int dragonHP = 10;
        bool isSonicShooting = false;
        float currentSpeed;
        int dragonDirection = 1;
        int dragonSpeed = 5;

        // --- BIẾN CHO NỀN VÀ LEVEL ---
        float bgX = 0;
        float bgSpeed = 12f; // Tăng tốc độ nền cơ bản (Level 1 nhanh hơn)
        int level = 1;

        Image bgImg, imgSonicJump, imgSonicFall;
        Image[] dragonFrames = new Image[4];
        Image[] fireballFrames = new Image[2];
        Image[] downFrames = new Image[5];
        Image[] sonicFrames = new Image[4];
        Image[] cocImages = new Image[3];
        Image currentObstacleImg;

        int frameCounter = 0;
        int currentDragonFrame, currentFireballFrame, currentDownFrame, currentSonicFrame;
        bool isCrouching, isJumping, isDragonActive;
        int score, hearts, jumpSpeed, groundY, gravity = 4; // Tăng gravity để rơi nhanh hơn phù hợp tốc độ
        Random rd = new Random();

        Panel settingPanel;

        public F1()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.KeyDown += F1_KeyDown;
            this.KeyUp += F1_KeyUp;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string imgPath = Path.Combine(Application.StartupPath, "Images");
                bgImg = Image.FromFile(Path.Combine(imgPath, "background.jpg"));
                for (int i = 0; i < 3; i++) cocImages[i] = Image.FromFile(Path.Combine(imgPath, $"coc{i + 1}.png"));
                for (int i = 0; i < 4; i++) sonicFrames[i] = Image.FromFile(Path.Combine(imgPath, $"sonic{i + 1}.png"));
                imgSonicJump = Image.FromFile(Path.Combine(imgPath, "nhaylen.png"));
                imgSonicFall = Image.FromFile(Path.Combine(imgPath, "nhayxuong.png"));
                for (int i = 0; i < 5; i++) downFrames[i] = Image.FromFile(Path.Combine(imgPath, $"down{i + 1}.png"));
                for (int i = 0; i < 4; i++) dragonFrames[i] = Image.FromFile(Path.Combine(imgPath, $"rong{i + 1}.png"));
                fireballFrames[0] = Image.FromFile(Path.Combine(imgPath, "caulua.png"));
                fireballFrames[1] = Image.FromFile(Path.Combine(imgPath, "caulua1.png"));

                InitializeSettingPanel();
                ShowHome();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi nạp ảnh: " + ex.Message); }
        }

        void InitializeSettingPanel()
        {
            settingPanel = new Panel { Size = new Size(300, 400), BackColor = Color.FromArgb(220, Color.Black), Visible = false };
            settingPanel.Left = (this.ClientSize.Width - settingPanel.Width) / 2;
            settingPanel.Top = (this.ClientSize.Height - settingPanel.Height) / 2;

            Button btnResume = new Button { Text = "TIẾP TỤC", Size = new Size(200, 50), Top = 80, Left = 50, FlatStyle = FlatStyle.Flat, BackColor = Color.White, Font = new Font("Arial", 12, FontStyle.Bold) };
            btnResume.Click += (s, e) => { settingPanel.Visible = false; gameTimer.Start(); currentState = GameState.Playing; };

            Button btnHome = new Button { Text = "TRANG CHỦ", Size = new Size(200, 50), Top = 160, Left = 50, FlatStyle = FlatStyle.Flat, BackColor = Color.White, Font = new Font("Arial", 12, FontStyle.Bold) };
            btnHome.Click += (s, e) => { settingPanel.Visible = false; ShowHome(); };

            Button btnExit = new Button { Text = "THOÁT", Size = new Size(200, 50), Top = 240, Left = 50, FlatStyle = FlatStyle.Flat, BackColor = Color.Red, ForeColor = Color.White, Font = new Font("Arial", 12, FontStyle.Bold) };
            btnExit.Click += (s, e) => Application.Exit();

            settingPanel.Controls.Add(btnResume); settingPanel.Controls.Add(btnHome); settingPanel.Controls.Add(btnExit);
            this.Controls.Add(settingPanel);
        }

        void ShowHome()
        {
            if (gameTimer != null) gameTimer.Stop();
            currentState = GameState.Home;
            this.Controls.Clear();
            this.Controls.Add(settingPanel);

            Button btStart = new Button { Text = "BẮT ĐẦU", Size = new Size(240, 70), Left = (this.ClientSize.Width - 240) / 2, Top = (this.ClientSize.Height / 2) - 35, Font = new Font("Arial", 16, FontStyle.Bold), BackColor = Color.Orange, FlatStyle = FlatStyle.Flat };
            btStart.Click += (s, ev) => StartGame();

            Button btExit = new Button { Text = "THOÁT", Size = new Size(240, 70), Left = (this.ClientSize.Width - 240) / 2, Top = (this.ClientSize.Height / 2) + 60, Font = new Font("Arial", 16, FontStyle.Bold), BackColor = Color.LightGray, FlatStyle = FlatStyle.Flat };
            btExit.Click += (s, ev) => Application.Exit();

            this.Controls.Add(btStart); this.Controls.Add(btExit);
        }

        void StartGame()
        {
            this.Controls.Clear();
            this.Controls.Add(settingPanel);

            Button btnSetting = new Button { Text = "⚙", Size = new Size(50, 50), Top = 20, Left = this.Width - 80, FlatStyle = FlatStyle.Flat, BackColor = Color.Transparent, ForeColor = Color.Yellow, Font = new Font("Arial", 25) };
            btnSetting.Click += (s, e) => { gameTimer.Stop(); currentState = GameState.Setting; settingPanel.BringToFront(); settingPanel.Visible = true; };
            this.Controls.Add(btnSetting);

            currentState = GameState.Playing;
            groundY = (int)(this.ClientSize.Height * 0.90f);
            sonicW = (int)(this.ClientSize.Width * 0.07f);
            sonicH = (int)(sonicW * 1.2f);
            dragonSize = (int)(this.ClientSize.Height * 0.35f);
            obstacleSize = (int)(this.ClientSize.Height * 0.16f);

            // --- RESET THÔNG SỐ GAME VỚI TỐC ĐỘ CAO ---
            score = 0;
            level = 1;
            hearts = 3;
            dragonHP = 10;
            currentSpeed = 25f; // Khởi đầu nhanh (Cũ là 16)
            bgSpeed = 12f;      // Khởi đầu nhanh (Cũ là 6)
            bgX = 0;
            isDragonActive = false;
            isSonicShooting = false;

            rectSonic = new Rectangle(150, groundY - sonicH, sonicW, sonicH);
            rectDragon = new Rectangle(this.Width - dragonSize - 50, 100, dragonSize, dragonSize);
            rectFireball = new Rectangle(-500, 0, (int)(sonicW * 0.8f), (int)(sonicW * 0.5f));
            rectSonicShot = new Rectangle(-500, 0, (int)(sonicW * 0.8f), (int)(sonicW * 0.5f));

            ResetObstacle();

            gameTimer = new System.Windows.Forms.Timer { Interval = 16 };
            gameTimer.Tick += (s, e) => { UpdatePhysics(); UpdateAnimations(); this.Invalidate(); };
            gameTimer.Start();
        }

        void UpdatePhysics()
        {
            if (currentState != GameState.Playing) return;

            // 1. CẬP NHẬT TỐC ĐỘ THEO LEVEL (Nhanh dần đều)
            level = (score / 10) + 1;
            bgSpeed = 12f + (level * 2f);       // Nền chạy nhanh hơn
            currentSpeed = 25f + (level * 3f);  // Vật cản nhanh hơn

            bgX -= bgSpeed;
            if (bgX <= -this.ClientSize.Width) bgX = 0;

            // 2. LOGIC NHẢY
            if (isJumping)
            {
                rectSonic.Y -= jumpSpeed;
                jumpSpeed -= gravity;
                if (rectSonic.Y >= groundY - rectSonic.Height)
                {
                    rectSonic.Y = groundY - rectSonic.Height;
                    isJumping = false;
                }
            }

            // 3. ĐIỀU KIỆN HIỆN RỒNG
            if (score >= 30 && !isDragonActive) { isDragonActive = true; ResetFireball(); }

            if (!isDragonActive)
            {
                rectObstacle.X -= (int)currentSpeed;
                if (rectObstacle.Right < 0) { score++; ResetObstacle(); }
                if (rectSonic.IntersectsWith(rectObstacle)) HandleHit();
            }
            else
            {
                int currentDragonSpeed = dragonSpeed + (level / 2);
                rectDragon.Y += (dragonDirection * currentDragonSpeed);
                if (rectDragon.Y < 50 || rectDragon.Bottom > groundY) dragonDirection *= -1;

                rectFireball.X -= (int)(currentSpeed + 10);
                if (rectSonic.IntersectsWith(rectFireball)) HandleHit();
                if (rectFireball.Right < 0) ResetFireball();

                if (isSonicShooting)
                {
                    rectSonicShot.X += 50; // Tốc độ đạn Sonic cũng nhanh hơn
                    if (rectSonicShot.IntersectsWith(rectDragon)) { DamageDragon(); isSonicShooting = false; rectSonicShot.X = -500; }
                    if (rectSonicShot.X > this.Width) isSonicShooting = false;
                }
            }
        }

        void UpdateAnimations()
        {
            frameCounter++;
            if (frameCounter % 5 == 0)
            {
                currentSonicFrame = (currentSonicFrame + 1) % 4;
                currentDragonFrame = (currentDragonFrame + 1) % 4;
                currentFireballFrame = (currentFireballFrame + 1) % 2;
                currentDownFrame = (currentDownFrame + 1) % 5;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (bgImg != null)
            {
                g.DrawImage(bgImg, bgX, 0, this.ClientSize.Width + 2, this.ClientSize.Height);
                g.DrawImage(bgImg, bgX + this.ClientSize.Width, 0, this.ClientSize.Width + 2, this.ClientSize.Height);
            }

            if (currentState == GameState.Playing || currentState == GameState.Setting)
            {
                Image sonicImg;
                if (isJumping) sonicImg = (jumpSpeed > 0) ? imgSonicJump : imgSonicFall;
                else if (isCrouching) sonicImg = downFrames[currentDownFrame];
                else sonicImg = sonicFrames[currentSonicFrame];
                g.DrawImage(sonicImg, rectSonic);

                if (!isDragonActive)
                {
                    if (currentObstacleImg != null) g.DrawImage(currentObstacleImg, rectObstacle);
                }
                else
                {
                    g.DrawImage(dragonFrames[currentDragonFrame], rectDragon);
                    g.DrawImage(fireballFrames[currentFireballFrame], rectFireball);
                    if (isSonicShooting) g.DrawImage(fireballFrames[currentFireballFrame], rectSonicShot);
                }

                // UI
                string heartStr = new string('❤', hearts);
                using (Font f = new Font("Impact", 25))
                {
                    g.DrawString($"SCORE: {score}  LVL: {level}  LIFE: {heartStr}", f, Brushes.Yellow, 30, 30);
                    if (isDragonActive)
                    {
                        g.FillRectangle(Brushes.DimGray, this.Width - 350, 40, 300, 20);
                        g.FillRectangle(Brushes.Red, this.Width - 350, 40, (dragonHP * 30), 20);
                        g.DrawString("DRAGON HP", new Font("Arial", 10, FontStyle.Bold), Brushes.White, this.Width - 350, 20);
                    }
                }
            }
        }

        void ResetObstacle()
        {
            currentObstacleImg = cocImages[rd.Next(0, 3)];
            rectObstacle = new Rectangle(this.Width + rd.Next(300, 700), groundY - obstacleSize + 10, obstacleSize, obstacleSize);
        }

        void ResetFireball() { rectFireball.X = rectDragon.X; rectFireball.Y = rectDragon.Y + (rectDragon.Height / 2); }
        void DamageDragon() { dragonHP--; if (dragonHP <= 0) EndGame("BẠN ĐÃ CHIẾN THẮNG!"); }
        void HandleHit() { hearts--; if (hearts <= 0) EndGame("GAME OVER!"); else { if (isDragonActive) ResetFireball(); else rectObstacle.X = this.Width + 500; } }

        private void F1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && currentState == GameState.Playing)
            {
                gameTimer.Stop(); currentState = GameState.Setting; settingPanel.Visible = true;
            }
            if (currentState != GameState.Playing) return;

            if ((e.KeyCode == Keys.Space || e.KeyCode == Keys.Up) && !isJumping)
            {
                isJumping = true;
                jumpSpeed = (int)(this.ClientSize.Height * 0.055f); // Tăng lực nhảy một chút để cân bằng gravity
            }

            if (e.KeyCode == Keys.S && !isJumping)
            {
                isCrouching = true;
                rectSonic.Height = (int)(sonicH * 0.6f);
                rectSonic.Y = groundY - rectSonic.Height;
            }

            if (e.KeyCode == Keys.W && !isSonicShooting && isDragonActive)
            {
                isSonicShooting = true;
                rectSonicShot.X = rectSonic.Right;
                rectSonicShot.Y = rectSonic.Y + (rectSonic.Height / 3);
            }
        }

        private void F1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                isCrouching = false;
                rectSonic.Height = sonicH;
                rectSonic.Y = groundY - sonicH;
            }
        }

        void EndGame(string msg)
        {
            if (gameTimer != null) gameTimer.Stop();
            MessageBox.Show($"{msg}\n\nLEVEL: {level}\nSCORE: {score}");
            ShowHome();
        }
    }
}