using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Library.Forms
{
    public partial class Form2 : Form
    {
        private int computerChoice, playerChoice, playerScore, computerScore = 0;
        public Form2()
        {
            InitializeComponent();
            buttonStart.Enabled = true;
            buttonRock.Enabled = false;
            buttonPaper.Enabled = false;
            buttonScissors.Enabled = false;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            buttonStart.Focus();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonRock.Enabled = true;
            buttonPaper.Enabled = true;
            buttonScissors.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerChoice = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerChoice = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerChoice = 3;
        }

        private void gameStart()
        {
            Random rnd = new Random(Environment.TickCount);
            computerChoice = rnd.Next(1, 4);
            string computerChoiceStr = "";
            string playerChoiceStr = "";
            string winner = "";
            switch (playerChoice)
            {
                case 1:
                    playerChoiceStr = "Rock";
                    break;
                case 2:
                    playerChoiceStr = "Paper";
                    break;
                case 3:
                    playerChoiceStr = "Scissors";
                    break;
            }
            switch (computerChoice)
            {
                case 1:
                    computerChoiceStr = "Rock";
                    break;
                case 2:
                    computerChoiceStr = "Paper";
                    break;
                case 3:
                    computerChoiceStr = "Scissors";
                    break;
            }
        }
    }
}
