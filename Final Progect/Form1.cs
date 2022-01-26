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
    public partial class WELCOME : Form
    {
        public WELCOME()
        {
            InitializeComponent();
        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            //lblE2 = 577 - 285
            //lblM = 515 - 285
            //lblO = 451 - 285
            //lblC = 387 - 285
            //lblL = 348 - 285
            //lblE1 = 289 - 285
            //lblW = 217 - 285


            this.Hide();

            Form2 form2 = new Form2();

            form2.Show();

            tmNext.Enabled = false;
            
        }

        private void tm2_Tick(object sender, EventArgs e)
        {
            lblW.Visible = true;

            tmW.Enabled = false;
        }

        private void tmL_Tick(object sender, EventArgs e)
        {
            lblL.Visible = true;

            tmL.Enabled = false;
        }

        private void tmE_Tick(object sender, EventArgs e)
        {
            lblE1.Visible = true;

            tmE.Enabled = false;
        }

        private void tmC_Tick(object sender, EventArgs e)
        {
            lblC.Visible = true;

            tmC.Enabled = false;
        }

        private void tmO_Tick(object sender, EventArgs e)
        {
            lblO.Visible = true;

            tmO.Enabled = false;
        }

        private void tmM_Tick(object sender, EventArgs e)
        {
            lblM.Visible = true;

            tmM.Enabled = false;
        }

        private void tmE2_Tick(object sender, EventArgs e)
        {
            lblE2.Visible = true;

            tmE2.Enabled = false;
        }
    }
}
