using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinesweeperMethod;

namespace MineSweeperTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Exempel1()
        {
            char[,] start = new char[,] { { 'M', 'E', 'E' }, { 'E', 'E', 'E' }, { 'E', 'M', 'E' } };
            char[,] after = new char[,] { { 'M', '1', '0' }, { 'E', '2', '1' }, { 'E', 'M', 'E' } };
            int col = 2;
            int row = 0;
            char[,] fromCall;

            fromCall = Game.PerformeMove(start, col, row);

            for (int i = 0; i < after.GetLength(1); i++)
            {
                for (int j = 0; j < after.GetLength(0); j++)
                {
                    Assert.AreEqual(after[j, i], fromCall[j, i],"Fel på postiton "+i+","+j);
                }
            }

        }

        [TestMethod]
        public void Test_ClickOnMine1()
        {
            char[,] start = new char[,] { { 'M', 'E', 'E' }, { 'E', 'E', 'E' }, { 'E', 'M', 'E' } };
            char[,] after = new char[,] { { 'X', 'E', 'E' }, { 'E', 'E', 'E' }, { 'E', 'M', 'E' } };
            int col = 0;
            int row = 0;
            char[,] fromCall;

            fromCall = Game.PerformeMove(start, col, row);

            for (int i = 0; i < after.GetLength(1); i++)
            {
                for (int j = 0; j < after.GetLength(0); j++)
                {
                    Assert.AreEqual(after[j, i], fromCall[j, i],"Fel på postiton " + i + "," + j);
                }
            }
        }
        [TestMethod]
        public void Test_ClickOnMine2()
        {
            char[,] start = new char[,] { { 'M', 'E', 'E' }, { 'E', 'E', 'E' }, { 'E', 'M', 'E' } };
            char[,] after = new char[,] { { 'M', 'E', 'E' }, { 'E', 'E', 'E' }, { 'E', 'X', 'E' } };
            int col = 1;
            int row = 2;
            char[,] fromCall;

            fromCall = Game.PerformeMove(start, col, row);

            for (int i = 0; i < after.GetLength(1); i++)
            {
                for (int j = 0; j < after.GetLength(0); j++)
                {
                    Assert.AreEqual(after[j, i], fromCall[j, i],"Fel på postiton " + i + "," + j);
                }
            }
        }
        [TestMethod]
        public void Exempel3()
        {
            char[,] start = new char[,] { { 'E', 'E', 'E','E', 'E' }, { 'E', 'E', 'M','E', 'E' }, { 'E', 'E', 'E', 'E', 'E' }, { 'E', 'E', 'E', 'E', 'E' } };
            char[,] after = new char[,] { { '0', '1', 'E', '1', '0' }, { '0', '1', 'M', '1', '0' }, { '0', '1', '1', '1', '0' } , { '0', '0', '0', '0', '0' } };
            int col = 0;
            int row = 3;
            char[,] fromCall;

            fromCall = Game.PerformeMove(start, col, row);

            for (int i = 0; i < after.GetLength(1); i++)
            {
                for (int j = 0; j < after.GetLength(0); j++)
                {
                    Assert.AreEqual(after[j, i], fromCall[j, i],"Fel på postiton " + i + "," + j);
                }
            }
        }

    }
}

