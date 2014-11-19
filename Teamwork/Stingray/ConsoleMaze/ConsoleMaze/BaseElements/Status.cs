using System;

class Status
{
    public static void PrintStatusBar(Map map)
    {
        ConsoleIteracion.PrintOnTheConsole(38, 2, "CONSOLE MAZE", ConsoleColor.Green);
        ConsoleIteracion.PrintOnTheConsole(38, 8, "Score: " + Level.currentCoins, ConsoleColor.Green);
        ConsoleIteracion.PrintOnTheConsole(38, 12, "Total Score: " + Level.totalCoins, ConsoleColor.Green);
        ConsoleIteracion.PrintOnTheConsole(38, 16, "Level: " + Level.level, ConsoleColor.Green);
        ConsoleIteracion.PrintOnTheConsole(38, 20, "Menu: Esc", ConsoleColor.Green);
    }
}