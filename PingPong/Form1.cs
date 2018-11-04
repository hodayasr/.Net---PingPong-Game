using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {

        public int speed_left = 3; // speed of the ball
        public int speed_top = 3;
        public int point = 0;  // Scored points

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
           Cursor.Hide();  // Hide the cursor

            this.FormBorderStyle = FormBorderStyle.None;  // remove any border
            this.TopMost = true;                         // bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  // full screen


            exitLable.Top = playground.Left - (playground.Left / 100);    // set position of the exit lable
            racket.Top = playground.Bottom - (playground.Bottom / 10);   // set position of the racket

            gameover.Left = (playground.Width / 2) - (gameover.Width / 2);
            gameover.Top = (playground.Height / 2) - (gameover.Height / 2);
            gameover.Visible = false;
            
        }

      

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }  // escape to exit

            if(e.KeyCode==Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                point = 0;
                points.Text = "0";
                timer1.Enabled = true;
                gameover.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Set the center of the racket to position of the cursor
            racket.Left = Cursor.Position.X - (racket.Width / 2);


            //Move the ball
            ball.Left += speed_left;
            ball.Top += speed_top;
            

            //Racket collision
            if(ball.Bottom>=racket.Top&&ball.Bottom<=racket.Bottom&&ball.Left>=racket.Left&&ball.Right<=racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;  // Change direction
                point += 1;
                points.Text = point.ToString();

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150,255));
            }

            if (ball.Left <= playground.Left) speed_left = -speed_left;
            if (ball.Right >= playground.Right) speed_left = -speed_left;
            if (ball.Top <= playground.Top) speed_top = -speed_top;
            if (ball.Bottom >= playground.Bottom)
            {
                point = 0;
                //gameOver.d = true;
                timer1.Enabled = false;
                gameover.Visible = true;
            }
        }


    }
}
