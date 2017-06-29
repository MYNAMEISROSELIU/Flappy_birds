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
    public partial class waterrank : Form
    {
        public waterrank()
        {
            InitializeComponent();
        }

        private void waterrank_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "";
            label2.Text = "1.\n2.\n3.\n4.\n5.\n";
            StreamReader sr = new StreamReader("g_rank_id.txt");
            int i;
            for (i = 0; i < 5; i++)
            {
                label1.Text += sr.ReadLine();
                label1.Text += "\n";
            }
            sr.Close();

            StreamReader sr2 = new StreamReader("g_rank_score.txt");
            for (i = 0; i < 5; i++)
            {
                label3.Text += sr2.ReadLine();
                 label3.Text += "\n";
            }
            sr2.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            waterform frmChild = new waterform();
            frmChild.Show();

            this.Hide(); 
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frmChild = new Form4();
            frmChild.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

       
    }
}
