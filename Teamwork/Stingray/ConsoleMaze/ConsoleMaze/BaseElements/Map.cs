using System.IO;
using System.Collections.Generic;
using System;

class Map
{
    private const char BAD_GUY_SYMBOL = 'B';
    private const char GOOD_GUY_SYMBOL = 'G';
    private const char EXIT = 'X';
    private const char EMPTY = ' ';
    private const char WALL = '|';
    private const char COIN = '\u00A9';
    public const char WALL_UNICODE = '\u2588';

    private char[,] map;
    private List<Item> items = new List<Item>();

    public Map()
    {
        this.GoodGuy = new Player();
        this.BadGuy = new Bot();
        this.map = InitMap();
        this.SetCoins(Level.level * (int)Level.CoinCoeficent);
    }
    private char[,] InitMap()
    {
        char[,] map;
        try
        {
            string path = @"../../Files/MapLevel" + Level.level + ".txt";
            //Get map size
            using (StreamReader reader = new StreamReader(path))
            {
                string currentLine = reader.ReadLine();
                int cols = currentLine.Length;
                int rows = 1;
                while (currentLine != null)
                {
                    currentLine = reader.ReadLine();
                    rows++;
                }
                map = new char[rows, cols];

            }
            using (StreamReader reader = new StreamReader(path))
            {
                string currentLine = reader.ReadLine();
                for (int row = 0; row < map.GetLength(0); row++)
                {
                    if (currentLine != null)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            char currentElem = currentLine[col];
                            if (currentElem == BAD_GUY_SYMBOL)
                            {
                                InitCoordsForPlayerAndBot(false, row, col);
                                currentElem = EMPTY;
                            }
                            else if (currentElem == GOOD_GUY_SYMBOL)
                            {
                                InitCoordsForPlayerAndBot(true, row, col);
                                currentElem = EMPTY;
                            }
                            else if (currentElem == EXIT)
                            {
                                this.Exit = new int[] { row, col };
                            }
                            else if (currentElem == WALL)
                            {
                                currentElem = WALL_UNICODE;
                            }
                            map[row, col] = currentElem;
                        }
                    }
                    currentLine = reader.ReadLine();
                }
            }
            return map;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }

    //Indexation
    public char this[int row, int col]
    {
        get
        {
            return this.map[row, col];
        }
        set
        {
            this.map[row, col] = value;
        }
    }

    //Properties
    public int Rows
    {
        get
        {
            return this.map.GetLength(0);
        }
    }

    public int Columns
    {
        get
        {
            return this.map.GetLength(1);
        }
    }

    public Player GoodGuy
    {
        get;
        set;
    }

    public Bot BadGuy
    {
        get;
        set;
    }

    public List<Item> Items
    {
        get
        {
            return this.items;
        }
    }

    //return position of the exit
    public int[] Exit
    {
        get;
        private set;
    }

    //Initialize 'x' and 'y' coordinates to player and bot.
    private void InitCoordsForPlayerAndBot(bool isPlayer, int row, int col)
    {
        if (isPlayer == true)
        {
            this.GoodGuy.PositionRow = row;
            this.GoodGuy.PositionColumn = col;
        }
        else
        {
            this.BadGuy.PositionRow = row;
            this.BadGuy.PositionColumn = col;
        }
    }


    //set coins by given count
    public void SetCoins(int count)
    {
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                int coinRow = ConsoleMaze.random.Next(0, this.Rows);
                int coinCol = ConsoleMaze.random.Next(0, this.Columns);
                if (this[coinRow, coinCol] == ' ')
                {
                    this.items.Add(new Item(coinRow, coinCol, ConsoleColor.Yellow, COIN));
                    this[coinRow, coinCol] = COIN;
                    count--;
                }
                if (count <= 0)
                {
                    return;
                }
            }
        }
        if (count > 0)
        {
            SetCoins(count);
        }
    }
    //play short melody when pass through the exit
    public static void PlayMusicExit()
    {
        Console.Beep(495, 700);
        Console.Beep(528, 400);
        Console.Beep(660, 400);
        Console.Beep(880, 700);

    }
    //Play sound when collect a coin
    public static void PlayMusicCoin()
    {
        Console.Beep(705, 60);
        Console.Beep(528, 30);
    }

    //Generate matrix with '1' for wall and '0' for anything else. This is preparation for Breadth First Search.
    public int[,] PrepareMapForBFS()
    {
        int[,] result = new int[this.Rows, this.Columns];
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                char curElem = map[row, col];
                if (curElem == Map.WALL_UNICODE)
                {
                    result[row, col] = 1;
                }
                else result[row, col] = 0;
            }
        }
        return result;
    }
}