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
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        
        public Form1()
        {
            InitializeComponent();
            
            
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            DialogResult = MessageBox.Show(" ", "Did you look at the controls?", MessageBoxButtons.YesNo);

            if(DialogResult == DialogResult.Yes)
            {
                sp.Stop();
                this.Hide();
                Game game = new Game();
                game.ShowDialog();
                

            }

            else if(DialogResult == DialogResult.No)
            {
                sp.Stop();
                this.Hide();
                Controls controls = new Controls();
                controls.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sp.Stop();
            this.Hide();
            Controls control = new Controls();
            control.ShowDialog();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            sp.SoundLocation = "sound.wav";
            sp.Load();
            sp.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }
    }
}
