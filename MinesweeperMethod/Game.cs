using System;
using System.Linq;

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
            //number of neighbour mines
            int numberMines = 0;
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
                        numberMines++;
                    }

                }

                if (ItIsAMine(board, col - 1, row))
                {
                    numberMines++;
                }
                if (row < board.GetLength(0) - 1)
                {
                    if (ItIsAMine(board, col - 1, row + 1))
                    {
                        numberMines++;
                    }
                }
            }

            if (row > 0)
            {
                if (ItIsAMine(board, col, row - 1))
                {

                    numberMines++;
                }
            }

            if (row < board.GetLength(0) - 1)
            {
                if (ItIsAMine(board, col, row + 1))
                {
                    numberMines++;
                }
            }

            if (col < board.GetLength(1) - 1)
            {
                if (row > 0)
                {
                    if (ItIsAMine(board, col + 1, row - 1))

                        numberMines++;

                }
                if (ItIsAMine(board, col + 1, row))
                {
                    numberMines++;
                }
                if (row < board.GetLength(0) - 1)
                {
                    if (ItIsAMine(board, col + 1, row + 1))
                    {
                        numberMines++;
                    }
                }
            }

            board[row, col] = numberMines.ToString().ToCharArray().First();

            if (numberMines == 0)
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
