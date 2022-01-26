using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Progect
{
    public partial class Form10 : Form
    {
        const int KEY_END = 27;
        const int KEY_LEFT = 65;
        const int KEY_RIGHT = 68;
        const int SCORE_BOARD = 83;
        const int KEY_SHOOT = 32;

        const int MOVE_UP = 1;
        const int MOVE_DOWN = 2;
        const int MOVE_LEFT = 3;
        const int MOVE_RIGHT = 4;
        const int STOPPED = 0;

        const int MOVE_AMOUNT = 5;

        const int RMOVE_AMOUNT = 5;

        int shutleDirection = STOPPED;
        int rockDirection = STOPPED;
        int buletDirection = STOPPED;

        int shutleTop = 0;
        int shutleBottom = 0;
        int shutleLeft = 0;
        int shutleRight = 0;
        int shutleWidth = 0;
        int shutleHeight = 0;

        int rockTop = 0;
        int rockBottom = 0;
        int rockLeft = 0;
        int rockRight = 0;
        int rockWidth = 0;
        int rockHeight = 0;

        int buletTop = 0;
        int buletBottom = 0;
        int buletLeft = 0;
        int buletRight = 0;
        int buletWidth = 0;
        int buletHeight = 0;

        int lives = 1;

        int width = 0;
        int hight = 0;
        const int SPACER = 5;

        Random random = new Random();
        public Form10()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            shutleTop = picShutle.Top;
            shutleLeft = picShutle.Left;
            shutleWidth = picShutle.Width;
            shutleHeight = picShutle.Height;

            shutleBottom = shutleTop + shutleHeight;
            shutleRight = shutleLeft + shutleWidth;

            if (shutleDirection == MOVE_LEFT) shutleLeft = shutleLeft - MOVE_AMOUNT;
            else if (shutleDirection == MOVE_RIGHT) shutleLeft = shutleLeft + MOVE_AMOUNT;

            shutleBottom = shutleTop + shutleHeight;
            shutleRight = shutleLeft + shutleWidth;

            picShutle.Left = shutleLeft;
            picShutle.Top = shutleTop;
        }

        private void Form10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == KEY_END) Application.Exit();
            else if (e.KeyValue == KEY_LEFT)
            {
                tmShut.Enabled = true;
                shutleDirection = MOVE_LEFT;

            }
            else if (e.KeyValue == KEY_RIGHT)
            {
                tmShut.Enabled = true;
                shutleDirection = MOVE_RIGHT;
            }
            if (e.KeyValue == SCORE_BOARD) lblLife.Visible = true;
            if (e.KeyValue == KEY_SHOOT)
            {
                tmShoot.Enabled = true;
            }
        }

        private void Form10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == KEY_LEFT) tmShut.Enabled = false;
            else if (e.KeyValue == KEY_RIGHT) tmShut.Enabled = false;
            lblLife.Visible = false;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            width = this.Width;
            hight = this.Height;

        }

        private void tmRock_Tick(object sender, EventArgs e)
        {
            rockTop = picNrock1.Top;
            rockLeft = picNrock1.Left;
            rockWidth = picNrock1.Width;
            rockHeight = picNrock1.Height;

            rockBottom = rockTop + rockHeight;
            rockRight = rockLeft + rockWidth;

            shutleTop = picShutle.Top;
            shutleLeft = picShutle.Left;
            shutleWidth = picShutle.Width;
            shutleHeight = picShutle.Height;

            shutleBottom = shutleTop + shutleHeight;
            shutleRight = shutleLeft + shutleWidth;

            rockDirection = MOVE_DOWN;

            if (rockDirection == MOVE_DOWN) rockTop = rockTop + RMOVE_AMOUNT;

            rockBottom = rockTop + rockHeight;
            rockRight = rockLeft + rockWidth;

            picNrock1.Left = rockLeft;
            picNrock1.Top = rockTop;
                                                                            //rock goes off screen unless tuched first
            if (picNrock1.Bottom == 750)
            {
                lblLife.Text = "lives: ";

                lives = lives - 1;

                lblLife.Text = lblLife.Text + lives;

                int rightMost = width - picNrock1.Width - SPACER;
                int leftMost = 0;

                picNrock1.Left = random.Next(leftMost, rightMost);

                picNrock1.Top = 0 + SPACER;
            }

            if (((shutleLeft >= rockLeft && shutleLeft <= rockRight) ||
                 (shutleRight >= rockLeft && shutleRight <= rockRight)) &&
                ((shutleTop >= rockTop && shutleTop <= rockBottom) ||
                 (shutleBottom >= rockTop && shutleBottom <= rockBottom)))
            {
                lblLife.Text = "lives: ";

                lives = lives - 1;

                lblLife.Text = lblLife.Text + lives;


                int rightMost = width - picNrock1.Width - SPACER;
                int leftMost = 0;

                picNrock1.Left = random.Next(leftMost, rightMost);



                picNrock1.Top = 0 + SPACER;
            }
            else if (((rockLeft >= shutleLeft && rockLeft <= shutleRight) ||
                      (rockRight >= shutleLeft && rockRight <= shutleRight)) &&
                     ((rockTop >= shutleTop && rockTop <= shutleBottom) ||
                      (rockBottom >= shutleTop && rockBottom <= shutleBottom)))
            {
                lblLife.Text = "lives: ";

                lives = lives - 1;

                lblLife.Text = lblLife.Text + lives;

                int rightMost = width - picNrock1.Width - SPACER;
                int leftMost = 0;

                picNrock1.Left = random.Next(leftMost, rightMost);

                picNrock1.Top = 0 + SPACER;
            }

            if (lives == 0)
            {
                this.Close();

                Form7 form7 = new Form7();

                form7.Show();
            }
        }

        private void tmShoot_Tick(object sender, EventArgs e)
        {
            picBulet.Visible = true;
            buletTop = picBulet.Top;
            buletLeft = picBulet.Left;
            buletWidth = picBulet.Width;
            buletHeight = picBulet.Height;

            buletBottom = buletTop + buletHeight;
            buletRight = buletLeft + buletWidth;

            buletDirection = MOVE_UP;

            if (buletDirection == MOVE_UP) buletTop = buletTop - MOVE_AMOUNT;

            buletBottom = buletTop + buletHeight;
            buletRight = buletLeft + buletWidth;

            picBulet.Left = buletLeft;
            picBulet.Top = buletTop;

            if (picBulet.Top == 0)
            {
                picBulet.Visible = false;
                picBulet.Top = picShutle.Top;
                tmShoot.Enabled = false;
            }

            if (((buletLeft >= rockLeft && buletLeft <= rockRight) ||
                 (buletRight >= rockLeft && buletRight <= rockRight)) &&            //needs to be finnished
                ((buletTop >= rockTop && buletTop <= rockBottom) ||
                 (buletBottom >= rockTop && buletBottom <= rockBottom)))
            {
                int rightMost = width - picNrock1.Width - SPACER;
                int leftMost = 0;

                picNrock1.Left = random.Next(leftMost, rightMost);

                picNrock1.Top = 0 + SPACER;
            }
            else if (((rockLeft >= buletLeft && rockLeft <= buletRight) ||
                      (rockRight >= buletLeft && rockRight <= buletRight)) &&
                     ((rockTop >= buletTop && rockTop <= buletBottom) ||
                      (rockBottom >= buletTop && rockBottom <= buletBottom)))
            {

                int rightMost = width - picNrock1.Width - SPACER;
                int leftMost = 0;

                picNrock1.Left = random.Next(leftMost, rightMost);

                picNrock1.Top = 0 + SPACER;
            }
        }
    }
}

