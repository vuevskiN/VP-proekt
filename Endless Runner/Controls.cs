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
    public partial class Controls : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        public Controls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sp.Stop();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            sp.Stop();
            Game game = new Game();
            game.ShowDialog();
            this.Close();
        }

        private void Controls_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = "velkoz.wav";
            sp.Load();
            sp.Play();
        }
    }
}
