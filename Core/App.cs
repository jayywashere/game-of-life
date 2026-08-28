using GameOfLife.Common;
using GameOfLife.Utils;

namespace GameOfLife.Core;

public class App
{
    public void Run()
    {
        Console.WriteLine("=== GAME OF LIFE ===");

        Console.Write("Grid width: ");
        int width = Scanner.Next<int>();

        Console.Write("Grid height: ");
        int height = Scanner.Next<int>();

        Console.Write("Simulation interval (ms): ");
        int interval = Scanner.Next<int>();

        Console.Write("Generations: ");
        int generations = Scanner.Next<int>();

        List<Cell> cells = CreateRandomGrid(width, height);
        Game game = new(cells);

        for (int i = 0; i < generations; i++)
        {
            Renderer.Render(game);
            Thread.Sleep(interval);
            game.NextGeneration();
        }

        Renderer.Render(game);

        Console.WriteLine("\nSimulation complete.");
        Console.ReadKey(true);
    }

    private static List<Cell> CreateRandomGrid(int width, int height)
    {
        List<Cell> cells = [];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                cells.Add(new Cell(
                    x,
                    y,
                    Random.Shared.Next(0, 2) == 1
                ));
            }
        }

        return cells;
    }
}