using System;

class Bot : Movement<Bot>, IEntity
{
    //constructor
    public Bot()
    {
        this.Color = ConsoleColor.Red;
        //Sad face
        this.Character = '\u263B';
        this.Name = "Bot";
    }

    //Get and set the color of the bot
    public ConsoleColor Color
    {
        get;
        private set;
    }

    //Get and set the character of the bot.
    public char Character
    {
        get;
        private set;
    }

    //Get and set column position of the bot.
    public int PositionColumn
    {
        get;
        set;
    }

    //Get and set row position of the bot.
    public int PositionRow
    {
        get;
        set;
    }

    //Direction of the bot.
    public int Direction
    {
        get;
        set;
    }

    //Name
    public string Name
    {
        get;
        private set;
    }

    //Add removed coin from the bot to the queue and print it again.
    private void SkipCoin(int coinRow, int coinCol, Map map)
    {
        char coinChar = map.Items[0].Character;
        map.Items[0].CoinCoords.Enqueue(new Tuple<int, int>(coinRow, coinCol));
    }

    //Check if the current position of the bot is on top of the coin.
    public void CheckForCoin(int row, int col, Map map)
    {
        char coinChar = map.Items[0].Character;
        if (map[row, col] == coinChar)
        {
            SkipCoin(row, col, map);
        }
    }

    public void FindDirectionAndMove(Map map, MazeSolver maze)
    {
        var goodGuy = map.GoodGuy;
        int nextDirection = maze.FindPath(this.PositionRow, this.PositionColumn, goodGuy.PositionRow, goodGuy.PositionColumn);
        this.ChangeDirection(nextDirection);
        this.Move();
        if (this.CollisionDetect(goodGuy))
        {
            MainMenu.DisplayDefeat();
            Level.currentCoins = 0;
            Level.totalCoins = 0;
            MainMenu.ManageMenu();
        }
        this.CheckForCoin(this.PositionRow, this.PositionColumn, map);
    }
}