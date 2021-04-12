using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caro_UDTM.Components;

namespace CaroLogicTest
{
    [TestClass]
    public class UnitTest1
    {
        #region Khu vực chức năng của bàn cờ

        [TestMethod]
        public void addMove_Test()
        {
            Board caroBoard = new Board();
            caroBoard.addMove(5, 2, true);

            Assert.IsTrue(caroBoard.getBoard()[5, 2] != 0);
        }

        [TestMethod]
        public void clearMove_Test()
        {
            Board caroBoard = new Board();
            caroBoard.addMove(5, 2, true);
            caroBoard.clearMove(5, 2);
            
            Assert.IsTrue(caroBoard.getBoard()[5, 2] == 0);
        }

        #endregion

        #region Khu vực tạo nước khả thi

        [TestMethod]
        public void generateMoves_OneMove()
        {
            Board caroBoard = new Board();
            caroBoard.addMove(5, 10, false);
            Assert.AreEqual(GameLogic.generateMoves(caroBoard).Count, 8, "Có 8 nước khả thi!");
        }

        [TestMethod]
        public void generateMoves_TwoMoveSeparate()
        {
            Board caroBoard = new Board();
            caroBoard.addMove(5, 10, false);
            caroBoard.addMove(10, 2, true);
            Assert.AreEqual(GameLogic.generateMoves(caroBoard).Count, 16, "Có 16 nước khả thi!"); 

        }

        [TestMethod]
        public void generateMoves_ThreeMoveAdjacent()
        {
            Board caroBoard = new Board();
            caroBoard.addMove(5, 10, false);
            caroBoard.addMove(6, 9, true);
            Assert.AreEqual(GameLogic.generateMoves(caroBoard).Count, 12, "Có 12 nước khả thi!");
        }

        #endregion

        #region Khu vực tìm nước đi chiến thắng

        [TestMethod]
        public void searchWinningMove_Horizontal()
        {
            Board caroBoard = new Board();

            for (int i = 0; i < 5; ++i)
            {
                caroBoard.addMove(5, i + 1, false);
            }

            Object[] move = GameLogic.searchWinningMove(caroBoard);
            string message = String.Format("Nước chiến thắng là: {0} - {1}", move[1], move[2]);

            Assert.IsNotNull(move, message);
        }

        [TestMethod]
        public void searchWinningMove_Vertical()
        {
            Board caroBoard = new Board();

            for (int i = 0; i < 5; ++i)
            {
                caroBoard.addMove(i + 1, 5, false);   
            }

            Object[] move = GameLogic.searchWinningMove(caroBoard);
            string message = String.Format("Nước chiến thắng là: {0} - {1}", move[1], move[2]);

            Assert.IsNotNull(move, message);
        }

        [TestMethod]
        public void searchWinningMove_Diagonal()
        {
            Board caroBoard = new Board();

            for (int i = 0; i < 5; ++i)
            {
                caroBoard.addMove(i + 1, i + 1, false);
            }

            Object[] move = GameLogic.searchWinningMove(caroBoard);
            string message = String.Format("Nước chiến thắng là: {0} - {1}", move[1], move[2]);

            Assert.IsNotNull(move, message);
        }

        #endregion

        #region Khu vực đánh giá ưu thế

        [TestMethod]
        public void evaluateBoardForO_OWin()
        {
            Board caroBoard = new Board();

            caroBoard.addMove(5, 2, false);
            caroBoard.addMove(5, 3, false);
            caroBoard.addMove(10, 1, true);

            Assert.IsTrue(GameLogic.evaluateBoardForO(caroBoard, false) >= 1);
        }

        [TestMethod]
        public void evaluateBoardForO_XWin()
        {
            Board caroBoard = new Board();

            caroBoard.addMove(5, 2, true);
            caroBoard.addMove(5, 3, true);
            caroBoard.addMove(10, 1, false);

            Assert.IsTrue(GameLogic.evaluateBoardForO(caroBoard, true) <= 1);
        }

        [TestMethod]
        public void evaluateBoardForO_XOEqual()
        {
            Board caroBoard = new Board();

            caroBoard.addMove(5, 2, true);
            caroBoard.addMove(5, 3, true);

            caroBoard.addMove(10, 1, false);
            caroBoard.addMove(10, 2, false);

            Assert.IsTrue(GameLogic.evaluateBoardForO(caroBoard, false) >= 1);
        }

        #endregion

        #region Khu vực tính điểm từng dòng

        [TestMethod]
        public void evaluateVertical_4MovesNoBlock()
        {
            Board caroBoard = new Board();

            for (int i = 0; i < 4; ++i)
            {
                caroBoard.addMove(i + 1, 2, false);
            }

            Assert.IsTrue(GameLogic.evaluateVertical(caroBoard, false, false) > 200000);
        }

        [TestMethod]
        public void evaluateVertical_4Moves1Block()
        {
            Board caroBoard = new Board();

            for (int i = 0; i < 4; ++i)
            {
                caroBoard.addMove(i + 1, 2, false);
            }

            caroBoard.addMove(6, 2, true);
            
            Assert.IsTrue(GameLogic.evaluateVertical(caroBoard, false, false) >= 200);
        }

        [TestMethod]
        public void evaluateHorizontal_2Block()
        {
            Board caroBoard = new Board();

            for (int i = 0; i < 4; ++i)
            {
                caroBoard.addMove(5, i + 1, false);
            }

            caroBoard.addMove(5, 0, true);
            caroBoard.addMove(5, 5, true);

            Assert.IsTrue(GameLogic.evaluateHorizontal(caroBoard, false, false) == 0);
        }

        [TestMethod]
        public void evaluateDiagonal_3MoveNoBlock()
        {
            Board caroBoard = new Board();

            for (int i = 0; i < 3; ++i)
            {
                caroBoard.addMove(i + 1, i + 1, false);
            }

            Assert.IsTrue(GameLogic.evaluateDiagonal(caroBoard, false, false) >= 50000);
        }

        #endregion

        #region Khu vực lấy điểm đánh giá

        [TestMethod]
        public void getScore_4MovesAllDirection()
        {
            Board caroBoard = new Board();

            for (int i = 0; i < 5; ++i)
            {
                caroBoard.addMove(i + 1, 5, false);
                caroBoard.addMove(2, i + 1, false);
                caroBoard.addMove(i + 1, i + 1, false);
            }

            Assert.IsTrue(GameLogic.getScore(caroBoard, false, false) >= 500000);
        }

        #endregion

        #region Khu vực test thuật toán

        [TestMethod]
        public void nextMove_Test1()
        {
            Board caroBoard = new Board();
            initTestCase1(caroBoard);

            int[] move = GameLogic.calculateNextMove(3, caroBoard);
            caroBoard.addMove(move[0], move[1], false);

            Assert.IsTrue(move[0] == 7 && move[1] == 9);
        }

        [TestMethod]
        public void nextMove_Test2()
        {
            Board caroBoard = new Board();
            initTestCase2(caroBoard);

            int[] move = GameLogic.calculateNextMove(3, caroBoard);
            caroBoard.addMove(move[0], move[1], false);

            Assert.IsTrue(move[0] == 12 && move[1] == 4);
        }

        [TestMethod]
        public void nextMove_Test3()
        {
            Board caroBoard = new Board();
            initTestCase3(caroBoard);

            int[] move = GameLogic.calculateNextMove(3, caroBoard);
            caroBoard.addMove(move[0], move[1], false);

            Assert.IsTrue(move[0] == 7 && move[1] == 8);
        }

        public void initTestCase1(Board caroBoard)
        {
            // Quân O đánh
            caroBoard.addMove(7, 7, false);
            caroBoard.addMove(6, 6, false);

            caroBoard.addMove(8, 5, false);
            caroBoard.addMove(7, 5, false);

            // Quân X đánh 
            caroBoard.addMove(8, 6, true);
            caroBoard.addMove(8, 8, true);

            caroBoard.addMove(9, 7, true);
            caroBoard.addMove(10, 6, true);

        }

        public void initTestCase2(Board caroBoard)
        {
            // Quân O đánh
            caroBoard.addMove(7, 7, false);
            caroBoard.addMove(6, 6, false);

            caroBoard.addMove(8, 5, false);
            caroBoard.addMove(7, 5, false);

            caroBoard.addMove(7, 9, false);

            // Quân X đánh 
            caroBoard.addMove(8, 6, true);
            caroBoard.addMove(8, 8, true);

            caroBoard.addMove(9, 7, true);
            caroBoard.addMove(10, 6, true);

            caroBoard.addMove(11, 5, true);
        }

        public void initTestCase3(Board caroBoard)
        {
            // Quân O đánh
            caroBoard.addMove(7, 7, false);
            caroBoard.addMove(6, 6, false);

            caroBoard.addMove(8, 5, false);
            caroBoard.addMove(7, 5, false);

            caroBoard.addMove(7, 9, false);
            caroBoard.addMove(12, 4, false);

            caroBoard.addMove(7, 6, false);

            // Quân X đánh 
            caroBoard.addMove(8, 6, true);
            caroBoard.addMove(8, 8, true);

            caroBoard.addMove(9, 7, true);
            caroBoard.addMove(10, 6, true);

            caroBoard.addMove(11, 5, true);
            caroBoard.addMove(9, 6, true);

            caroBoard.addMove(11, 6, true);
        }

        #endregion

    }
}
