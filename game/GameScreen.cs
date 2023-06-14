using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
namespace game
{

    public partial class GameScreen : Form
    {
        Random r = new Random();
        GameOver gameWindow = new GameOver();
        Stopwatch stopWatch;

        bool goleft = false;
        bool goright = false;
        bool goup = false;
        bool godown = false;
        
        int hearts = 3;
        int newHeart = 0;
        int index = 1;
        int indexHeart = 0;
        int level = 1;

        int heartY = 52;
        int heart1X = 56;
        int heart2X = 37;

        public static String timeValue;

        public GameScreen()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }


        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.A)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
            }
        }

        private void playerTimer_Tick(object sender, EventArgs e)
        {
            this.stopwatchLabel.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);

            if (goleft)
            {
                if (player.Left - 5 >= 0)
                {
                    player.Left -= 5;
                }
            }

            if (goright)
            {
                if((player.Right + 5) <= (Width - (0.4 * player.Width)))
                {
                    player.Left += 5;
                }
            }

            if (godown)
            {
                if ((player.Top + 5) <= (Height - (2 * player.Height)))
                {
                    player.Top += 5;
                }
            }

            if (goup)
            {
                if ((player.Top - 5) >= 0)
                {
                    player.Top -= 5;
                }
            }
            
            foreach (Control n in Controls)
            {
                if (n is PictureBox && n.Tag != null && n.Tag.ToString().Equals("enemy"))
                {
                    
                    if(player.Bounds.IntersectsWith(n.Bounds) && hearts > 0)
                    {
                        Controls.Remove(n);
                        Controls.Remove(Controls.Find("heart" + index, true)[0]);
                        
                        if (index == 3)
                        {
                            timeValue = stopwatchLabel.Text;
                            StopTimers();
                            Hide();
                            gameWindow.Closed += (s, args) => Close();
                            gameWindow.Show();
                        }
                        indexHeart++;
                        hearts--;
                        index++;
                    }
                }

                if (n is PictureBox && n.Tag != null && n.Tag.ToString() == "newHeart")
                {
                    if (player.Bounds.IntersectsWith(n.Bounds))
                    {
                        Controls.Remove(n);
                        index--;
                        if (index == 1)
                        {
                            AddHeartBox(heart1X);
                        }
                        if (index == 2)
                        {
                            AddHeartBox(heart2X);
                        }
                        
                        newHeart--;
                        hearts++;
                        indexHeart--;
                    }
                }
            }

        }

        private void fallingTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control enemy in Controls)
            {
                if (enemy is PictureBox && enemy.Tag != null && enemy.Tag.ToString() == "enemy")
                {
                    if(level > 3)
                    {
                        enemy.Top += 7;
                    }
                    else
                    {
                        enemy.Top += 5;
                    }
                    if(enemy.Location.Y >= Height)
                    {
                        Controls.Remove(enemy);
                    }
                }
            }
            
        }

        private void createEnemyTimer_Tick(object sender, EventArgs e)
        {
            CreateEnemyBox();
        }

        
        private void operateTimer_Tick(object sender, EventArgs e)
        {
            ChangeDifficulty();
            SpawnHearts();
        }
        private void createPlayerEnemy_Tick(object sender, EventArgs e)
        {
            CreatePlayerEnemyBox();
        }

        private void ChangeDifficulty()
        {
            if (fallingTimer.Interval > 10 && createEnemyTimer.Interval > 200)
            {
                level++;
                label1.Text = "level: " + level;
            }

            if (playerTimer.Interval > 12)
            {
                playerTimer.Interval -= 2;
            }

            //timer2
            if (fallingTimer.Interval > 10)
            {
                fallingTimer.Interval -= 10;
            }
            if (fallingTimer.Interval > 5 && fallingTimer.Interval <= 10)
            {
                fallingTimer.Interval--;
            }

            //timer3
            if (createEnemyTimer.Interval > 500)
            {
                createEnemyTimer.Interval -= 500;
            }
            if (createEnemyTimer.Interval > 200 && createEnemyTimer.Interval <= 500)
            {
                createEnemyTimer.Interval -= 100;
            }
        }

        private void CreateEnemyBox()
        {
            int x = r.Next(0, Width - 40);
            createPictureBox("enemy", "enemy", x, 0, 20);
        }

        private void CreatePlayerEnemyBox()
        {
            int x = player.Location.X;
            createPictureBox("enemy", "enemy", x, 0, 20);
        }

        private void AddHeartBox(int heartX)
        {
            int x = heartX;
            String name = "heart" + indexHeart;
            createPictureBox(name, "heart", x, heartY, 13);
        }

        private void CreateNewHeartBox()
        {
            int x = r.Next(0, Width - 40);
            int y = r.Next((Height - 40)/2, Height - 40);
            String name = "newHeart";
            createPictureBox(name, name, x, y, 15);
        }

        private void createPictureBox(String name, String tag, int x, int y, int size)
        {
            Color color = Color.Red;
            if (tag.Equals("newHeart") || tag.Equals("heart"))
            {
                color = Color.Lime;
            }
            
            var pic = new PictureBox
            {
                Size = new Size(size, size),
                BackColor = color,
                Tag = tag,
                Name = name,
                Location = new Point(x, y),
            };
            Controls.Add(pic);
        }

        private void SpawnHearts()
        {
            if(hearts < 3 && newHeart < 3 - hearts)
            {
                CreateNewHeartBox();
                newHeart++;
            }
        }

        private void StopTimers()
        {
            playerTimer.Stop();
            fallingTimer.Stop();
            createEnemyTimer.Stop();
            operateTimer.Stop();
            stopWatch.Stop();
        }
    }
}
