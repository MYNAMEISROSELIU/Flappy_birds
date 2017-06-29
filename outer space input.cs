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
    public partial class outer_space_input : Form
    {
        public outer_space_input()
        {
            InitializeComponent();
        }


        public outer_space_input(string DataFromwaterform)
        {
            InitializeComponent();
            label4.Text = DataFromwaterform;
            textBox1.Text = "noname";
        }

          private void button1_Click(object sender, EventArgs e)
          {
              StreamReader sr = new StreamReader("outer_space_rank.txt");
              string[] id = new string[6];
              int i;
              for (i = 0; i < 5; i++)
              {
                  id[i] = sr.ReadLine();
              }
              sr.Close();

              StreamReader sr2 = new StreamReader("outer_space_score.txt");
              int[] score = new int[6];
              for (i = 0; i < 5; i++)
              {
                  score[i] = int.Parse(sr2.ReadLine());
              }
              sr2.Close();

              id[5] = textBox1.Text;
              score[5] = int.Parse(label4.Text);

              Array.Sort(score, id);

              FileInfo finfo = new FileInfo("outer_space_rank_id.txt");
              StreamWriter sw = finfo.CreateText();

              for (i = 5; i > 0; i--)
              {
                  sw.WriteLine(id[i]);

              }
              sw.Close();

              FileInfo finfo2 = new FileInfo("outer_space_rank_score.txt");
              StreamWriter sw2 = finfo2.CreateText();

              for (i = 5; i > 0; i--)
              {
                  sw2.WriteLine(score[i]);

              }
              sw2.Close();

              outer_space_rank frmChild = new outer_space_rank();
              frmChild.Show();

              this.Hide(); 

          }

         
    }
}
