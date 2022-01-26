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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void tmG_Tick(object sender, EventArgs e)
        {
            lblG.Visible = true;

            tmG.Enabled = false;
        }

        private void tmA_Tick(object sender, EventArgs e)
        {
            lblA.Visible = true;

            tmA.Enabled = false;
        }

        private void tmM_Tick(object sender, EventArgs e)
        {
            lblM.Visible = true;

            tmM.Enabled = false;
        }

        private void tmE_Tick(object sender, EventArgs e)
        {
            lblE.Visible = true;

            tmE.Enabled = false;
        }

        private void tmO_Tick(object sender, EventArgs e)
        {
            lblO.Visible = true;

            tmO.Enabled = false;
        }

        private void tmV_Tick(object sender, EventArgs e)
        {
            lblV.Visible = true;

            tmV.Enabled = false;
        }

        private void tmE2_Tick(object sender, EventArgs e)
        {
            lblE2.Visible = true;

            tmE2.Enabled = false;
        }

        private void tmR_Tick(object sender, EventArgs e)
        {
            lblR.Visible = true;

            tmR.Enabled = false;
        }

        private void tmRetry_Tick(object sender, EventArgs e)
        {
            btnRetry.Visible = true;

            tmRetry.Enabled = false;
        }

        private void tmExit_Tick(object sender, EventArgs e)
        {
            btnExit.Visible = true;

            tmExit.Enabled = false;
        }

        private void tmBack_Tick(object sender, EventArgs e)
        {
            btnMenu.Visible = true;

            tmBack.Enabled = false;
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.Close();

            Form10 form10 = new Form10();

            form10.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            Form2 form2 = new Form2();

            form2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
