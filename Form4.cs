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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int c = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" space:向上\n enter:加速向下\n碰觸到上或下邊界則Game Over!\n吃愛心或能量方塊可補血","Instruction");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frmChild = new Form5();
            frmChild.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frmChild = new Form6();
            frmChild.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            c++;

            if (c % 2 == 1)
            {
                label1.ForeColor = Color.Yellow;
            }
            else {
                label1.ForeColor = Color.White;
            }
        }
    }
}
