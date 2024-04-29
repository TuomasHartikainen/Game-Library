# How to install and use the application
Firstly download the files from GitHub to your machine. Open and navigate to Setup-SetupFiles folder: ..\Game Library Manager\Setup\Setup-SetupFiles and launch Setup.exe file. After done with the Setup Wizard open the application on your desktop

The application is a library with games that you can play. After launching the application you will be directed to the 'store page' where you can add games to your library. To play them just go to User library section and you will see games that you added to the library. Just simply press Play game button. If you want to remove a game, simply press Remove game from your library button. That should be it, enjoy! :D
## Screenshots from the application
Game store

![GLM1](https://github.com/TuomasHartikainen/Game-Library/assets/164089057/aea7530d-fd51-4c4b-94bf-86d870285351)

Library

![GLM2](https://github.com/TuomasHartikainen/Game-Library/assets/164089057/aa3e9506-2515-41a4-a350-703a75f3b3f4)
## Game Library Manager flowchart
![GLM drawio](https://github.com/TuomasHartikainen/Game-Library/assets/164089057/b5e19178-7548-4915-ba82-1f200f055ca8)
## Coding
The code in the main library application let's us add games to our library and by that it gives us a message through a messagebox and shows the game in the library. You can play the game which opens a new window with the game. Here's an example code of adding games to library and playing
```
private void AddGameToLibrary(int i)
{
        labelEmptyLibrary.Visible = false; //Disables empty library text when you add a game to your library
        MessageBox.Show($"Added {games[i].Name} to your library"); //Shows the messagebox that the games has been added to the library with the game name
        DisplayGameInLibrary(i); //Displays the right game in the library
}

private void buttonLibraryGamePlay_Click(object sender, EventArgs e)
{
    Button clickedButton = (Button)sender;
    int i = int.Parse(clickedButton.Name.Replace("buttonLibraryGamePlay", "")); //Looks which button was pressed
    string gameName = games[i].Name;
    if (gameName == "Rock Paper Scissors") //If the pressed button name was Rock Paper Scissors then it starts the right game
    {
        Form2 form2 = new Form2();
        form2.ShowDialog();
    }
    else if (gameName == "Tic Tac Toe") //Else if the pressed button name was Tic Tac Toe then it starts the right game
    {
        Form3 form3 = new Form3();
        form3.ShowDialog();
    }
}
```
# Future ideas
Here are some ideas that I have been thinking of adding in the future if I continue this project:
1. Save and load system or maybe even a login and account system, so your games added to the library save and don't have to add them again on the next launch
2. MORE GAMES. Adding more games such as chess, snake, tetris, pong, and much more
3. Updating already added games. Adding a possibility for two players to play Rock Paper Scissors or adding a possibility to play against a computer in Tic Tac Toe
4. Complete overhaul of the user interface (I'm not too proud of it as it is now but it's not the worst either)
