using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro_UDTM.Components
{
    class Board
    {
        public int[,] board;

        public Board()
        {
            board = new int[GameConstant.ROWS, GameConstant.COLS];
        }

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

        public void addMove(int i, int j, bool isX) 
        {
            board[i, j] = isX ? 2 : 1;
        }
    }
}
