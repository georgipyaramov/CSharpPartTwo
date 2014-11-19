using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

class ConsoleMaze
{
    public static Random random = new Random();

    static void Main()
    {
        Level.SetGameField();
        Console.CursorVisible = false;
        MainMenu.ManageMenu();
    }
}

