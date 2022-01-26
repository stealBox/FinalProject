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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Form2 form2 = new Form2();

            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            gameEasy form3 = new gameEasy();

            form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

            Form8 form8 = new Form8();

            form8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

            Form9 form9 = new Form9();

            form9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            Form10 form10 = new Form10();

            form10.Show();
        }
    }
}
