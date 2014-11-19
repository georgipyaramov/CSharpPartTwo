using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class MainMenu
{
    private static ConsoleColor selectedOptionColor = ConsoleColor.Green;
    private static int totalLevels = Level.levels.Length;

    private static string[] menuItems = 
        {
            "-> Start New Game",
            "-> Replay the current level",
            "-> Go to the next level",
            "-> Show highscore",
            "-> Show help",
            "-> EXIT"
        };
    private static int totalOptions = 5;
    public static void ManageMenu()
    {
        //Menu
        int selectedOption = 0;
        while (selectedOption != totalOptions)
        {
            selectedOption = PrintMenu();
            Console.Clear();
            switch (selectedOption)
            {
                case 0: Level.totalCoins = 0;
                    Level.LaunchLevel(Level.level == 1 ? Level.level : Level.level = 1); break;
                case 1: Level.LaunchLevel(Level.level); break; //StartGame (currentLevel-1);
                case 2: Level.LaunchLevel(Level.level >= totalLevels ? Level.level = totalLevels : Level.level++); break;
                case 3: ReadDisplayHighscore(); 
                    selectedOption = totalOptions; 
                    break;
                case 4: ReadDisplayHelp(); 
                    selectedOption = totalOptions; 
                    break;
            }
            if (selectedOption != totalOptions)
            {
                ReturnToTheMenu();
                Console.Clear();
                Console.SetCursorPosition(0, 0);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
    //Print the menu and return the selected action
    private static int PrintMenu()
    {
        Console.Clear();
        Console.ResetColor();
        Console.WriteLine("{0,20}", "MENU");
        Console.WriteLine("Select an action and press 'enter'");

        int currentSelection = 0;
        int? selectedOption = null;
        while (selectedOption == null)
        {
           Console.SetCursorPosition(0, 3);

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (currentSelection == i)
                {
                    Console.ForegroundColor = selectedOptionColor;
                }
                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (currentSelection < totalOptions)
                {
                    currentSelection++;
                }
                else
                {
                    currentSelection = 0;
                }
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (currentSelection == 0)
                {
                    currentSelection = totalOptions;
                }
                else
                {
                    currentSelection--;
                }
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                selectedOption = currentSelection;
            }
        }
        return (int)selectedOption;
    }

    public static string highscoreFile = @"../../Files/highscore.txt";

    public static void ReadDisplayHighscore()
    {
        try
        {
            StreamReader reader = new StreamReader(highscoreFile);

            using (reader)
            {
                Console.WriteLine("Score Name");
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            ReturnToTheMenu();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("There is no highscore yet!");
            ReturnToTheMenu();
        }
        finally
        {            
            Console.Clear();
            ManageMenu();
        }
    }

    public static string helpFile = @"../../Files/help.txt";

    static void ReadDisplayHelp()
    {
        try
        {
            StreamReader reader = new StreamReader(helpFile);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            ReturnToTheMenu();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("There is no help file!");
            ReturnToTheMenu();
        }
        finally
        {            
            Console.Clear();
            ManageMenu();
        }
    }

    public static string victory = @"../../Files/VictoryMessage.txt";
    public static void DisplayVictory()
    {
        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }
        Console.Clear();
        try
        {
            string text = File.ReadAllText(victory);
            Console.WriteLine(text);
            ReturnToTheMenu();
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            ManageMenu();
        }
        catch (FileNotFoundException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            ManageMenu();
        }
    }
    public static string defeat = @"../../Files/DefeatMessage.txt";
    public static void DisplayDefeat()
    {
        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }
        Console.Clear();
        try
        {
            string text = File.ReadAllText(defeat);
            Console.WriteLine(text);
            ReturnToTheMenu();
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            ManageMenu();
        }
        catch (FileNotFoundException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            ManageMenu();
        }
    }
    static void ReturnToTheMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to return to the Menu...");
        Console.ReadKey();
    }
}