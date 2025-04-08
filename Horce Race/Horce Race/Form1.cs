using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horce_Race
{
    public partial class Form1 : Form
    {
        Random random;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            gameTimer.Start();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            int dogSpeed = random.Next(5,20);
            int gokuSpeed = random.Next(5, 20);
            int pikachuSpeed = random.Next(5, 20);
            int sonicSpeed = random.Next(5, 20);


            dog.Left += dogSpeed;
            goku.Left += gokuSpeed;
            pikachu.Left += pikachuSpeed;
            sonic.Left += sonicSpeed;

            if(dog.Right >= 950)
            {
                gameTimer.Stop();
                MessageBox.Show("The dog won!!");
                Application.Restart();
            }
            else if (goku.Right >= 950)
            {
                gameTimer.Stop();
                MessageBox.Show("Goku won!!");
                Application.Restart();
            }
            else if (pikachu.Right >= 950)
            {
                gameTimer.Stop();
                MessageBox.Show("Pikachu won!!");
                Application.Restart();
            }
            else if (sonic.Right >= 950)
            {
                gameTimer.Stop();
                MessageBox.Show("Sonic won!!");
                Application.Restart();
            }



        }
    }
}
