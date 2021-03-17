using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro_UDTM.Components
{
    class Board
    {
        private int[,] board;

        #region Hàm dựng mặc định

        public Board()
        {
            board = new int[GameConstant.ROWS, GameConstant.COLS];
        }

        #endregion

        #region Hàm dựng sao chép mảng

        public Board(Board newBoard)
        {
            board = new int[GameConstant.ROWS, GameConstant.COLS];

            for (int i = 0; i < GameConstant.ROWS; ++i)
            {
                for (int j = 0; j < GameConstant.COLS; ++j)
                {
                    board[i, j] = newBoard.board[i, j];
                }
            }
        }

        #endregion

        #region Hàm thêm nước đi vào mảng số

        public void addMove(int i, int j, bool isX) 
        {
            board[i, j] = isX ? 2 : 1;
        }

        #endregion

        #region Hàm xóa nước đã đi

        public void clearMove(int i, int j)
        {
            board[i, j] = 0;
        }

        #endregion

        #region Hàm in bàn cờ

        public void printBoard()
        {
            Console.WriteLine("\n\n========= TRANG THAI BAN CO =========");
            for (int i = 0; i < GameConstant.ROWS; ++i)
            {
                for (int j = 0; j < GameConstant.COLS; ++j)
                {
                    Console.Write(board[i, j] + "  ");
                }

                Console.WriteLine();
            }
        }

        #endregion

        #region Hàm lấy bàn cờ

        public int[,] getBoard()
        {
            return board;
        }

        #endregion
    }
}
