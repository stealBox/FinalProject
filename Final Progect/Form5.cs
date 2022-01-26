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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Form14 form14 = new Form14();

            form14.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form2 form2 = new Form2();

            form2.Show();
        }
    }
}
