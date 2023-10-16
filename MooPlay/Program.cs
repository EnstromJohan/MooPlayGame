using MooPlay;

Console.WriteLine("Enter your username:  ");
string playerName = Console.ReadLine();

GameMenu gameMenu = new GameMenu();
gameMenu.StartGame(playerName);