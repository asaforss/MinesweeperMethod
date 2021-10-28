using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperMethod
{
    public static class Game
    {
        private const int MaxChips = 1600;
        private static int openedChips;

        
        public static char[,] PerformeMove(char[,] board, int col, int row)
        {
            if (ItIsAMine(board, col, row))
            {
                board[row, col] = 'X';
                return board;
            }
            else 
                board = OpenChip(board, col, row);
            return board;
        }
        
        private static char[,] OpenChip(char[,] board, int col, int row)
        {
            int number = 0;
            openedChips++;
            if (openedChips >= MaxChips)
                return board;

            Console.WriteLine("OpenChip för postiton " + col + "," + row);

            if (col > 0)
            {
                if (row > 0)
                {
                    if (ItIsAMine(board, col - 1, row - 1))
                    {
                        number++;
                    }

                }

                if (ItIsAMine(board, col - 1, row))
                {
                    number++;
                }
                if (row < board.GetLength(0) - 1)
                {
                    if (ItIsAMine(board, col - 1, row + 1))
                    {
                        number++;
                    }
                }
            }

            if (row > 0)
            {
                if (ItIsAMine(board, col, row - 1))
                {

                    number++;
                }
            }

            if (row < board.GetLength(0) - 1)
            {
                if (ItIsAMine(board, col, row + 1))
                {
                    number++;
                }
            }

            if (col < board.GetLength(1) - 1)
            {
                if (row > 0)
                {
                    if (ItIsAMine(board, col + 1, row - 1))

                        number++;

                }
                if (ItIsAMine(board, col + 1, row))
                {
                    number++;
                }
                if (row < board.GetLength(0) - 1)
                {
                    if (ItIsAMine(board, col + 1, row + 1))
                    {
                        number++;
                    }
                }
            }

            board[row, col] = number.ToString().ToCharArray().First();

            if (number == 0)
            {
                if (col > 0)
                {
                    if (row > 0)
                    {
                        if (ItIsAnUnOpenedEChip(board, col - 1, row - 1))
                        {
                            board = OpenChip(board, col - 1, row - 1);
                        }
                    }
                    if (ItIsAnUnOpenedEChip(board, col - 1, row))
                    {
                        board = OpenChip(board, col - 1, row);
                    }
                    if (row < board.GetLength(0) - 1)
                    {
                        if (ItIsAnUnOpenedEChip(board, col - 1, row + 1))
                        {
                            board = OpenChip(board, col - 1, row + 1);
                        }
                    }
                }
                if (row > 0)
                {
                    if (ItIsAnUnOpenedEChip(board, col, row - 1))
                    {
                        board = OpenChip(board, col, row - 1);
                    }
                }

                if (row < board.GetLength(0) - 1)
                {
                    if (ItIsAnUnOpenedEChip(board, col, row + 1))
                    {
                        board = OpenChip(board, col, row + 1);
                    }
                }
                if (col < board.GetLength(1) - 1)
                {
                    if (row > 0)
                    {
                        if (ItIsAnUnOpenedEChip(board, col + 1, row - 1))
                        {
                            board = OpenChip(board, col + 1, row - 1);
                        }
                    }
                    if (ItIsAnUnOpenedEChip(board, col + 1, row))
                    {
                        board = OpenChip(board, col + 1, row);
                    }
                    if (row < board.GetLength(0) - 1)
                    {
                        if (ItIsAnUnOpenedEChip(board, col + 1, row + 1))
                        {
                            board = OpenChip(board, col + 1, row + 1);
                        }
                    }
                }

            }
            return board;
        }

        private static bool ItIsAMine(char[,] board, int col, int row)
        {
            char value = board[row, col];
            Console.WriteLine(value + " på position: " + col + "," + row);
            if (value == 'M')
            {
                Console.WriteLine("Det är en mina på position: " + col + "," + row);
                return true;
            }
            else
                return false;
        }

        private static bool ItIsAnUnOpenedEChip(char[,] board, int col, int row)
        {
            char value = board[row, col];
            if (value == 'E')
            {
                Console.WriteLine("Oöppnad bricka: " + col + "," + row);
                return true;
            }
            else
                return false;
        }
    }
}
