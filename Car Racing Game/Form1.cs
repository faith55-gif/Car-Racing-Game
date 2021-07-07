using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {

      
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int Score;
        int carImage;
        
      

        Random rand = new Random();
        Random carPosition = new Random();
        

        bool goleft, goright;
        public Form1()
        {
            InitializeComponent();
            ResetGame();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void roadTrack1_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
           

            txtScore.Text = "Score: " + Score;
            Score++;

            roadTrack1.Top += roadSpeed; 
            roadTrack2.Top += roadSpeed;


            if (goleft == true && player.Left > 5)
            {
                player.Left -= playerSpeed; 
            }
            if (goright == true && player.Left < 422)
            {
                player.Left += playerSpeed;
            }


            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            if (AI1.Top > 520)
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 520)
            {
                changeAIcars(AI2);
            }


            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver(); 
            }
            if (Score <= 150)
            {
                award.Image = Properties.Resources.GameOver;
            }
            if (Score > 150 && Score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }
            if (Score > 500 && Score < 2000)
            {
                award.Image = Properties.Resources.silver;
                trafficSpeed = 22;
                roadSpeed = 20;
            }
            
            if (Score > 2000)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 27;
                roadSpeed = 25;
            }
        }


        private void changeAIcars(PictureBox tempcar)
        {
            carImage = rand.Next(1, 9);

            switch (carImage)
            {
                
                case 1:
                    AI1.Image = Properties.Resources.ambulance;
                    break;
                
                case 2:
                    AI1.Image = Properties.Resources.carGreen;
                    break;
                
                case 3:
                    AI1.Image = Properties.Resources.carGrey;
                    break;
                
                case 4:
                    AI1.Image = Properties.Resources.carOrange;
                    break;
                
                case 5:
                    AI1.Image = Properties.Resources.CarRed;
                    break;
                
                case 6:
                    AI1.Image = Properties.Resources.carYellow;
                    break;

                case 7:
                    AI1.Image = Properties.Resources.carPink;
                    break;
                default:
                    break;

                case 8:
                    AI1.Image = Properties.Resources.TruckWhite;
                   break;
                
                case 9: 
                    AI1.Image = Properties.Resources.TruckBlue;
                    break;
              
                  
            }


            tempcar.Top = carPosition.Next(100, 400) * -1;

            if ((string)tempcar.Tag == "carLeft")
            {
                tempcar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempcar.Tag == "carRight")
            {
                tempcar.Left = carPosition.Next(245, 422);
            }

        }



        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;


        }


        private void ResetGame()
        {
            
            btnStart.Enabled = false;

            explosion.Visible = false; 

            award.Visible = false;

            goleft = false;

            goright = false;
            
            Score = 0;

            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(200,500) *-1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) *-1;
            AI2.Top = carPosition.Next(245, 422);


            gameTimer.Start();


        }

        private void reStartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void playSound()
        {
            System.Media.SoundPlayer playcrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playcrash.Play();
        }


    }   



}
