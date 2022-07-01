using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endless_Runner
{
    public partial class Game : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        bool w, a, s, d;
        int gamespeed;

        int speed;
        bool gamestop;

        int hearts;
        int timerboss;
        
        public Game()
        {
            InitializeComponent();

            DoubleBuffered = true;
            gamespeed = 10;
            
            speed = 1;
            gamestop = false;

            hearts = 3;
            prbHealth.Value = 3;
            prbHealth.Maximum = 3;
            timerboss = 60; 
            bosstime.Maximum = 60; 
            bosstime.Value = 60;
            label1.Text = " ";
        }

        private void Game_KeyUp(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.D)
            {
                d = false;
            }
            if (e.KeyCode == Keys.A)
            {
                a = false;
            }
            if (e.KeyCode == Keys.W)
            {
                w = false;
            }
            if (e.KeyCode == Keys.S)
            {
                s = false;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.D)
            {
                d = true;
            }
            if (e.KeyCode == Keys.A)
            {
                a = true;
            }
            if (e.KeyCode == Keys.W)
            {
                w = true;
            }
            if (e.KeyCode == Keys.S)
            {
                s = true;
            }
        }

        private void Game_Load(object sender, EventArgs e) 
        {
            sp.SoundLocation = "belveth.wav";
            sp.Load();
            sp.PlayLooping();

            
        }

        private void healthtimer_Tick(object sender, EventArgs e)
        {
            newLife();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playermovement();
            enemies_movement();
            health();

            speed++;

            if(speed % 1000 == 0)
            {
                gamespeed += 1;
            }
        }

        void newLife() 
        {
            Random random = new Random();

            life.Left -= 6;

            if(life.Left < 0)
            {
                int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - life.Height), this.ClientSize.Height);
                life.Location = new Point(this.ClientSize.Width, a);
            }
        }

        void health() 
        {
            Random random = new Random();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "enemy")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        hearts -= 1;
                        int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - x.Height), this.ClientSize.Height);
                        x.Location = new Point(this.ClientSize.Width, a);
                        change_Prb_Health();
                    }
                }

                if(x is PictureBox && x.Tag == "life")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (hearts < 3)
                        {
                            hearts += 1;
                        }
                        int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - x.Height), this.ClientSize.Height);
                        x.Location = new Point(this.ClientSize.Width, a);
                        change_Prb_Health();
                    }
                }

                if(x is PictureBox && x.Tag == "new")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        hearts -= 1;
                        int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - x.Height), this.ClientSize.Height);
                        x.Location = new Point(this.ClientSize.Width, a);
                    }

                    
                }
            }

            if(hearts == 0)
            {
                timer1.Stop();
                healthtimer.Stop();
                bosstimer.Stop();

                DialogResult = MessageBox.Show(" ", "Do you want to retry?", MessageBoxButtons.RetryCancel);

                if(DialogResult == DialogResult.Retry)
                {
                    this.Hide();
                    Game game = new Game();
                    game.ShowDialog();
                    this.Close();
                }

                else
                {
                    this.Hide();
                   
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }

        void new_health()
        {
            Random random = new Random();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        hearts -= 1;

                        int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - x.Height), this.ClientSize.Height);
                        x.Location = new Point(this.ClientSize.Width, a);
                        
                        change_Prb_Health();
                    }
                }

                if (x is PictureBox && x.Tag == "life")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (hearts < 3)
                        {
                            hearts += 1;
                        }
                        
                        change_Prb_Health();
                    }
                }

                if (x is PictureBox && x.Tag == "new")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        hearts -= 1;
                        int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - x.Height), this.ClientSize.Height);
                        x.Location = new Point(this.ClientSize.Width, a);
                        change_Prb_Health();

                    }


                }
            }

            if (hearts == 0)
            {
                timer1.Stop();
                healthtimer.Stop();
               
                final.Stop();

                DialogResult = MessageBox.Show(" ", "Do you want to retry?", MessageBoxButtons.RetryCancel);

                if (DialogResult == DialogResult.Retry)
                {
                    this.Hide();
                    Game game = new Game();
                    game.ShowDialog();
                    this.Close();
                }

                else
                {
                    this.Hide();
                    
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }

        private void bosstimer_Tick(object sender, EventArgs e)
        {
            timerboss -= 1;
            label1.Text = string.Format("Time until boss: {0:00}:{1:00}", timerboss / 60, timerboss % 60);
            bosstime.Value = timerboss;

            if(bosstime.Value >= 20 && bosstime.Value <= 40)
            {
                bosstime.ForeColor = Color.MediumOrchid;
            }

            if(bosstime.Value <= 20)
            {
                bosstime.ForeColor = Color.BlueViolet;
            }

            if(timerboss == 0)
            {
                
               
                final.Enabled = true;
                final.Start();
                this.BackgroundImage = Properties.Resources.boss;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                e4.Show();
                e5.Show();
                sp.Stop();
            }
        }

        private void bosstime_Click(object sender, EventArgs e)
        {
            
        }

        private void final_Tick(object sender, EventArgs e)
        {
            speed++;

            if (speed % 1000 == 0)
            {
                gamespeed += 1;
            }


            timer1.Stop();
            playermovement();
            bosstimer.Stop();
            healthtimer.Stop();
            life.Hide();
            label1.Hide();
            new_enemies();
            enemies_movement();
            change_Prb_Health();
            new_health();
            
        }

        void new_enemies()
        {
            Random random = new Random();

            e4.Left += gamespeed / 2;

            if(e4.Left > this.ClientSize.Width)
            {
                int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - e4.Height), this.ClientSize.Height);
                e4.Location = new Point(0, a);
            }

            e5.Left += gamespeed * 2 / 4;

            if(e5.Left > this.ClientSize.Width)
            {
                int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - e5.Height), this.ClientSize.Height);
                e5.Location = new Point(0, a);
            }
        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (e.KeyChar == char.ToLower((char)Keys.P) && gamestop == false)
            {
                gamestop = true;


                bosstimer.Stop();
                healthtimer.Stop();
                
                timer1.Stop();
            }

            else if(e.KeyChar == char.ToLower((char)Keys.P) && gamestop == true)
            {
                gamestop = false;
                bosstimer.Start();
                healthtimer.Start();
               
                timer1.Start();
                
            }

           

        }

        

        void change_Prb_Health() 
        {
            if(hearts == 1)
            {
                prbHealth.ForeColor = Color.Crimson;
                prbHealth.Value = hearts;
            }

            if(hearts == 2)
            {
                prbHealth.ForeColor = Color.Yellow;
                prbHealth.Value = hearts;
            }

            if(hearts == 3)
            {
                prbHealth.ForeColor = Color.Chartreuse;
                prbHealth.Value = hearts;
            }
        }

        void playermovement() 
        {
            if (d == true)
            {

                if (player.Left < this.ClientSize.Width - player.Width - 5)
                {
                    player.Left += 10;
                }
            }
            if (a == true)
            {
                if (player.Left >= 0)
                {
                    player.Left -= 10;
                }
            }

            if (w == true)
            {
                if (player.Top >= 0)
                {
                    player.Top -= 10;
                }
            }
            if (s == true)
            {
                if (player.Top < this.ClientSize.Height - player.Height - 5)
                {
                    player.Top += 10;
                }
            }
        }

        void enemies_movement() 
        {
            Random random = new Random();

            e1.Left -= gamespeed / 2;

            if(e1.Left < 0)
            {
                int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - 25), this.ClientSize.Height);
               
                e1.Location = new Point(this.ClientSize.Width, a);
            }

            e2.Left -= gamespeed * 2 / 4;

            if(e2.Left < 0)
            {
                int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - 25), this.ClientSize.Height);
               
                e2.Location = new Point(this.ClientSize.Width, a);
            }

            e3.Left -= gamespeed * 2 / 3;
            
            if(e3.Left < 0)
            {
                int a = random.Next(this.ClientSize.Height - (this.ClientSize.Height - 25), this.ClientSize.Height);
                
                e3.Location = new Point(this.ClientSize.Width, a);
            }
        }
    }
}
