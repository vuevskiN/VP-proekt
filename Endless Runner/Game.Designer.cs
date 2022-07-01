
namespace Endless_Runner
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.e1 = new System.Windows.Forms.PictureBox();
            this.e2 = new System.Windows.Forms.PictureBox();
            this.e3 = new System.Windows.Forms.PictureBox();
            this.healthtimer = new System.Windows.Forms.Timer(this.components);
            this.life = new System.Windows.Forms.PictureBox();
            this.prbHealth = new System.Windows.Forms.ProgressBar();
            this.bosstime = new System.Windows.Forms.ProgressBar();
            this.bosstimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Timer(this.components);
            this.e5 = new System.Windows.Forms.PictureBox();
            this.e4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Endless_Runner.Properties.Resources.output_onlinegiftools__1_;
            this.player.Location = new System.Drawing.Point(268, 230);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(63, 75);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // e1
            // 
            this.e1.BackColor = System.Drawing.Color.Transparent;
            this.e1.Image = global::Endless_Runner.Properties.Resources.output_onlinegiftools__1_1;
            this.e1.Location = new System.Drawing.Point(812, 465);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(122, 35);
            this.e1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e1.TabIndex = 2;
            this.e1.TabStop = false;
            this.e1.Tag = "enemy";
            // 
            // e2
            // 
            this.e2.BackColor = System.Drawing.Color.Transparent;
            this.e2.Image = global::Endless_Runner.Properties.Resources.walker_done;
            this.e2.Location = new System.Drawing.Point(861, 288);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(73, 63);
            this.e2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e2.TabIndex = 3;
            this.e2.TabStop = false;
            this.e2.Tag = "enemy";
            // 
            // e3
            // 
            this.e3.BackColor = System.Drawing.Color.Transparent;
            this.e3.Image = global::Endless_Runner.Properties.Resources.bat_done;
            this.e3.Location = new System.Drawing.Point(835, 101);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(85, 63);
            this.e3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e3.TabIndex = 4;
            this.e3.TabStop = false;
            this.e3.Tag = "enemy";
            // 
            // healthtimer
            // 
            this.healthtimer.Enabled = true;
            this.healthtimer.Interval = 20;
            this.healthtimer.Tick += new System.EventHandler(this.healthtimer_Tick);
            // 
            // life
            // 
            this.life.BackColor = System.Drawing.Color.Transparent;
            this.life.Image = global::Endless_Runner.Properties.Resources.heart;
            this.life.Location = new System.Drawing.Point(12, 48);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(33, 28);
            this.life.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life.TabIndex = 5;
            this.life.TabStop = false;
            this.life.Tag = "life";
            // 
            // prbHealth
            // 
            this.prbHealth.ForeColor = System.Drawing.Color.Chartreuse;
            this.prbHealth.Location = new System.Drawing.Point(370, 59);
            this.prbHealth.Maximum = 3;
            this.prbHealth.Name = "prbHealth";
            this.prbHealth.Size = new System.Drawing.Size(125, 29);
            this.prbHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbHealth.TabIndex = 6;
            // 
            // bosstime
            // 
            this.bosstime.BackColor = System.Drawing.Color.SeaShell;
            this.bosstime.ForeColor = System.Drawing.Color.Orchid;
            this.bosstime.Location = new System.Drawing.Point(-7, -1);
            this.bosstime.Maximum = 60;
            this.bosstime.Name = "bosstime";
            this.bosstime.Size = new System.Drawing.Size(916, 29);
            this.bosstime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bosstime.TabIndex = 7;
            this.bosstime.Click += new System.EventHandler(this.bosstime_Click);
            // 
            // bosstimer
            // 
            this.bosstimer.Enabled = true;
            this.bosstimer.Interval = 1200;
            this.bosstimer.Tick += new System.EventHandler(this.bosstimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(347, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // final
            // 
            this.final.Interval = 10;
            this.final.Tick += new System.EventHandler(this.final_Tick);
            // 
            // e5
            // 
            this.e5.BackColor = System.Drawing.Color.Transparent;
            this.e5.Image = global::Endless_Runner.Properties.Resources.carrier_done;
            this.e5.Location = new System.Drawing.Point(-32, 373);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(125, 149);
            this.e5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e5.TabIndex = 9;
            this.e5.TabStop = false;
            this.e5.Tag = "new";
            this.e5.Visible = false;
            // 
            // e4
            // 
            this.e4.BackColor = System.Drawing.Color.Transparent;
            this.e4.Image = global::Endless_Runner.Properties.Resources.blob_done;
            this.e4.Location = new System.Drawing.Point(12, 127);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(66, 80);
            this.e4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e4.TabIndex = 10;
            this.e4.TabStop = false;
            this.e4.Tag = "new";
            this.e4.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::Endless_Runner.Properties.Resources.gamebackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 512);
            this.Controls.Add(this.e4);
            this.Controls.Add(this.e5);
            this.Controls.Add(this.bosstime);
            this.Controls.Add(this.prbHealth);
            this.Controls.Add(this.life);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox e1;
        private System.Windows.Forms.PictureBox e2;
        private System.Windows.Forms.PictureBox e3;
        private System.Windows.Forms.Timer healthtimer;
        private System.Windows.Forms.PictureBox life;
        private System.Windows.Forms.ProgressBar prbHealth;
        private System.Windows.Forms.ProgressBar bosstime;
        private System.Windows.Forms.Timer bosstimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer final;
        private System.Windows.Forms.PictureBox e5;
        private System.Windows.Forms.PictureBox e4;
        private System.Windows.Forms.Button button1;
    }
}