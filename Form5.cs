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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("m1.jpg");

            Bitmap bmp = new Bitmap(361, 512);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(pictureBox1.Image, new Point[] { new Point(0, 0), new Point(361, 0), new Point(0, 512) });


            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("m2.jpg");

            Bitmap bmp = new Bitmap(300, 414);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(pictureBox1.Image, new Point[] { new Point(0, 0), new Point(300, 0), new Point(0, 414) });


            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("m3.png");

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("m4.jpg");

            Bitmap bmp = new Bitmap(250, 263);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(pictureBox1.Image, new Point[] { new Point(0, 0), new Point(250, 0), new Point(0, 263) });


            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frmChild = new Form4();
            frmChild.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frmChild = new Form1();
            frmChild.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NT 30.00","需要購買");
        }
        private void waterbtnclick(object sender, EventArgs e)
        {

            waterform frmChild = new waterform();
            frmChild.Show();
            this.Hide();
                 }

        private void button4_Click(object sender, EventArgs e)
        {
            outer_space_form frmChild = new outer_space_form();
            frmChild.Show();
            this.Hide();
        }
    }
}
