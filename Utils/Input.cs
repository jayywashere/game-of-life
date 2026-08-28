using System.Numerics;

namespace GameOfLife.Utils;

public readonly struct NumericRange<T> where T : INumber<T>
{
    public T Min { get; }
    public T Max { get; }

    public NumericRange(T min, T max)
    {
        if (min > max)
            throw new ArgumentException("Min value cannot be greater than Max value.");

        Min = min;
        Max = max;
    }

    public bool Contains(T value) => value >= Min && value <= Max;
}

public static class Scanner
{
    // * Overload 1: Standard input with NO LIMIT CONSTRAINTS
    public static T Next<T>() where T : INumber<T>
    {
        while (true)
        {
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (T.TryParse(input.Trim(), provider: null, out T? result))
                return result;

            Console.WriteLine($"Invalid input format. Expected a {typeof(T).Name}.");
        }
    }

    // * Overload 2: Standard input with LIMIT CONSTRAINTS
    public static T Next<T>(NumericRange<T> limits) where T : INumber<T>
    {
        while (true)
        {
            T value = Next<T>();

            if (limits.Contains(value))
                return value;

            Console.WriteLine($"Value is out of bounds; it must be between {limits.Min} and {limits.Max}.");
        }
    }
}