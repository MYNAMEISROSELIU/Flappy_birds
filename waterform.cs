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
using System.Media;

// pictureBox7.Controls.Add(pictureBox8);
namespace flappy_ball
{
    public partial class waterform : Form
    {
        public waterform()
        {
            InitializeComponent();


        }

        int counter = 0;
        int tmp1, tmp2;



        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            pictureBox1.Image = Image.FromFile( "bird.bmp");
            timer1.Interval = 10;
            timer1.Enabled = false;
            timer2.Interval = 1000;
            timer2.Enabled = false;

            pictureBox9.Image = new Bitmap("1.png");
            Bitmap bmp = new Bitmap(50, 50);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(pictureBox9.Image, new Point[] { new Point(0, 0), new Point(50, 0), new Point(0, 50) });
            Random rnd = new Random();
            int y = rnd.Next(400,590);
            pictureBox9.Top = y;

            pictureBox9.Image = bmp;
            pictureBox9.Refresh();


            int x = rnd.Next(1,6);

            switch (x)
            {
                case 1: pictureBox7.Image = new Bitmap("b5.bmp");
                    pictureBox8.Top = 500;
                    break;
                case 2: pictureBox7.Image = new Bitmap("b2.bmp");
                    pictureBox8.Top = 500;
                    break;
                case 3: pictureBox7.Image = new Bitmap("b4.bmp");
                    pictureBox8.Top = 500;
                    break;
                case 4: pictureBox7.Image = new Bitmap("b1.bmp");
                    pictureBox8.Top = 500;
                    break;
                case 5: pictureBox7.Image = new Bitmap("b3.bmp");
                    pictureBox8.Top = 500;
                    break;
            }
            tmp1 = x;

            x = rnd.Next(1, 6);

            switch (x)
            {
                case 1: pictureBox6.Image = new Bitmap("b5.bmp");
                    pictureBox8.Top = 500;
                    break;
                case 2: pictureBox6.Image = new Bitmap("b2.bmp");
                    pictureBox8.Top = 500;
                    break;
                case 3: pictureBox6.Image = new Bitmap("b4.bmp");
                    pictureBox8.Top = 500;
                    break;
                case 4: pictureBox6.Image = new Bitmap("b1.bmp");
                    pictureBox8.Top = 500;
                    break;
                case 5: pictureBox6.Image = new Bitmap("b3.bmp");
                    pictureBox8.Top = 500;
                    break;
            }
            tmp2 = x;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = "恭喜你在水中撐了"+Convert.ToString(counter)+"秒";
            pictureBox8.Top -= 3;

            pictureBox1.Top -= 1 ;

            pictureBox7.Left -= 3;
            pictureBox6.Left -= 3;
            pictureBox9.Left -= 3;


            if (pictureBox1.Top <0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
               waterinput frmChild = new waterinput(counter.ToString());
                frmChild.Show();
                this.Hide();
                this.axWindowsMediaPlayer1.Ctlcontrols.stop();


            }
            if (pictureBox1.Top < -50)
            {
                pictureBox1.Top = -50;
            }
            if (pictureBox1.Bottom > this.Height)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                waterinput frmChild = new waterinput(counter.ToString());
                frmChild.Show();
                this.Hide();
                this.axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
           
            switch (tmp1) { 
                case 1: if ((pictureBox1.Top < 100 || pictureBox1.Top > 200) && (pictureBox7.Left > 350 && pictureBox7.Left < 420))
                {
                    Console.Beep(1000, 100);
                    if (progressBar1.Value > 0)
                    {
                        progressBar1.Value--;
                    }

                }
                    break;
                case 2: if ((pictureBox1.Top < 300 || pictureBox1.Top > 350) && (pictureBox7.Left > 350 && pictureBox7.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value--;
                        }

                    }
                    break;
                case 3: if ((pictureBox1.Top < 400 || pictureBox1.Top > 500) && (pictureBox7.Left > 350 && pictureBox7.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value--;
                        }

                    }
                    break;
                case 4: if ((pictureBox1.Top < 50 || pictureBox1.Top > 150) && (pictureBox7.Left > 350 && pictureBox7.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value--;
                        }


                    }
                    break;
                case 5: if ((pictureBox1.Top < 250 || pictureBox1.Top > 350) && (pictureBox7.Left > 350 && pictureBox7.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value--;
                        }

                    }
                    break;
        }

            switch (tmp2)
            {
                case 1: if ((pictureBox1.Top < 100 || pictureBox1.Top > 200) && (pictureBox6.Left > 350 && pictureBox6.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value--;
                        }
                    }
                    break;
                case 2: if ((pictureBox1.Top < 300 || pictureBox1.Top > 350) && (pictureBox6.Left > 350 && pictureBox6.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value >= 0)
                        {
                            progressBar1.Value--;
                        }
                    }
                    break;
                case 3: if ((pictureBox1.Top < 400 || pictureBox1.Top > 500) && (pictureBox6.Left > 350 && pictureBox6.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value--;
                        }
                    }
                    break;
                case 4: if ((pictureBox1.Top < 50 || pictureBox1.Top > 150) && (pictureBox6.Left > 350 && pictureBox6.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value--;
                        }
                    }
                    break;
                case 5: if ((pictureBox1.Top < 250 || pictureBox1.Top > 350) && (pictureBox6.Left > 350 && pictureBox6.Left < 420))
                    {
                        Console.Beep(1000, 100);
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value--;
                        }
                    }
                    break;
            }




            if (pictureBox7.Left < -100) {

                pictureBox7.Left = 1300;
                Random rnd = new Random();
                int x = rnd.Next(1, 6);

                switch (x)
                {
                    case 1: pictureBox7.Image = new Bitmap("b5.bmp");
                        pictureBox8.Top = 500;
                        break;
                    case 2: pictureBox7.Image = new Bitmap("b2.bmp");
                        pictureBox8.Top = 500;
                        break;
                    case 3: pictureBox7.Image = new Bitmap("b4.bmp");
                        pictureBox8.Top = 500;
                        break;
                    case 4: pictureBox7.Image = new Bitmap("b1.bmp");
                        pictureBox8.Top = 500;
                        break;
                    case 5: pictureBox7.Image = new Bitmap("b3.bmp");
                        pictureBox8.Top = 500;
                        break;
                }
                tmp1 = x;
            }

            if (pictureBox6.Left < -100)
            {

                pictureBox6.Left = 1300;
                Random rnd = new Random();
                int x = rnd.Next(1, 6);

                switch (x)
                {
                    case 1: pictureBox6.Image = new Bitmap("b5.bmp");
                        pictureBox8.Top = 500;
                        break;
                    case 2: pictureBox6.Image = new Bitmap("b2.bmp");
                        pictureBox8.Top = 500;
                        break;
                    case 3: pictureBox6.Image = new Bitmap("b4.bmp");
                        pictureBox8.Top = 500;
                        break;
                    case 4: pictureBox6.Image = new Bitmap("b1.bmp");
                        pictureBox8.Top = 500;
                        break;
                    case 5: pictureBox6.Image = new Bitmap("b3.bmp");
                        pictureBox8.Top = 500;
                        break;
                }
                tmp2 = x;
            }

            if (progressBar1.Value == 0)
            {

                timer1.Enabled = false;
                timer2.Enabled = false;
                waterinput frmChild = new waterinput(counter.ToString());
                frmChild.Show();
                this.Hide();
                this.axWindowsMediaPlayer1.Ctlcontrols.stop();
            }

            if ((pictureBox1.Top > pictureBox9.Top && pictureBox1.Top < pictureBox9.Bottom) && (pictureBox9.Left > 350 && pictureBox9.Left < 410))
            {
                if (progressBar1.Value <= 80)
                {
                    progressBar1.Value += 20;
                }
                else {
                    progressBar1.Value = 100;
                }


                        pictureBox9.Left = 1400;

                        Random rnd = new Random();
                        int y = rnd.Next(0, 590);
                        pictureBox9.Top = y;


            }

            if (pictureBox9.Left < -100)
            {

                    pictureBox9.Left = 1400;


                Random rnd = new Random();
                int y = rnd.Next(0,590);
                pictureBox9.Top = y;
            }

        }

       

      




        //Press 空白件以往上    Enter以加速向下
        private void water_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = Convert.ToInt32(e.KeyChar);
            if (asc == 32)
            {
                pictureBox1.Image = Image.FromFile("birddown.png");
                for (int i = 0; i < 20; i++) pictureBox1.Top++;


            }


            if (asc == 13)
            {
                pictureBox1.Top -= 50;
                pictureBox1.Image = Image.FromFile("birdup.png");

            }

        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox1.Image = Image.FromFile("bird.bmp");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            axWindowsMediaPlayer1.URL = "WATER.mp3";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;
            //label4.Text = counter.ToString();
            label3.Text = counter.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            DialogResult result;
            result = MessageBox.Show("是否關閉?\n按否回到主選單", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Form4 frmChild = new Form4();
                frmChild.Show();
                this.Hide();
                this.axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            this.axWindowsMediaPlayer1.Ctlcontrols.pause();
        }




       
    }
}