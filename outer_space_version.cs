using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace flappy_ball
{
    public partial class outer_space_form : Form
    {
        public outer_space_form()
        {
            InitializeComponent();
        }
//        int x = 1100;
        int counter = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
           
            //disable the position show label
            label1.Visible = false;


            //init timer label and obstacles
            label3.Text ="0";
            pictureBox6.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox7.Visible = false;



            pictureBox1.Image = Image.FromFile("pig.png");
            timer1.Interval = 10;
            timer1.Enabled = false;
            timer2.Interval = 1000;
            timer2.Enabled = false;
//            pictureBox2.Image = new Bitmap("ttt.bmp");
//            pictureBox2.Padding = new Padding(x, 0, 0, 0);
//            pictureBox2.Refresh();
            pictureBox7.Image = new Bitmap("red_giant.png");
            //pictureBox7.Visible = false;
            //adjust picturebox 7
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Width = 200;
            pictureBox6.Height = 100;
            pictureBox6.Top = 200;
            pictureBox6.Left = 1014;

            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.BackColor = Color.Black;
            pictureBox7.Width = 197;
            pictureBox7.Height = 180;
            pictureBox7.Top = 131;
            pictureBox7.Left = 889;


           //label1.Text = " pictureBox9.Bottom"+ pictureBox9.Bottom+"\n"+"pictureBox1.Height :" + pictureBox1.Height + "\n" + "pictureBox1.Bottom :" + pictureBox1.Bottom + "\n" + "pictureBox1.Top :" + pictureBox1.Top + "\n" + "pictureBox1.Right:" + pictureBox1.Right + "\n" + "pictureBox1.Left :" + pictureBox1.Left + "\n" + "pictureBox1.Height :" + pictureBox1.Height + "\n" + "pictureBox1.X :" + pictureBox1.Location.X + "\n" + "pictureBox1.Y :" + pictureBox1.Location.Y + "\n" + "pictureBox9.Top :" + pictureBox9.Top + "\n" + "pictureBox9.Right:" + pictureBox9.Right + "\n" + "pictureBox9.Left :" + pictureBox9.Left + "\n" + "pictureBox9.X :" + pictureBox9.Location.X + "\n" + "pictureBox9.Y :" + pictureBox9.Location.Y + "\n";



            //



            pictureBox6.Image = new Bitmap("space_ship.jpg");

            //energy block
            pictureBox10.Image = new Bitmap("energy.png");
           Bitmap bmp = new Bitmap(50, 50);
           Graphics gr = Graphics.FromImage(bmp);
           gr.DrawImage(pictureBox10.Image, new Point[] { new Point(0, 0), new Point(50, 0), new Point(0, 50) });
           Random rnd = new Random();
           int y = rnd.Next(0, 590);
           pictureBox10.Top = y;

           pictureBox10.Image = bmp;
           pictureBox10.Refresh();

           
           

        }

        Random rnd=new Random();
        DialogResult game_over;  //Game over handler!


        SoundPlayer player1 = new SoundPlayer();        // 建立播放器物件


        private void Lose()
        { 
            //stop background music
            player1.Stop();
            progressBar1.Value = 0;
            pictureBox10.Visible = false;
            pictureBox7.Visible = false;


            outer_space_input frmChild = new outer_space_input(counter.ToString());
            frmChild.Show();
            this.Hide();
            
            
            
            //game_over = MessageBox.Show("Oh NO!   You lose! \n You survived  " + counter + "  sec this time." + "\n\nTry again?\n", "Game over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
           
            
           /*
            
            if (game_over == DialogResult.Yes)
            {
                pictureBox1.Top = 250;
                pictureBox9.Top =419;
                //pictureBox9.Bottom =538;
                counter = 0;
                label3.Text = counter.ToString();
                pictureBox6.Visible = false;
                pictureBox9.Visible = false;


                

            }
            else
            {
                this.Close();
            }
            */
        }



        int Red_Giant_Up_Down = 5;
        int Bird_Up_Down = 1;
        Random energy_rnd= new Random();
        

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox6.Left % 8 == 0 || pictureBox6.Left % 5 == 0)
                pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;

            if (pictureBox6.Left % 4 == 0 )
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;


            //test pic9

             //label1.Text ="pictureBox1.Width :" + pictureBox1.Width + "\n"+ "pictureBox1.Height :" + pictureBox1.Height + "\n" + "pictureBox1.Bottom :" + pictureBox1.Bottom + "\n" + "pictureBox1.Top :" + pictureBox1.Top + "\n" + "pictureBox1.Right:" + pictureBox1.Right + "\n" + "pictureBox1.Left :" + pictureBox1.Left + "\n" + "pictureBox1.Height :" + pictureBox1.Height + "\n" + "pictureBox1.X :" + pictureBox1.Location.X + "\n" + "pictureBox1.Y :" + pictureBox1.Location.Y + "\n" + "pictureBox9.Top :" + pictureBox6.Top + "\n" + "pictureBox9.Right:" + pictureBox6.Right + "\n" + "pictureBox9.Left :" + pictureBox6.Left + "\n" + "pictureBox9.X :" + pictureBox6.Location.X + "\n" + "pictureBox9.Y :" + pictureBox6.Location.Y + "\n";
            
            /*Game over handler!
            game_over = MessageBox.Show("You lose!\n Try again?\n", "Game over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (game_over == DialogResult.Yes)
                {
                    pictureBox1.Top = 250;

                }
            */

            //energy block
            pictureBox10.Left -= 3;

            if (pictureBox10.Left < -100)
            {
                pictureBox10.Left = 1200;
                pictureBox10.Top = energy_rnd.Next(0, 537);
                pictureBox10.Visible = true;

            }
            if (pictureBox1.Left + pictureBox1.Width == pictureBox10.Left && ((pictureBox1.Top - pictureBox10.Top < pictureBox1.Height || pictureBox1.Top - pictureBox10.Top == pictureBox1.Height) || (pictureBox10.Top - pictureBox1.Top < pictureBox1.Height || pictureBox10.Top - pictureBox1.Top == pictureBox1.Height)))
            {


                Console.Beep(1000, 100);
                //Counter++;
                Increase_Heart();
                pictureBox10.Visible = false;
            }

            pictureBox9.Left -= 2;
            pictureBox9.Top -= 2 ;
            


            pictureBox1.Top += Bird_Up_Down ;
           
            


//            x = x - 3;
            pictureBox7.Left -= 6;
            pictureBox7.Top -= Red_Giant_Up_Down;

            pictureBox6.Left -= 3;

//            pictureBox2.Padding = new Padding(x, 0, 0, 0);
//            pictureBox2.Refresh();

            if (pictureBox1.Top < 0 || pictureBox1.Top+pictureBox1.Height>pictureBox2.Height)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;

                Lose();
            }
            if (pictureBox1.Top < -50)
            {
                pictureBox1.Top = -50;
            }
//test comet
            if (pictureBox7.Top<0 )
            {
                //pictureBox7.Left -= 2;
                Red_Giant_Up_Down = -4;
                //pictureBox7.Top += Up_Down;
                
                
                
                // pictureBox5.Image = null;

                //Console.Beep(1000, 100);
                //MessageBox.Show("You lose!\n", "Game over");

                //timer1.Enabled = false;
                //timer2.Enabled = false;
            }

            //red giant reach window's bottom.
            if (pictureBox7.Top + pictureBox7.Height > pictureBox2.Height)
            {
                pictureBox7.Left = 889;
                pictureBox7.Top = 30 + (rnd.Next(0, 10) * 10);
                Red_Giant_Up_Down = 2;
              
            }

            //gravity
            if (pictureBox7.Left - (pictureBox1.Location.X + pictureBox1.Width) > 0 && pictureBox7.Left - (pictureBox1.Location.X + pictureBox1.Width) < 20)
            {
                Bird_Up_Down = 55;

                pictureBox1.Top += Bird_Up_Down;


                //restore to original mode.
                Bird_Up_Down = 1;

            }
//

            //test pic6
            if (pictureBox1.Left + pictureBox1.Width == pictureBox6.Left && ((pictureBox1.Top - pictureBox6.Top < pictureBox1.Height || pictureBox1.Top - pictureBox6.Top == pictureBox1.Height) || (pictureBox6.Top - pictureBox1.Top < pictureBox1.Height || pictureBox6.Top - pictureBox1.Top == pictureBox1.Height)))
            {
                

                Console.Beep(1000, 100);
                //Counter++;
                Decrease_Heart();
            }



           

            if (pictureBox6.Left < -100)
            {
                pictureBox6.Left = 1200;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;


            }


            //test pic9
            if (pictureBox9.Location.X < pictureBox1.Right && pictureBox9.Location.X > pictureBox1.Location.X && (pictureBox9.Location.Y < pictureBox1.Bottom && pictureBox9.Location.Y > pictureBox1.Location.Y))
            {
               // timer1.Enabled = false;
                //timer2.Enabled = false;
                Console.Beep(1000, 100);
                //Counter++;
                Decrease_Heart();
               
            }

            //restore pic9
           if(pictureBox9.Location.Y<-140)
           {

               pictureBox9.Top = 467;
               pictureBox9.Left = 400 + (rnd.Next(-5, 11)*20); 
           }



            //accelerate.
             if (pictureBox9.Location.X -pictureBox1.Location.X<140 && pictureBox9.Location.Y - pictureBox1.Location.Y<90)
             {
                 pictureBox9.Left-=20;

                 pictureBox9.Top -= 35;

             }

        }
          
      private void Increase_Heart()
        {
            if (progressBar1.Value > 0 && progressBar1.Value<100)
            {
                progressBar1.Value = progressBar1.Value +25;

               

            }
          /*
            if (progressBar1.Value == 100)
            {
                pictureBox1.Image = Image.FromFile("big.png");
                pictureBox1.BackColor = Color.Black;
            }
          */



        }
       

      private void Decrease_Heart()
        {

            if (progressBar1.Value >0)
            {
                progressBar1.Value = progressBar1.Value-25;

                pictureBox1.Image = Image.FromFile("pig.png");

                if (progressBar1.Value < 0 || progressBar1.Value == 0)
                {
                    timer1.Enabled = false;

                    timer2.Enabled = false;
                    Lose();
                }
                   
            }

         
              


         
          


           
        }




        //Press Tab以往上    Enter以加速向下
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = Convert.ToInt32(e.KeyChar);
            if (asc == 32) pictureBox1.Top -= 20;
            if (asc == 13) pictureBox1.Top += 50;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Play background music
           
            player1.SoundLocation = "John Williams - The Imperial March .wav";           // 指定音效所在路徑檔名
            player1.Load();                                 // 載入音效檔資料
            player1.PlayLooping();　　　　　　　　                 // 重複播放


            //restart progressbar
            progressBar1.Value = 100;

            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox7.Visible = true;
            pictureBox10.Visible = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text = counter.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            player1.Stop();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            player1.Stop();

            DialogResult result;
            result = MessageBox.Show("是否關閉?\n按否回到主選單", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //return to menu
                
                Form4 frmChild = new Form4();
                frmChild.Show();
                this.Hide();
               
                 
            }
            
        }

       

        






       
    }
}
