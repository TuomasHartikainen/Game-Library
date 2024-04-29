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
    public partial class Form3 : Form
    {
        Button[,] btns = new Button[4, 4];
        int xScore, oScore = 0;
        int btnCount = 1;
        string symbol;

        public void Initialize()
        {
            btns[1, 1] = button1;
            btns[1, 2] = button2;
            btns[1, 3] = button3;
            btns[2, 1] = button4;
            btns[2, 2] = button5;
            btns[2, 3] = button6;
            btns[3, 1] = button7;
            btns[3, 2] = button8;
            btns[3, 3] = button9;
        }
        public Form3()
        {
            InitializeComponent();
            Initialize();
            buttonStart.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void Form3_Shown(object sender, EventArgs e)
        {
            buttonStart.Focus();
        }

        private void TurnDecider()
        {
            if (btnCount % 2 == 0)
            {
                symbol = "O";
            }
            else
            {
                symbol = "X";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button1.Text = symbol;
            btnCount++;
            button1.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(1, 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button2.Text = symbol;
            btnCount++;
            button2.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(1, 2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button3.Text = symbol;
            btnCount++;
            button3.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(1, 3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button4.Text = symbol;
            btnCount++;
            button4.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(2, 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button5.Text = symbol;
            btnCount++;
            button5.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(2, 2);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button6.Text = symbol;
            btnCount++;
            button6.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(2, 3);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button7.Text = symbol;
            btnCount++;
            button7.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(3, 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button8.Text = symbol;
            btnCount++;
            button8.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(3, 2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TurnDecider();
            button9.Text = symbol;
            btnCount++;
            button9.Enabled = false;
            if (btnCount >= 5)
            {
                CheckWinner(3, 3);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void CheckWinner(int row, int col)
        {
            if (btns[row, col].Text == "O")
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (btns[i, 1].Text == "O" && btns[i, 2].Text == "O" && btns[i, 3].Text == "O")
                    {
                        MessageBox.Show("Winner is O");
                        oScore++;
                        labelOScore.Text = "O: " + oScore;
                        ClearBoard();
                    }
                    if (btns[1, i].Text == "O" && btns[2, i].Text == "O" && btns[3, i].Text == "O")
                    {
                        MessageBox.Show("Winner is O");
                        oScore++;
                        labelOScore.Text = "O: " + oScore;
                        ClearBoard();
                    }
                }
                if (btns[1, 1].Text == "O" && btns[2, 2].Text == "O" && btns[3, 3].Text == "O")
                {
                    MessageBox.Show("Winner is O");
                    oScore++;
                    labelOScore.Text = "O: " + oScore;
                    ClearBoard();
                }
                if (btns[1, 3].Text == "O" && btns[2, 2].Text == "O" && btns[3, 1].Text == "O")
                {
                    MessageBox.Show("Winner is O");
                    oScore++;
                    labelOScore.Text = "O: " + oScore;
                    ClearBoard();
                }
            }
            if (btns[row, col].Text == "X")
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (btns[i, 1].Text == "X" && btns[i, 2].Text == "X" && btns[i, 3].Text == "X")
                    {
                        MessageBox.Show("Winner is X");
                        xScore++;
                        labelXScore.Text = "X: " + xScore;
                        ClearBoard();
                    }
                    if (btns[1, i].Text == "X" && btns[2, i].Text == "X" && btns[3, i].Text == "X")
                    {
                        MessageBox.Show("Winner is X");
                        xScore++;
                        labelXScore.Text = "X: " + xScore;
                        ClearBoard();
                    }
                }
                if (btns[1, 1].Text == "X" && btns[2, 2].Text == "X" && btns[3, 3].Text == "X")
                {
                    MessageBox.Show("Winner is X");
                    xScore++;
                    labelXScore.Text = "X: " + xScore;
                    ClearBoard();
                }
                if (btns[1, 3].Text == "X" && btns[2, 2].Text == "X" && btns[3, 1].Text == "X")
                {
                    MessageBox.Show("Winner is X");
                    xScore++;
                    labelXScore.Text = "X: " + xScore;
                    ClearBoard();
                }
                if (btnCount > 9)
                {
                    MessageBox.Show("Tie");
                    ClearBoard();
                }
            }
        }

        public void ClearBoard()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    btns[i, j].Text = " ";
                    btns[i, j].Enabled = true;
                }
            }
            btnCount = 1;
        }
    }
}
