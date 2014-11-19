using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class Level
{
    public static int level = 1;
    public static int currentCoins = 0;
    public static int totalCoins = 0;
    public const double CoinCoeficent = 7.5;

    //methods

    public static int[] levels = 
    { 
        (int)(Level.level * CoinCoeficent), 
        (int)((Level.level+1) * CoinCoeficent), 
        (int)((Level.level+2) * CoinCoeficent), 
        (int)((Level.level+3) * CoinCoeficent), 
        (int)((Level.level+4) * CoinCoeficent) 
    };
    const double LevelChangePercent = 0.6;

    public static bool IsTheExitOpen()
    {
        if (currentCoins >= (LevelChangePercent * levels[level - 1]))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Open the exit
    public static void OpenTheExit(int exitX, int exitY)
    {
        ConsoleIteracion.RemoveFromConsole(exitY, exitX);
    }

    //Actions when player goes to the exit
    private static void OnExitActions()
    {
        Map.PlayMusicExit();
        AddToHighscore();
        Level.currentCoins = 0;
        MainMenu.ManageMenu();
    }

    //Set the console dimension
    public static void SetGameField()
    {
        Console.Title = "Console Maze";
        Console.WindowHeight = 30;
        Console.BufferHeight = 30;

        Console.WindowWidth = 80;
        Console.BufferWidth = 80;
    }

    //Check if player has press the espace key
    private static void CheckForMenuShortcut(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.Escape)
        {
            Console.Clear();
            MainMenu.ManageMenu();
        }
    }

    //Main logic for the game
    public static void LaunchLevel(int level)
    {
        Map map = new Map();

        int[,] mapBFS = map.PrepareMapForBFS();

        MazeSolver maze = new MazeSolver(mapBFS);

        Player goodGuy = map.GoodGuy;
        Bot badGuy = map.BadGuy;

        ConsoleIteracion.DrawMap(map);
        ConsoleIteracion.DrawPlayers(goodGuy, badGuy);

        bool canMoveBot = true;

        while (true)
        {
            Status.PrintStatusBar(map);
            if (map.Items[0].CoinCoords.Count > 0)
            {
                badGuy.PrintCoin(map);
            }
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                CheckForMenuShortcut(key);
                goodGuy.ChangePlayerDirection(key);

                if (goodGuy.IsMoveAvailable(map))
                {
                    goodGuy.Move();
                    if (goodGuy.IsExit(map))
                    {
                        OnExitActions();
                    }
                }
            }
            Thread.Sleep(80);
            //Check if it is possible to move the bot
            if (canMoveBot == true)
            {
                badGuy.FindDirectionAndMove(map, maze);
                canMoveBot = false;
            }
            else
            {
                canMoveBot = true;
            }

            Thread.Sleep(80);  //50
        }
    }
    private static void AddToHighscore()
    {
        //write in hiscore file only after the last level
        if (Level.level == Level.levels.Length)
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2 - 2);
            Console.WriteLine("You win!");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 8, Console.WindowHeight / 2 + 2);
            Console.Write("Enter your name: ");
            Console.CursorVisible = true;

            string name = Console.ReadLine();
            Console.CursorVisible = false;
            SortedDictionary<string, string> highscoreList = new SortedDictionary<string, string>();

            try
            {
                StreamReader reader = new StreamReader(MainMenu.highscoreFile);

                using (reader)
                {
                    string lineString = reader.ReadLine();
                    while (lineString != null)
                    {
                        string[] line = lineString.Split(' ');
                        highscoreList.Add(line[1], line[0]);
                        lineString = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("There is no highscore file!");
            }


            if (highscoreList.ContainsKey(Level.totalCoins.ToString()))
            {
                highscoreList[Level.totalCoins.ToString()] = name;
            }
            else
            {
                highscoreList.Add(Level.totalCoins.ToString(), name);
            }

            StreamWriter writer = new StreamWriter(MainMenu.highscoreFile, false);
            using (writer)
            {
                foreach (KeyValuePair<string, string> kvp in highscoreList)
                {
                    //Value = name  Key = score
                    writer.WriteLine(kvp.Value + " " + kvp.Key);
                }
            }
            Console.Clear();
            MainMenu.ReadDisplayHighscore();
        }
        else
        {
            MainMenu.DisplayVictory();
        }
    }
}