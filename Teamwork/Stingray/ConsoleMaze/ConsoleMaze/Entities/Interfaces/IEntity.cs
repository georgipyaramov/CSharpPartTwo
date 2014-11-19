using System;
//Interface for Player and Bot
interface IEntity
{
    int PositionColumn
    {
        get;
        set;
    }
    int PositionRow
    {
        get;
        set;
    }
    ConsoleColor Color
    {
        get;
    }
    char Character
    {
        get;
    }

    int Direction
    {
        get;
        set;
    }

    string Name
    {
        get;
    }
}