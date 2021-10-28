using System;

namespace MinesweeperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] start = new char[,] { { 'E', 'E', 'E', 'E', 'E' }, { 'E', 'E', 'M', 'E', 'E' }, { 'E', 'E', 'E', 'E', 'E' }, { 'E', 'E', 'E', 'E', 'E' } };
           
            int col = 0;
            int row = 3;
            char[,] fromCall;


            fromCall = Game.PerformeMove(start, col, row);
            Console.WriteLine(fromCall[0,0]);
        }
    }
}
