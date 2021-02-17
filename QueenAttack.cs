using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if (white.Column == black.Column || white.Row == black.Row)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static Queen Create(int row, int column)
    {
        if (row >= 0 && row < 8)
        {
            if (column >= 0 && column < 8)
            {
                return new Queen(row, column);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }

    }
}