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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public Form2(string DataFromForm1)
        {
            InitializeComponent();
            label3.Text = DataFromForm1;
            textBox1.Text = "Unknown";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("g_rank_id.txt");
            string[] id = new string[6];
            int i;
            for (i = 0; i < 5; i++) {
            id[i] = sr.ReadLine();
            }
            sr.Close();

            StreamReader sr2 = new StreamReader("g_rank_score.txt");
            int[] score = new int[6];
            for (i = 0; i < 5; i++)
            {
                score[i] = int.Parse(sr2.ReadLine());
            }
            sr2.Close();

            id[5] = textBox1.Text;
            score[5] = int.Parse(label3.Text);

            Array.Sort(score,id);

            FileInfo finfo = new FileInfo("g_rank_id.txt");
            StreamWriter sw = finfo.CreateText();

            for (i = 5; i > 0; i--)
            {
                sw.WriteLine(id[i]);

            }
            sw.Close();

            FileInfo finfo2 = new FileInfo("g_rank_score.txt");
            StreamWriter sw2 = finfo2.CreateText();

            for (i = 5; i > 0; i--)
            {
                sw2.WriteLine(score[i]);

            }
            sw2.Close();

            Form3 frmChild = new Form3();
            frmChild.Show();

            this.Hide(); 

        }
     }

}
