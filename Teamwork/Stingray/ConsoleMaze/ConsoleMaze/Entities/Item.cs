using System;
using System.Collections.Generic;
class Item
{
    public Queue<Tuple<int, int>> coinCoords = new Queue<Tuple<int,int>>();

    //constructor
    public Item(int row, int column, ConsoleColor color, char character)
    {
        this.PositionRow = row;
        this.PositionColumn = column;
        this.Color = color;
        this.Character = character;
    }

    //Get and set the color of the item
    public ConsoleColor Color
    {
        get;
        private set;
    }

    //Get and set the character of the item.
    public char Character
    {
        get;
        private set;
    }

    //Get and set column position of the item.
    public int PositionColumn
    {
        get;
        set;
    }

    //Get and set row position of the item.
    public int PositionRow
    {
        get;
        set;
    }

    public Queue<Tuple<int, int>> CoinCoords
    {
        get
        {
            return this.coinCoords;
        }
    }
}