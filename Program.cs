using System;
using MineSweeper;

class Program
{
    static void Main(string[] args)
    {
        MineSweeper.MineSweeper mineSweeper = new MineSweeper.MineSweeper(args);
        mineSweeper.Run();
    }
}

