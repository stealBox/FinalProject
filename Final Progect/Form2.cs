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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6 form6 = new Form6();

            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 form4 = new Form4();

            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 form5 = new Form5();

            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
