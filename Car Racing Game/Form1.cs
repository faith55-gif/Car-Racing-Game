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

        //global variables
        int carSpeed = 5;
        int roadSpeed = 5;
        bool carLeft;
        bool carRight;
        int trafficSpeed = 5;
        int Score = 0;
        Random rnd = new Random();
        Random carPosition = new Random();

        bool goleft, goright;
        public Form1()
        {
            InitializeComponent();
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
        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

        }


        private void changeAIcars(PictureBox tempcar)
        {

        }



        private void gameOver()
        { 
        
        }


        private void ResetGame()
        { 
        
        }





        private void playSound()
        { 
        
        }


    }   



}
