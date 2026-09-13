# Game of Life

> a C# implementation of Conway's Game of Life because i wanted to make cells live, die, and reproduce in a terminal (am i cruel for this)

## About

basically, i made this as a small C# project to mess around with Conway's Game of Life and practice working with grids, loops, console output, and simulation logic

the program generates a random grid and then repeatedly applies the rules of Conway's Game of Life to create new generations

everything is displayed directly in the terminal, so there's no fancy graphics here. just little characters living their best lives

## Features

- randomly generated grids
- configurable grid size
- configurable simulation interval
- configurable generation count
- terminal-based visualization
- Conway's Game of Life rules

## Requirements

- .NET
- C#

## Installation

clone the repository:

```powershell
git clone https://github.com/jayywashere/game-of-life
cd game-of-life
```

then run it with:

```powershell
dotnet run
```

## Usage

```powershell
dotnet run
```

the program will generate a random grid and run the simulation for the configured number of generations.

## How It Works

each cell in the grid can either be alive or dead.

for every generation, the program checks the cells around each cell and applies the rules of Conway's Game of Life:

1. a live cell with fewer than two live neighbors dies
2. a live cell with two or three live neighbors survives
3. a live cell with more than three live neighbors dies
4. a dead cell with exactly three live neighbors becomes alive

the grid is then updated and the next generation is displayed.

## Current Scope

- terminal-based simulation
- random grid generation
- configurable grid dimensions
- configurable simulation interval
- configurable generation count
- standard Conway's Game of Life rules

more features may be added later. ......... ... . ?

## License

See [LICENSE](LICENSE).
