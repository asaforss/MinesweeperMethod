using System;

namespace MinesweeperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] start = new char[,] { { 'E', 'E', 'E', 'E', 'E' }, { 'E', 'E', 'M', 'E', 'E' }, { 'E', 'E', 'E', 'E', 'E' }, { 'E', 'E', 'E', 'E', 'E' } };
            char[,] after = new char[,] { { '0', '1', 'E', '1', '0' }, { '0', '1', 'M', '1', '0' }, { '0', '1', '1', '1', '0' }, { '0', '0', '0', '0', '0' } };
            int col = 0;
            int row = 3;
            char[,] fromCall;


            fromCall = Game.PerformeMove(start, col, row);
            Console.WriteLine(fromCall[0,0]);
        }
    }
}
