using Game_Library.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Game_Library
{
    public partial class FormGames : Form
    {
        List<string> gameName = new List<string>() { "Rock Paper Scissors", "Tic Tac Toe" };
        List<Game> games = new List<Game>
        {
            new Game { Name = "Rock Paper Scissors", Description = "A classic two-person hand game", Genre = "Arcade"},
            new Game { Name = "Tic Tac Toe", Description = "A classic paper and pencil game", Genre = "Strategy"}
        };

        public class Game
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Genre { get; set; }
        }

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
            labelGame1.Visible = true;
            labelGame2.Visible = true;
            buttonGame1.Visible = true;
            buttonGame2.Visible = true;
            pictureBoxRPS.Visible = true;
            pictureBoxTTT.Visible = true;
        }

        private void buttonGame1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            this.buttonGame1.Tag = 0;
            int i = (int)clickedButton.Tag;
            AddGameToLibrary(i);
            clickedButton.Enabled = false;
        }

        private void buttonGame2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            this.buttonGame2.Tag = 1;
            int i = (int)clickedButton.Tag;
            AddGameToLibrary(i);
            clickedButton.Enabled = false;
        }

        private void buttonLibraryGameRemove_Click(object sender, EventArgs e)
        {
            int i = (int)((Button)sender).Tag;
            RemoveGameFromLibrary(i);
            if (i == 0)
            {
                buttonGame1.Enabled = true;
            }
            else if (i == 1)
            {
                buttonGame2.Enabled = true;
            }
        }

        private void AddGameToLibrary(int i)
        {
                labelEmptyLibrary.Visible = false;
                MessageBox.Show($"Added {games[i].Name} to your library");
                DisplayGameInLibrary(i);
        }
        private void RemoveGameFromLibrary(int i)
        {
            foreach (Control tempCtrl in panelShowLibrary.Controls)
            {
                if (tempCtrl.Name == $"labelLibraryGame{i}" || tempCtrl.Name == $"buttonLibraryGameRemove{i}")
                {
                    panelShowLibrary.Controls.Remove(tempCtrl);
                }
            }
            foreach (Control tempCtrl2 in panelShowLibrary.Controls)
            {
                if (tempCtrl2.Name == $"buttonLibraryGamePlay{i}")
                {
                    panelShowLibrary.Controls.Remove(tempCtrl2);
                    bool libraryIsEmpty = true;
                    foreach (Control ctrl in panelShowLibrary.Controls)
                    {
                        if (ctrl is Button && ctrl.Name.StartsWith("buttonLibraryGamePlay"))
                        {
                            libraryIsEmpty = false;
                            break;
                        }
                    }
                    if (libraryIsEmpty)
                    {
                        labelEmptyLibrary.Visible = true;
                    }
                    break;
                }
            }
        }

        private void DisplayGameInLibrary(int i)
        {
            Label labelLibraryGame = new Label();
            {
                labelLibraryGame.Name = $"labelLibraryGame{i}";
                labelLibraryGame.Text = games[i].Name + ". " + games[i].Description;
                labelLibraryGame.Font = new Font(labelLibraryGame.Font.FontFamily, 15);
                labelLibraryGame.Location = new Point(11, 75 + i * 60);
                labelLibraryGame.AutoSize = true;
            }
            Button buttonLibraryGamePlay = new Button();
            {
                buttonLibraryGamePlay.Name = $"buttonLibraryGamePlay{i}";
                buttonLibraryGamePlay.Text = "Play game";
                buttonLibraryGamePlay.Location = new Point(15, 105 + i * 60);
                buttonLibraryGamePlay.AutoSize = true;
                buttonLibraryGamePlay.Click += new EventHandler(buttonLibraryGamePlay_Click);
            }
            Button buttonLibraryGameRemove = new Button();
            {
                buttonLibraryGameRemove.Name = $"buttonLibraryGameRemove{i}";
                buttonLibraryGameRemove.Text = "Remove game from your library";
                buttonLibraryGameRemove.Location = new Point(90, 105 + i * 60);
                buttonLibraryGameRemove.Tag = i;
                buttonLibraryGameRemove.AutoSize = true;
                buttonLibraryGameRemove.Click += new EventHandler(buttonLibraryGameRemove_Click);
            }
            panelShowLibrary.Controls.Add(labelLibraryGame);
            panelShowLibrary.Controls.Add(buttonLibraryGamePlay);
            panelShowLibrary.Controls.Add(buttonLibraryGameRemove);
        }

        private void buttonArcade_Click(object sender, EventArgs e)
        {
            labelGame2.Visible = false;
            buttonGame2.Visible = false;
            pictureBoxTTT.Visible = false;
            labelGame1.Visible = true;
            buttonGame1.Visible = true;
            pictureBoxRPS.Visible = true;
        }

        private void buttonPuzzle_Click(object sender, EventArgs e)
        {
            labelGame1.Visible = false;
            buttonGame1.Visible = false;
            pictureBoxRPS.Visible = false;
            labelGame2.Visible = false;
            buttonGame2.Visible = false;
            pictureBoxTTT.Visible = false;
        }

        private void buttonStrategy_Click(object sender, EventArgs e)
        {
            labelGame1.Visible = false;
            buttonGame1.Visible = false;
            pictureBoxRPS.Visible = false;
            labelGame2.Visible = true;
            buttonGame2.Visible = true;
            pictureBoxTTT.Visible = true;
        }
        private void buttonLibraryGamePlay_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int i = int.Parse(clickedButton.Name.Replace("buttonLibraryGamePlay", ""));
            string gameName = games[i].Name;
            if (gameName == "Rock Paper Scissors")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else if (gameName == "Tic Tac Toe")
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
        }
    }
}