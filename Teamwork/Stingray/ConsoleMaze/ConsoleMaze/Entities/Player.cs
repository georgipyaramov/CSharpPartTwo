using System;

class Player : Movement<Player>, IEntity
{
    //fields
    private const int LEFT = 1;
    private const int RIGHT = 2;
    private const int UP = 3;
    private const int DOWN = 4;


    //constructor
    public Player()
    {
        this.Color = ConsoleColor.Yellow;
        //Smile face
        this.Character = '\u263A';
        this.CollectedCoins = 0;
        this.Name = "Player";
    }

    //Get and set the color of the player
    public ConsoleColor Color
    {
        get;
        private set;
    }

    //Get and set the character of the player.
    public char Character
    {
        get;
        private set;
    }

    //Get and set column position of the player.
    public int PositionColumn
    {
        get;
        set;
    }

    //Get and set row position of the player.
    public int PositionRow
    {
        get;
        set;
    }

    //Get and set collected coins of the player.
    public int CollectedCoins
    {
        get;
        set;
    }
    
    //Get and set current score of the player.
    public int CurrentScore
    {
        get;
        set;
    }

    //Direction of the player
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

    //Methods
    public void ChangePlayerDirection(ConsoleKeyInfo key)
    {
        int direction = 0;
        if (key.Key == ConsoleKey.LeftArrow)
        {
            direction = LEFT;
        }
        if (key.Key == ConsoleKey.RightArrow)
        {
            direction = RIGHT;
        }
        if (key.Key == ConsoleKey.UpArrow)
        {
            direction = UP;
        }
        if (key.Key == ConsoleKey.DownArrow)
        {
            direction = DOWN;
        }
        this.ChangeDirection(direction);
    }
}