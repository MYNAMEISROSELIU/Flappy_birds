using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_ball
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frmChild = new Form3();
            frmChild.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frmChild = new Form4();
            frmChild.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚未購買!!","Error");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            waterrank frmChild = new waterrank();
            frmChild.Show();
            this.Hide();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            outer_space_rank frmChild = new outer_space_rank();
            frmChild.Show();
            this.Hide();
        }
    }
}
