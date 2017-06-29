using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace flappy_ball
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text = " 1\n 2\n 3\n 4\n 5\n";

            StreamReader sr = new StreamReader("g_rank_id.txt");
            int i;
            for (i = 0; i < 5; i++)
            {
                label5.Text += sr.ReadLine();
                label5.Text += "\n";
            }
            sr.Close();

            StreamReader sr2 = new StreamReader("g_rank_score.txt");
            for (i = 0; i < 5; i++)
            {
                label6.Text += sr2.ReadLine();
                label6.Text += "\n";
            }
            sr2.Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frmChild = new Form1();
            frmChild.Show();

            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frmChild = new Form4();
            frmChild.Show();

            this.Hide(); 
        }
    }
}
