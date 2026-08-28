using GameOfLife.Common;

namespace GameOfLife.Core;

public static class Renderer
{
    public static void Render(Game game)
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"Generation: {game.Generation}");

        int maxX = game.Cells.Max(c => c.X);
        int maxY = game.Cells.Max(c => c.Y);

        for (int y = 0; y < maxY; y++)
        {
            for (int x = 0; x < maxX; x++)
            {
                Cell cell = game.Cells.First(c => c.X == x && c.Y == y);
                Console.Write(cell.IsAlive ? "█" : ".");
            }

            Console.WriteLine();
        }
    }
}