using GameOfLife.Common;

namespace GameOfLife.Core;

public class Simulation
{
    public static List<Cell> NextGeneration(List<Cell> cells)
    {
        List<Cell> next = [];

        foreach (Cell cell in cells)
        {
            int neighbors = CountNeighbors(cell, cells);

            bool alive = cell.IsAlive
                ? neighbors is 2 or 3
                : neighbors == 3;
            
            next.Add(new(cell.X, cell.Y, alive));
        }

        return next;
    }

    private static int CountNeighbors(Cell cell, List<Cell> cells)
    {
        int count = 0;

        foreach (Cell other in cells)
        {
            if (other == cell)
                continue;
            
            int dx = Math.Abs(other.X - cell.X);
            int dy = Math.Abs(other.Y - cell.Y);

            if (dx <= 1 && dy <= 1 && other.IsAlive)
                count++;
        }

        return count;
    }
}