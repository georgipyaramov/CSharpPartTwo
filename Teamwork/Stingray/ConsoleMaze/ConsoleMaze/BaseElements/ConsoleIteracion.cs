using System;
using System.Text;

static class ConsoleIteracion
{
    //Print given string on the console.
    public static void PrintOnTheConsole(int x, int y, string elem, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write(elem);
        Console.ResetColor();
    }

    //Overload with char parameter
    public static void PrintOnTheConsole(int x, int y, char elem, ConsoleColor color)
    {
        PrintOnTheConsole(x, y, elem.ToString(), color);
    }

    //Remove char from the console by given column and row.
    public static void RemoveFromConsole(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(' ');
    }

    public static void DrawMap(Map map)
    {
        char coinChar = map.Items[0].Character;
        for (int row = 0; row < map.Rows; row++)
        {
            for (int col = 0; col < map.Columns; col++)
            {
                if (map[row, col] == coinChar)
                {
                    PrintOnTheConsole(col, row, map[row, col], ConsoleColor.Yellow);
                }
                else PrintOnTheConsole(col, row, map[row, col], ConsoleColor.Green);
            }
            Console.WriteLine();
        }
    }

    public static void DrawPlayers(Player goodGuy, Bot badGuy)
    {
        PrintOnTheConsole(goodGuy.PositionColumn, goodGuy.PositionRow, goodGuy.Character, goodGuy.Color);
        PrintOnTheConsole(badGuy.PositionColumn, badGuy.PositionRow, badGuy.Character, badGuy.Color);
    }
}