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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form2 form2 = new Form2();

            form2.Show();
        }

        private void tmCon1_Tick(object sender, EventArgs e)
        {
            picCon1.Visible = true;
            picCon2.Visible = true;
            picCon3.Visible = true;
            picCon4.Visible = true;
            picCon5.Visible = true;
            picCon6.Visible = true;
            picCon7.Visible = true;

            picCon8.Visible = false;
            picCon9.Visible = false;
            picCon10.Visible = false;
            picCon11.Visible = false;
            picCon12.Visible = false;
            picCon13.Visible = false;
            picCon14.Visible = false;

            tmCon1.Enabled = false;
            tmCon2.Enabled = true;
        }

        private void tmCon2_Tick(object sender, EventArgs e)
        {
            picCon8.Visible = true;
            picCon9.Visible = true;
            picCon10.Visible = true;
            picCon11.Visible = true;
            picCon12.Visible = true;
            picCon13.Visible = true;
            picCon14.Visible = true;

            picCon1.Visible = false;
            picCon2.Visible = false;
            picCon3.Visible = false;
            picCon4.Visible = false;
            picCon5.Visible = false;
            picCon6.Visible = false;
            picCon7.Visible = false;

            tmCon2.Enabled = false;
            tmCon1.Enabled = true;
        }

        private void tmT_Tick(object sender, EventArgs e)
        {
            lblT.Visible = true;

            tmT.Enabled = false;
        }

        private void tmH_Tick(object sender, EventArgs e)
        {
            lblH.Visible = true;

            tmH.Enabled = false;
        }

        private void tmA_Tick(object sender, EventArgs e)
        {
            lblA.Visible = true;

            tmA.Enabled = false;
        }

        private void tmN_Tick(object sender, EventArgs e)
        {
            lblN.Visible = true;

            tmN.Enabled = false;
        }

        private void tmK_Tick(object sender, EventArgs e)
        {
            lblK.Visible = true;

            tmK.Enabled = false;
        }

        private void tmS_Tick(object sender, EventArgs e)
        {
            lblS.Visible = true;

            tmS.Enabled = false;
        }

        private void tmF_Tick(object sender, EventArgs e)
        {
            lblF.Visible = true;

            tmF.Enabled = false;
        }

        private void tmO_Tick(object sender, EventArgs e)
        {
            lblO.Visible = true;

            tmO.Enabled = false;
        }

        private void tmR_Tick(object sender, EventArgs e)
        {
            lblR.Visible = true;

            tmR.Enabled = false;
        }

        private void tmP_Tick(object sender, EventArgs e)
        {
            lblP.Visible = true;

            tmP.Enabled = false;
        }

        private void tmL_Tick(object sender, EventArgs e)
        {
            lblL.Visible = true;

            tmL.Enabled = false;
        }

        private void tmA2_Tick(object sender, EventArgs e)
        {
            lblA2.Visible = true;

            tmA2.Enabled = false;
        }

        private void tmI_Tick(object sender, EventArgs e)
        {
            lblI.Visible = true;

            tmI.Enabled = false;
        }

        private void tmN2_Tick(object sender, EventArgs e)
        {
            lblN2.Visible = true;

            tmN2.Enabled = false;
        }

        private void tmY_Tick(object sender, EventArgs e)
        {
            lblY.Visible = true;

            tmY.Enabled = false;
        }

        private void tmG_Tick(object sender, EventArgs e)
        {
            lblG.Visible = true;

            tmG.Enabled = false;
        }

        private void tmReturn_Tick(object sender, EventArgs e)
        {
            btnReturn.Visible = true;

            tmReturn.Enabled = false;
        }
    }
}
