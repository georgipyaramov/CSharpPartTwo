﻿using System;

delegate void MazeChangedHandler(int iChanged, int jChanged);
class MazeSolver
{

    /// <summary>
    /// Class attributes/members
    /// </summary>
    int[,] m_iMaze;
    int m_iRows;
    int m_iCols;
    int iPath = 100;
    bool diagonal = false;
    public event MazeChangedHandler OnMazeChangedEvent;

    /// <summary>
    /// Constructor 1: takes a 2D integer array
    /// </summary>
    public MazeSolver(int[,] iMaze)
    {
        m_iMaze = iMaze;
        m_iRows = iMaze.GetLength(0);
        m_iCols = iMaze.GetLength(1);
    }

    /// <summary>
    /// Constructor 2: initializes the dimensions of maze, 
    /// later, indexers may be used to set individual elements' values
    /// </summary>
    public MazeSolver(int iRows, int iCols)
    {
        m_iMaze = new int[iRows, iCols];
        m_iRows = iRows;
        m_iCols = iCols;
    }

    /// <summary>
    /// Properites:
    /// </summary>
    public int Rows
    {
        get { return m_iRows; }
    }

    public int Cols
    {
        get { return m_iCols; }
    }
    public int[,] GetMaze
    {
        get { return m_iMaze; }
    }
    public int PathCharacter
    {
        get { return iPath; }
        set
        {
            if (value == 0)
                throw new Exception("Invalid path character specified");
            else
                iPath = value;
        }
    }
    public bool AllowDiagonals
    {
        get { return diagonal; }
        set { diagonal = value; }
    }


    /// <summary>
    /// Indexer
    /// </summary>
    public int this[int iRow, int iCol]
    {
        get { return m_iMaze[iRow, iCol]; }
        set
        {
            m_iMaze[iRow, iCol] = value;
            if (this.OnMazeChangedEvent != null)	// trigger event
                this.OnMazeChangedEvent(iRow, iCol);
        }
    }

    /// <summary>
    /// The function is used to get the contents of a given node in a given maze,
    ///  specified by its node no.
    /// </summary>
    private int GetNodeContents(int[,] iMaze, int iNodeNo)
    {
        int iCols = iMaze.GetLength(1);
        return iMaze[iNodeNo / iCols, iNodeNo - iNodeNo / iCols * iCols];
    }

    /// <summary>
    /// The function is used to change the contents of a given node in a given maze,
    ///  specified by its node no.
    /// </summary>
    private void ChangeNodeContents(int[,] iMaze, int iNodeNo, int iNewValue)
    {
        int iCols = iMaze.GetLength(1);
        iMaze[iNodeNo / iCols, iNodeNo - iNodeNo / iCols * iCols] = iNewValue;
    }

    /// <summary>
    /// This public function finds the shortest path between two points
    /// in the maze and return the solution as an array with the path traced 
    /// by "iPath" (can be changed using property "PathCharacter")
    /// if no path exists, the function returns null
    /// </summary>
    public int FindPath(int iFromY, int iFromX, int iToY, int iToX)
    {
        int iBeginningNode = iFromY * this.Cols + iFromX;
        int iEndingNode = iToY * this.Cols + iToX;
        var matrix = Search(iBeginningNode, iEndingNode);
        return GetNextMove(matrix, iFromY, iFromX);
    }


    //Return the next move
    public int GetNextMove(int[,] mat, int fromX, int fromY)
    {
        for (int row = 0; row < mat.GetLength(0); row++)
        {
            for (int col = 0; col < mat.GetLength(1); col++)
            {
                int curElem = mat[row, col];
                if (curElem == this.iPath)
                {
                    //up
                    if (row == fromX - 1 && col == fromY)
                    {
                        return 3;
                    }
                    //down
                    if (row == fromX + 1 && col == fromY)
                    {
                        return 4;
                    }
                    //left
                    if (row == fromX && col == fromY - 1)
                    {
                        return 1;
                    }
                    //right
                    if (row == fromX && col == fromY + 1)
                    {
                        return 2;
                    }
                }
            }
        }
        return 0;
    }

    /// <summary>
    /// Internal function for that finds the shortest path using a technique
    /// similar to breadth-first search.
    /// It assigns a node no. to each node(2D array element) and applies the algorithm
    /// </summary>
    private enum Status
    { Ready, Waiting, Processed }
    private int[,] Search(int iStart, int iStop)
    {
        const int empty = 0;

        int iRows = m_iRows;
        int iCols = m_iCols;
        int iMax = iRows * iCols;
        int[] Queue = new int[iMax];
        int[] Origin = new int[iMax];
        int iFront = 0, iRear = 0;

        //check if starting and ending points are valid (open)
        if (GetNodeContents(m_iMaze, iStart) != empty || GetNodeContents(m_iMaze, iStop) != empty)
        {
            return null;
        }

        //create dummy array for storing status
        int[,] iMazeStatus = new int[iRows, iCols];
        //initially all nodes are ready
        for (int i = 0; i < iRows; i++)
            for (int j = 0; j < iCols; j++)
                iMazeStatus[i, j] = (int)Status.Ready;

        //add starting node to Q
        Queue[iRear] = iStart;
        Origin[iRear] = -1;
        iRear++;
        int iCurrent, iLeft, iRight, iTop, iDown, iRightUp, iRightDown, iLeftUp, iLeftDown;
        while (iFront != iRear)	// while Q not empty	
        {
            if (Queue[iFront] == iStop)		// maze is solved
                break;

            iCurrent = Queue[iFront];

            iLeft = iCurrent - 1;
            if (iLeft >= 0 && iLeft / iCols == iCurrent / iCols) 	//if left node exists
                if (GetNodeContents(m_iMaze, iLeft) == empty) 	//if left node is open(a path exists)
                    if (GetNodeContents(iMazeStatus, iLeft) == (int)Status.Ready)	//if left node is ready
                    {
                        Queue[iRear] = iLeft; //add to Q
                        Origin[iRear] = iCurrent;
                        ChangeNodeContents(iMazeStatus, iLeft, (int)Status.Waiting); //change status to waiting
                        iRear++;
                    }

            iRight = iCurrent + 1;
            if (iRight < iMax && iRight / iCols == iCurrent / iCols) 	//if right node exists
                if (GetNodeContents(m_iMaze, iRight) == empty) 	//if right node is open(a path exists)
                    if (GetNodeContents(iMazeStatus, iRight) == (int)Status.Ready)	//if right node is ready
                    {
                        Queue[iRear] = iRight; //add to Q
                        Origin[iRear] = iCurrent;
                        ChangeNodeContents(iMazeStatus, iRight, (int)Status.Waiting); //change status to waiting
                        iRear++;
                    }

            iTop = iCurrent - iCols;
            if (iTop >= 0) 	//if top node exists
                if (GetNodeContents(m_iMaze, iTop) == empty) 	//if top node is open(a path exists)
                    if (GetNodeContents(iMazeStatus, iTop) == (int)Status.Ready)	//if top node is ready
                    {
                        Queue[iRear] = iTop; //add to Q
                        Origin[iRear] = iCurrent;
                        ChangeNodeContents(iMazeStatus, iTop, (int)Status.Waiting); //change status to waiting
                        iRear++;
                    }

            iDown = iCurrent + iCols;
            if (iDown < iMax) 	//if bottom node exists
                if (GetNodeContents(m_iMaze, iDown) == empty) 	//if bottom node is open(a path exists)
                    if (GetNodeContents(iMazeStatus, iDown) == (int)Status.Ready)	//if bottom node is ready
                    {
                        Queue[iRear] = iDown; //add to Q
                        Origin[iRear] = iCurrent;
                        ChangeNodeContents(iMazeStatus, iDown, (int)Status.Waiting); //change status to waiting
                        iRear++;
                    }
            if (diagonal == true)
            {
                iRightDown = iCurrent + iCols + 1;
                if (iRightDown < iMax && iRightDown >= 0 && iRightDown / iCols == iCurrent / iCols + 1) 	//if bottom-right node exists
                    if (GetNodeContents(m_iMaze, iRightDown) == empty) 	//if this node is open(a path exists)
                        if (GetNodeContents(iMazeStatus, iRightDown) == (int)Status.Ready)	//if this node is ready
                        {
                            Queue[iRear] = iRightDown; //add to Q
                            Origin[iRear] = iCurrent;
                            ChangeNodeContents(iMazeStatus, iRightDown, (int)Status.Waiting); //change status to waiting
                            iRear++;
                        }

                iRightUp = iCurrent - iCols + 1;
                if (iRightUp >= 0 && iRightUp < iMax && iRightUp / iCols == iCurrent / iCols - 1) 	//if upper-right node exists
                    if (GetNodeContents(m_iMaze, iRightUp) == empty) 	//if this node is open(a path exists)
                        if (GetNodeContents(iMazeStatus, iRightUp) == (int)Status.Ready)	//if this node is ready
                        {
                            Queue[iRear] = iRightUp; //add to Q
                            Origin[iRear] = iCurrent;
                            ChangeNodeContents(iMazeStatus, iRightUp, (int)Status.Waiting); //change status to waiting
                            iRear++;
                        }

                iLeftDown = iCurrent + iCols - 1;
                if (iLeftDown < iMax && iLeftDown >= 0 && iLeftDown / iCols == iCurrent / iCols + 1) 	//if bottom-left node exists
                    if (GetNodeContents(m_iMaze, iLeftDown) == empty) 	//if this node is open(a path exists)
                        if (GetNodeContents(iMazeStatus, iLeftDown) == (int)Status.Ready)	//if this node is ready
                        {
                            Queue[iRear] = iLeftDown; //add to Q
                            Origin[iRear] = iCurrent;
                            ChangeNodeContents(iMazeStatus, iLeftDown, (int)Status.Waiting); //change status to waiting
                            iRear++;
                        }

                iLeftUp = iCurrent - iCols - 1;
                if (iLeftUp >= 0 && iLeftUp < iMax && iLeftUp / iCols == iCurrent / iCols - 1) 	//if upper-left node exists
                    if (GetNodeContents(m_iMaze, iLeftUp) == empty) 	//if this node is open(a path exists)
                        if (GetNodeContents(iMazeStatus, iLeftUp) == (int)Status.Ready)	//if this node is ready
                        {
                            Queue[iRear] = iLeftUp; //add to Q
                            Origin[iRear] = iCurrent;
                            ChangeNodeContents(iMazeStatus, iLeftUp, (int)Status.Waiting); //change status to waiting
                            iRear++;
                        }
            }


            //change status of current node to processed
            ChangeNodeContents(iMazeStatus, iCurrent, (int)Status.Processed);
            iFront++;

        }

        //create an array(maze) for solution
        int[,] iMazeSolved = new int[iRows, iCols];
        for (int i = 0; i < iRows; i++)
            for (int j = 0; j < iCols; j++)
                iMazeSolved[i, j] = m_iMaze[i, j];

        //make a path in the Solved Maze
        iCurrent = iStop;
        ChangeNodeContents(iMazeSolved, iCurrent, iPath);
        for (int i = iFront; i >= 0; i--)
        {
            if (Queue[i] == iCurrent)
            {
                iCurrent = Origin[i];
                if (iCurrent == -1)		// maze is solved
                    return (iMazeSolved);
                ChangeNodeContents(iMazeSolved, iCurrent, iPath);
            }
        }

        //no path exists
        return null;
    }
}