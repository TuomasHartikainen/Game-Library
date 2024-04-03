using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Library
{
    public partial class FormGames : Form
    {
        public FormGames()
        {
            InitializeComponent();
            buttonArcade.Visible = false;
            buttonPuzzle.Visible = false;
            buttonStrategy.Visible = false;
            panelShowLibrary.Visible = false;
            panelShowGames.Visible = true;
        }
            private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (buttonPuzzle.Visible || buttonStrategy.Visible || buttonArcade.Visible)
            {
                buttonArcade.Visible = false;
                buttonPuzzle.Visible = false;
                buttonStrategy.Visible = false;
            }
            else
            {
                buttonArcade.Visible = true;
                buttonPuzzle.Visible = true;
                buttonStrategy.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelShowLibrary.Visible = true;
            panelShowGames.Visible = false;
        }

        private void buttonGames_Click(object sender, EventArgs e)
        {
            panelShowLibrary.Visible = false;
            panelShowGames.Visible = true;
        }

        private void buttonGame1_Click(object sender, EventArgs e)
        {
            AddGameToLibrary();
        }

        private void buttonGame2_Click(object sender, EventArgs e)
        {
            AddGameToLibrary();
        }

        private void AddGameToLibrary()
        {
            MessageBox.Show("Added game to library");
        }
    }
}
