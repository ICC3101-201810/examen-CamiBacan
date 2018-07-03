using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Partida : Form
    {
        bool goup;
        bool godown;
        bool goleft;
        bool goright;

        int speed = 5;

        int ghost1x = 8;
        int ghost1y = 8;
        int ghost2x = 8;
        int ghost2y = 8;

        int score = 0;

        public Partida(string name)
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Text = name;
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score;
            
            if (goleft)
            {
                pacman.Left -= speed;
            }

            if (goright)
            {
                pacman.Left += speed;
            }

            if (goup)
            {
                pacman.Top -= speed;
            }

            if (godown)
            {
                pacman.Top += speed;
            }

            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)(x.Tag) == "ghost")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        pacman.Left = 0;
                        pacman.Top = 0;
                        label2.Text = "GAME OVER";
                        label2.Visible = true;
                        timer1.Stop();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "fruit")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        Controls.Remove(x);
                        if (x.Name == "cherry")
                        {
                            score += 10;
                        }
                        else if (x.Name == "uva")
                        {
                            score += 15;
                        }
                    }
                }
            }

            pinkGhost.Left += ghost1x;
            pinkGhost.Top += ghost1y;

            redGhost.Left += ghost2x;
            redGhost.Top += ghost2y;

            if ( pinkGhost.Left < 1 || pinkGhost.Left + pinkGhost.Width >
                ClientSize.Width - 2)
            {
                ghost1x = -ghost1x;
            }
            if (pinkGhost.Top <1 || pinkGhost.Top +pinkGhost.Height >
                ClientSize.Height - 2)
            {
                ghost1y = -ghost1y;
            }

            if (redGhost.Left < 1 || redGhost.Left + redGhost.Width >
                ClientSize.Width - 2)
            {
                ghost2x = -ghost2x;
            }
            if (redGhost.Top < 1 || redGhost.Top + redGhost.Height >
                ClientSize.Height - 2)
            {
                ghost2y = -ghost2y;
            }
        }

        private void label_timer_Click(object sender, EventArgs e)
        {

        }
    }
}
