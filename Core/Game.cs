using GameOfLife.Common;

namespace GameOfLife.Core;

public class Game
{
    public List<Cell> Cells { get; private set; }
    public int Generation { get; private set; }

    public Game(List<Cell> cells)
    {
        Cells = cells;
        Generation = 0;
    }

    public void NextGeneration()
    {
        Cells = Simulation.NextGeneration(Cells);
        Generation++;
    }
}