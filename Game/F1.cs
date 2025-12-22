using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using WMPLib;
using System.IO;

namespace Game
{
    public partial class F1 : Form
    {
        enum GameState { Home, Playing, GameOver }
        GameState currentState = GameState.Home;

        Timer gameTimer, aniTimer;
        WindowsMediaPlayer bgmPlayer;
        PictureBox pbSonic, pbObstacle;

        // --- CÁC BIẾN CHO RỒNG VÀ CẦU LỬA ---
        PictureBox pbDragon, pbFireball;
        Image[] dragonFrames = new Image[4];
        Image[] fireballFrames = new Image[2]; // Mảng chứa 2 khung hình cầu lửa
        int currentDragonFrame = 0;
        int currentFireballFrame = 0; // Biến đếm khung hình cầu lửa
        bool isDragonActive = false;
        float fireballSpeed = 12.0f;

        Label lbScore, lbHearts;
        Button btStart, btExit, btHome;
        Random rd = new Random();

        int bgX1 = 0;
        int bgX2;
        bool isJumping = false;
        int jumpSpeed = 0;
        int gravity = 1;
        int groundY;

        float obstacleSpeed = 8.0f;
        Image[] cocImages = new Image[3];
        int score = 0;
        int hearts = 3;

        Image[] sonicFrames = new Image[4];
        int currentSonicFrame = 0;
        Image bgImg;
        SoundPlayer hitSound, gameOverSound, jumpSound;

        public F1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += F1_KeyDown;
            this.Resize += F1_Resize;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string imgPath = Path.Combine(Application.StartupPath, "Images");
                string soundPath = Path.Combine(Application.StartupPath, "Sounds");

                // Tải tài nguyên cơ bản
                bgImg = Image.FromFile(Path.Combine(imgPath, "background.jpg"));
                for (int i = 0; i < 3; i++) cocImages[i] = Image.FromFile(Path.Combine(imgPath, $"coc{i + 1}.png"));
                for (int i = 0; i < 4; i++) sonicFrames[i] = Image.FromFile(Path.Combine(imgPath, $"sonic{i + 1}.png"));

                // TẢI ẢNH RỒNG VÀ CẦU LỬA (ĐÃ CẬP NHẬT)
                for (int i = 0; i < 4; i++) dragonFrames[i] = Image.FromFile(Path.Combine(imgPath, $"rong{i + 1}.png"));
                fireballFrames[0] = Image.FromFile(Path.Combine(imgPath, "caulua.png"));
                fireballFrames[1] = Image.FromFile(Path.Combine(imgPath, "caulua1.png"));

                hitSound = new SoundPlayer(Path.Combine(soundPath, "hit.wav"));
                gameOverSound = new SoundPlayer(Path.Combine(soundPath, "gameover.wav"));
                jumpSound = new SoundPlayer(Path.Combine(soundPath, "tiengga.wav"));

                bgmPlayer = new WindowsMediaPlayer();
                bgmPlayer.settings.volume = 40;

                // Khởi tạo PictureBox
                pbDragon = new PictureBox { Size = new Size(200, 200), SizeMode = PictureBoxSizeMode.StretchImage, BackColor = Color.Transparent, Visible = false };
                pbFireball = new PictureBox { Size = new Size(80, 50), Image = fireballFrames[0], SizeMode = PictureBoxSizeMode.StretchImage, BackColor = Color.Transparent, Visible = false };

                ShowHome();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải tài nguyên: " + ex.Message); Application.Exit(); }
        }

        private void F1_Resize(object sender, EventArgs e)
        {
            bgX2 = this.ClientSize.Width;
            if (currentState == GameState.Playing)
            {
                groundY = this.ClientSize.Height - 160;
                if (!isJumping) pbSonic.Top = groundY;
                pbObstacle.Top = groundY + 15;
                pbDragon.Location = new Point(this.ClientSize.Width - 250, groundY - 150);
            }
            else CenterMenuControls();
        }

        private void CenterMenuControls()
        {
            foreach (Control c in this.Controls)
                if (c is Button || c is Label) c.Left = (this.ClientSize.Width - c.Width) / 2;
        }

        void ShowHome()
        {
            currentState = GameState.Home;
            Controls.Clear();
            bgX1 = 0;
            bgX2 = this.ClientSize.Width;

            Label title = new Label { Text = "SONIC vs DRAGON", Font = new Font("Segoe UI", 55, FontStyle.Bold), ForeColor = Color.DeepSkyBlue, BackColor = Color.Transparent, AutoSize = true };
            btStart = new Button { Text = "BẮT ĐẦU", Size = new Size(250, 60), Font = new Font("Arial", 14), FlatStyle = FlatStyle.Flat, BackColor = Color.White };
            btStart.Click += (s, e) => StartGame();

            this.Controls.Add(title); this.Controls.Add(btStart);
            title.Location = new Point(0, 150); btStart.Location = new Point(0, 320);
            CenterMenuControls();
        }

        void StartGame()
        {
            currentState = GameState.Playing;
            Controls.Clear();
            score = 0; hearts = 3; obstacleSpeed = 8.0f;
            isDragonActive = false;
            groundY = this.ClientSize.Height - 160;

            lbScore = new Label { Text = "Điểm: 0", Font = new Font("Arial", 20, FontStyle.Bold), ForeColor = Color.Yellow, BackColor = Color.Transparent, Location = new Point(30, 30), AutoSize = true };
            lbHearts = new Label { Text = "Mạng: ❤️❤️❤️", Font = new Font("Arial", 20), ForeColor = Color.Red, BackColor = Color.Transparent, Location = new Point(30, 75), AutoSize = true };

            pbSonic = new PictureBox { Size = new Size(100, 130), Image = sonicFrames[0], SizeMode = PictureBoxSizeMode.StretchImage, BackColor = Color.Transparent, Location = new Point(120, groundY) };
            pbObstacle = new PictureBox { Size = new Size(110, 120), SizeMode = PictureBoxSizeMode.StretchImage, BackColor = Color.Transparent };

            ResetObstacle();

            this.Controls.Add(lbScore); this.Controls.Add(lbHearts);
            this.Controls.Add(pbSonic); this.Controls.Add(pbObstacle);
            this.Controls.Add(pbFireball); this.Controls.Add(pbDragon);

            pbDragon.Location = new Point(this.ClientSize.Width - 250, groundY - 150);
            pbDragon.Visible = false;
            pbFireball.Visible = false;

            gameTimer = new Timer { Interval = 15 };
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            aniTimer = new Timer { Interval = 70 };
            aniTimer.Tick += (s, e) => {
                // Hoạt ảnh Sonic
                if (!isJumping)
                {
                    currentSonicFrame = (currentSonicFrame + 1) % 4;
                    pbSonic.Image = sonicFrames[currentSonicFrame];
                }
                // Hoạt ảnh Rồng và Cầu Lửa (ĐÃ CẬP NHẬT)
                if (isDragonActive)
                {
                    currentDragonFrame = (currentDragonFrame + 1) % 4;
                    pbDragon.Image = dragonFrames[currentDragonFrame];

                    currentFireballFrame = (currentFireballFrame + 1) % 2;
                    pbFireball.Image = fireballFrames[currentFireballFrame];
                }
            };
            aniTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            bgX1 -= (int)obstacleSpeed;
            bgX2 -= (int)obstacleSpeed;
            if (bgX1 <= -this.ClientSize.Width) bgX1 = bgX2 + this.ClientSize.Width;
            if (bgX2 <= -this.ClientSize.Width) bgX2 = bgX1 + this.ClientSize.Width;
            this.Invalidate();

            if (isJumping)
            {
                pbSonic.Top -= jumpSpeed;
                jumpSpeed -= gravity;
                if (pbSonic.Top >= groundY) { pbSonic.Top = groundY; isJumping = false; }
            }

            pbObstacle.Left -= (int)obstacleSpeed;
            if (pbObstacle.Right < 0)
            {
                score++;
                lbScore.Text = $"Điểm: {score}";
                obstacleSpeed += 0.2f;
                ResetObstacle();

                if (score >= 10 && !isDragonActive)
                {
                    isDragonActive = true;
                    pbDragon.Visible = true;
                    ResetFireball();
                }
            }

            if (isDragonActive)
            {
                pbFireball.Left -= (int)fireballSpeed;
                if (pbFireball.Right < 0) ResetFireball();

                if (pbSonic.Bounds.IntersectsWith(pbFireball.Bounds)) HandleCollision();
            }

            Rectangle sRect = new Rectangle(pbSonic.Left + 25, pbSonic.Top + 10, pbSonic.Width - 50, pbSonic.Height - 20);
            Rectangle oRect = new Rectangle(pbObstacle.Left + 20, pbObstacle.Top + 20, pbObstacle.Width - 40, pbObstacle.Height - 30);
            if (sRect.IntersectsWith(oRect)) HandleCollision();
        }

        void HandleCollision()
        {
            try { hitSound.Play(); } catch { }
            hearts--;
            UpdateHeartsUI();
            ResetObstacle();
            ResetFireball();
            if (hearts <= 0)
            {
                gameTimer.Stop();
                aniTimer.Stop();
                try { gameOverSound.Play(); } catch { }
                EndGame();
            }
        }

        void ResetFireball()
        {
            if (!isDragonActive) return;
            pbFireball.Visible = true;
            pbFireball.Location = new Point(pbDragon.Left, pbDragon.Top + 80);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (bgImg != null)
            {
                e.Graphics.DrawImage(bgImg, bgX1, 0, this.ClientSize.Width + 2, this.ClientSize.Height);
                e.Graphics.DrawImage(bgImg, bgX2, 0, this.ClientSize.Width + 2, this.ClientSize.Height);
            }
        }

        void ResetObstacle()
        {
            int type = rd.Next(0, 3);
            pbObstacle.Image = cocImages[type];
            int minGap = (int)(obstacleSpeed * 40);
            int randomGap = rd.Next(minGap, minGap + 600);
            pbObstacle.Location = new Point(this.ClientSize.Width + randomGap, groundY + 15);
        }

        void UpdateHeartsUI()
        {
            string heartText = "Mạng: ";
            for (int i = 0; i < hearts; i++) heartText += "❤️";
            lbHearts.Text = heartText;
        }

        private void F1_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentState == GameState.Playing && !isJumping)
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
                {
                    isJumping = true;
                    jumpSpeed = 22;
                    try { jumpSound.Play(); } catch { }
                }
        }

        void EndGame()
        {
            currentState = GameState.GameOver;
            Controls.Clear();
            Label lbOver = new Label { Text = $"GAME OVER\nĐiểm: {score}", Font = new Font("Arial", 35, FontStyle.Bold), ForeColor = Color.White, BackColor = Color.Transparent, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter };
            btHome = new Button { Text = "THỬ LẠI", Size = new Size(200, 55), Font = new Font("Arial", 12) };
            btHome.Click += (s, e) => ShowHome();
            this.Controls.Add(lbOver); this.Controls.Add(btHome);
            lbOver.Location = new Point(0, 200); btHome.Location = new Point(0, 400);
            CenterMenuControls();
        }
    }
}