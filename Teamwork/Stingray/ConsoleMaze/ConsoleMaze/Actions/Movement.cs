using System;

class Movement<TEntity>
    where TEntity : IEntity
{
    //Directions
    private const int LEFT = 1;
    private const int RIGHT = 2;
    private const int UP = 3;
    private const int DOWN = 4;
    private const char EMPTY = ' ';

    //Change the direction of the entity (Up, Down, Left or Right);
    public void ChangeDirection(int direction)
    {
        var entity = this as IEntity;
        if (direction == LEFT)
        {
            entity.Direction = LEFT;
        }
        if (direction == RIGHT)
        {
            entity.Direction = RIGHT;
        }
        if (direction == UP)
        {
            entity.Direction = UP;
        }
        if (direction == DOWN)
        {
            entity.Direction = DOWN;
        }
    }

    //Change the position of the entity on the screen.
    public void Move()
    {
        var entity = this as IEntity;
        int direction = entity.Direction;

        //Remove old position
        ConsoleIteracion.RemoveFromConsole(entity.PositionColumn, entity.PositionRow);

        if (direction == UP)
        {
            entity.PositionRow--;
        }
        if (direction == DOWN)
        {
            entity.PositionRow++;
        }
        if (direction == LEFT)
        {
            entity.PositionColumn--;
        }
        if (direction == RIGHT)
        {
            entity.PositionColumn++;
        }

        //Draw new position
        ConsoleIteracion.PrintOnTheConsole(entity.PositionColumn, entity.PositionRow, entity.Character, entity.Color);
    }

    public bool IsMoveAvailable(Map map)
    {
        var entity = this as IEntity;
        int row = entity.PositionRow;
        int col = entity.PositionColumn;
        char coinChar = map.Items[0].Character;

        if (entity.Direction == UP && (map[row - 1, col] == EMPTY || map[row - 1, col] == coinChar))
        {
            if (entity.Name == "Player" && map[row - 1, col] == coinChar)
            {
                ExitControl(map, row - 1, col);
            }
            return true;
        }
        if (entity.Direction == DOWN && (map[row + 1, col] == EMPTY || map[row + 1, col] == coinChar))
        {
            if (entity.Name == "Player" && map[row + 1, col] == coinChar)
            {
                ExitControl(map, row + 1, col);
            }
            return true;
        }
        if (entity.Direction == LEFT && (map[row, col - 1] == EMPTY || map[row, col - 1] == coinChar))
        {
            if (entity.Name == "Player" && map[row, col - 1] == coinChar)
            {
                ExitControl(map, row, col - 1);
            }
            return true;
        }
        if (entity.Direction == RIGHT && (map[row, col + 1] == EMPTY || map[row, col + 1] == coinChar))
        {
            if (entity.Name == "Player" && map[row, col + 1] == coinChar)
            {
                ExitControl(map, row, col + 1);
            }
            return true;
        }
        return false;
    }

    //detect is there collision between good and bad guy.
    public bool CollisionDetect(Player goodGuy)
    {
        var badGuy = this as IEntity;
        if (goodGuy.PositionColumn == badGuy.PositionColumn && goodGuy.PositionRow == badGuy.PositionRow)
        {
            return true;
        }
        return false;
    }

    public void PrintCoin(Map map)
    {
        var badGuy = this as IEntity;
        var coords = map.Items[0].CoinCoords;
        var firstElem = coords.Peek();
        int coinRow = firstElem.Item1;
        int coinCol = firstElem.Item2;

        if (badGuy.PositionRow != coinRow || badGuy.PositionColumn != coinCol)
        {
            coords.Dequeue();
            ConsoleIteracion.PrintOnTheConsole(coinCol, coinRow, map.Items[0].Character, map.Items[0].Color);
        }
    }

    public void ExitControl(Map map, int row, int col)
    {
        Map.PlayMusicCoin();
        map.GoodGuy.CollectedCoins++;
        Level.currentCoins++;
        Level.totalCoins++;
        map[row, col] = EMPTY;
        if (Level.IsTheExitOpen())
        {
            Level.OpenTheExit(map.Exit[0], map.Exit[1]);
            map[map.Exit[0], map.Exit[1]] = EMPTY;
        }
    }

    public bool IsExit(Map map)
    {
        int row = map.GoodGuy.PositionRow;
        int col = map.GoodGuy.PositionColumn;

        if (row == map.Exit[0] && col == map.Exit[1])
        {
            return true;
        }
        return false;
    }
}