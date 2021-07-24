using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_UDTM.Components
{
  public class GameLogic
  {
    #region Lấy toàn bộ những nước khả thi

    public static ArrayList generateMoves(Board caroBoard)
    {
      //List<int[]> posibleMoveList = new List<int[]>();
      ArrayList posibleMoveList = new ArrayList();
      int[,] board = caroBoard.getBoard();

      int n = GameConstant.ROWS;

      for (int i = 0; i < n; ++i)
      {
        for (int j = 0; j < n; ++j)
        {
          if (board[i, j] > 0) continue;

          if (i > 0)
          {
            if (j > 0)
            {
              if (board[i - 1, j - 1] > 0 || board[i, j - 1] > 0)
              {
                int[] move = { i, j };
                posibleMoveList.Add(move);
                continue;
              }
            }

            if (j < n - 1)
            {
              if (board[i - 1, j + 1] > 0 || board[i, j + 1] > 0)
              {
                int[] move = { i, j };
                posibleMoveList.Add(move);
                continue;
              }
            }


            if (board[i - 1, j] > 0)
            {
              int[] move = { i, j };
              posibleMoveList.Add(move);
              continue;
            }
          }

          if (i < n - 1)
          {
            if (j > 0)
            {
              if (board[i + 1, j - 1] > 0 || board[i, j - 1] > 0)
              {
                int[] move = { i, j };
                posibleMoveList.Add(move);
                continue;
              }
            }

            if (j < n - 1)
            {
              if (board[i + 1, j + 1] > 0 || board[i, j + 1] > 0)
              {
                int[] move = { i, j };
                posibleMoveList.Add(move);
                continue;
              }
            }

            if (board[i + 1, j] > 0)
            {
              int[] move = { i, j };
              posibleMoveList.Add(move);
              continue;
            }
          }

        }
      }


      //for (int i = 0; i < posibleMoveList.Count; ++i)
      //{
      //    Console.WriteLine(posibleMoveList[i][0] + " " + posibleMoveList[i][1]);
      //}


      return posibleMoveList;
    }

    #endregion

    #region Tìm nước đi tiếp theo

    public static int[] calculateNextMove(int depth, Board caroBoard)
    {
      //Console.WriteLine("DIFFICULTY: " + depth);

      int[] nextMove = new int[2];
      Object[] bestMove = searchWinningMove(caroBoard);

      if (bestMove != null)
      {
        nextMove[0] = (int)bestMove[1];
        nextMove[1] = (int)bestMove[2];
      }

      else
      {
        bestMove = minimax(depth, caroBoard, true, -1.0, GameConstant.WIN_SCORE);

        if (bestMove[1] == null) nextMove = null;
        else
        {
          nextMove[0] = (int)bestMove[1];
          nextMove[1] = (int)bestMove[2];
        }
      }

      //MessageBox.Show((depth.ToString()).ToString());

      return nextMove;
    }

    #endregion

    #region Minimax

    public static Object[] minimax(int depth, Board caroBoard, bool max, double alpha, double beta)
    {
      //List<int[]> posibleMoveList = generateMoves(caroBoard);

      if (depth == 0)
      {
        Object[] move = { evaluateBoardForO(caroBoard, !max), null, null };
        return move;
      }

      ArrayList posibleMoveList = generateMoves(caroBoard);

      if (posibleMoveList.Count == 0)
      {
        Object[] move = { evaluateBoardForO(caroBoard, !max), null, null };
        return move;
      }

      Object[] bestMove = new Object[3];

      if (max)
      {
        bestMove[0] = -1.0;

        foreach (int[] move in posibleMoveList)
        {
          //Board caroBoard = new Board(caroBoard);

          caroBoard.addMove(move[0], move[1], false);

          Object[] tempMove = minimax(depth - 1, caroBoard, !max, alpha, beta);

          caroBoard.clearMove(move[0], move[1]);

          if ((Double)(tempMove[0]) > alpha)
          {
            alpha = (Double)(tempMove[0]);
          }

          if ((Double)(tempMove[0]) >= beta)
          {
            return tempMove;
          }

          if ((Double)tempMove[0] > (Double)bestMove[0])
          {
            bestMove = tempMove;
            bestMove[1] = move[0];
            bestMove[2] = move[1];
          }
        }
      }
      else
      {
        bestMove[0] = 100000000.0;
        //bestMove[1] = posibleMoveList[0][0];
        //bestMove[2] = posibleMoveList[0][1];
        //bestMove[1] = (int[,])posibleMoveList[0][0];

        foreach (int[] move in posibleMoveList)
        {
          //Board caroBoard = new Board(caroBoard);

          caroBoard.addMove(move[0], move[1], true);

          Object[] tempMove = minimax(depth - 1, caroBoard, !max, alpha, beta);

          caroBoard.clearMove(move[0], move[1]);

          if (((Double)tempMove[0]) < beta)
          {
            beta = (Double)(tempMove[0]);
          }

          if ((Double)(tempMove[0]) <= alpha)
          {
            return tempMove;
          }

          if ((Double)tempMove[0] < (Double)bestMove[0])
          {
            bestMove = tempMove;
            bestMove[1] = move[0];
            bestMove[2] = move[1];
          }
        }
      }

      return bestMove;
    }

    #endregion

    #region Đánh giá quân O

    public static double evaluateBoardForO(Board caroBoard, bool isXTurn)
    {
      double xScore = getScore(caroBoard, true, isXTurn);
      double oScore = getScore(caroBoard, false, isXTurn);

      if (xScore == 0) xScore = 1.0;

      //MessageBox.Show(isXTurn.ToString() + " " + xScore.ToString() + " " + oScore.ToString() + " " + (oScore / xScore).ToString());
      //MessageBox.Show(isXTurn.ToString());
      return oScore / xScore;
    }

    #endregion

    #region Tìm kiếm nước đi chắc chắn thắng

    public static Object[] searchWinningMove(Board caroBoard)
    {
      //List<int[]> posibleMoveList = generateMoves(caroBoard);
      ArrayList posibleMoveList = generateMoves(caroBoard);
      Object[] winningMove = new Object[3];

      foreach (int[] move in posibleMoveList)
      {
        //Board dummyBoard = new Board(caroBoard);

        caroBoard.addMove(move[0], move[1], false);
        //Console.WriteLine(getScore(caroBoard, false, true));

        if (getScore(caroBoard, false, false) >= GameConstant.WIN_SCORE)
        {
          winningMove[1] = move[0];
          winningMove[2] = move[1];
          caroBoard.clearMove(move[0], move[1]);

          return winningMove;
        }

        caroBoard.clearMove(move[0], move[1]);
      }

      return null;
    }

    #endregion

    #region Lấy kết quả đánh giá

    public static int getScore(Board caroBoard, bool isX, bool isXTurn)
    {
      int horizontalScore = evaluateHorizontal(caroBoard, isX, isXTurn);
      //Console.WriteLine("DIEM HANG NGANG NE: " + horizontalScore);

      int verticalScore = evaluateVertical(caroBoard, isX, isXTurn);
      //Console.WriteLine("DIEM HANG DOC NE: " + verticalScore);

      int diagonalScore = evaluateDiagonal(caroBoard, isX, isXTurn);
      //Console.WriteLine("DIEM HANG CHEO NE: " + diagonalScore);

      //Console.WriteLine((horizontalScore + verticalScore + diagonalScore).ToString());

      return horizontalScore + verticalScore + diagonalScore;
    }

    #endregion

    #region Đánh giá hàng ngang

    public static int evaluateHorizontal(Board caroBoard, bool isX, bool playerTurn)
    {
      int[,] board = caroBoard.getBoard();
      int consecutive = 0;

      int block = 2;
      int score = 0;

      for (int i = 0; i < GameConstant.ROWS; ++i)
      {
        for (int j = 0; j < GameConstant.COLS; ++j)
        {
          if (board[i, j] == (isX ? 2 : 1)) consecutive++;

          else if (board[i, j] == 0)
          {
            if (consecutive > 0)
            {
              block--;
              score += getConsecutiveSetScore(consecutive, block, isX == playerTurn);

              consecutive = 0;
              block = 1;
            }
            else
            {
              block = 1;
            }
          }
          else if (consecutive > 0)
          {
            score += getConsecutiveSetScore(consecutive, block, isX == playerTurn);
            consecutive = 0;
            block = 2;
          }
          else
          {
            block = 2;
          }
        }

        if (consecutive > 0)
        {
          score += getConsecutiveSetScore(consecutive, block, isX == playerTurn);
        }

        consecutive = 0;
        block = 2;
      }

      return score;
    }

    #endregion

    #region Đánh giá hàng dọc

    public static int evaluateVertical(Board caroBoard, bool isX, bool playerTurn)
    {
      int[,] board = caroBoard.getBoard();
      int consecutive = 0;
      int blocks = 2;
      int score = 0;

      for (int j = 0; j < GameConstant.COLS; ++j)
      {
        for (int i = 0; i < GameConstant.ROWS; ++i)
        {
          if (board[i, j] == (isX ? 2 : 1)) consecutive++;

          else if (board[i, j] == 0)
          {
            if (consecutive > 0)
            {
              blocks--;
              score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);
              consecutive = 0;
              blocks = 1;
            }
            else
            {
              blocks = 1;
            }
          }
          else if (consecutive > 0)
          {
            score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);
            consecutive = 0;
            blocks = 2;
          }
          else
          {
            blocks = 2;
          }
        }
        if (consecutive > 0)
        {
          score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);
        }

        consecutive = 0;
        blocks = 2;

      }

      return score;
    }

    #endregion

    #region Đánh giá hàng chéo

    public static int evaluateDiagonal(Board caroBoard, bool isX, bool playerTurn)
    {
      int[,] board = caroBoard.getBoard();
      int consecutive = 0;
      int blocks = 2;
      int score = 0;
      // From bottom-left to top-right diagonally
      for (int k = 0; k <= 2 * (GameConstant.ROWS - 1); k++)
      {
        int iStart = Math.Max(0, k - GameConstant.ROWS + 1);
        int iEnd = Math.Min(GameConstant.ROWS - 1, k);

        for (int i = iStart; i <= iEnd; ++i)
        {
          int j = k - i;

          if (board[i, j] == (isX ? 2 : 1))
          {
            consecutive++;
          }
          else if (board[i, j] == 0)
          {
            if (consecutive > 0)
            {
              blocks--;
              score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);
              consecutive = 0;
              blocks = 1;
            }
            else
            {
              blocks = 1;
            }
          }
          else if (consecutive > 0)
          {
            score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);
            consecutive = 0;
            blocks = 2;
          }
          else
          {
            blocks = 2;
          }

        }

        if (consecutive > 0)
        {
          score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);
        }
        consecutive = 0;
        blocks = 2;
      }
      // From top-left to bottom-right diagonally
      for (int k = 1 - GameConstant.ROWS; k < GameConstant.ROWS; k++)
      {
        int iStart = Math.Max(0, k);
        int iEnd = Math.Min(GameConstant.ROWS + k - 1, GameConstant.ROWS - 1);

        for (int i = iStart; i <= iEnd; ++i)
        {
          int j = i - k;

          if (board[i, j] == (isX ? 2 : 1))
          {
            consecutive++;
          }
          else if (board[i, j] == 0)
          {
            if (consecutive > 0)
            {
              blocks--;
              score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);
              consecutive = 0;
              blocks = 1;
            }
            else
            {
              blocks = 1;
            }
          }
          else if (consecutive > 0)
          {
            score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);
            consecutive = 0;
            blocks = 2;
          }
          else
          {
            blocks = 2;
          }

        }
        if (consecutive > 0)
        {
          score += getConsecutiveSetScore(consecutive, blocks, isX == playerTurn);

        }
        consecutive = 0;
        blocks = 2;
      }

      return score;
    }

    #endregion

    #region Tính điểm

    public static int getConsecutiveSetScore(int consecutive, int block, bool currentTurn)
    {
      const int winGuarantee = 1000000;

      if (block == 2 && consecutive < 5) return 0;

      switch (consecutive)
      {
        case 5:
          //if (block < 2 ) return GameConstant.WIN_SCORE;
          //else
          //{
          //    if (currentTurn) return 10;
          //    else return 5;
          //}
          return GameConstant.WIN_SCORE;

        case 4:
          if (currentTurn) return winGuarantee;

          else
          {
            if (block == 0) return winGuarantee / 4;

            else return 200;
          }

        case 3:
          if (block == 0)
          {
            if (currentTurn) return 50000;

            else return 200;
          }
          else
          {
            if (currentTurn) return 10;
            else return 5;
          }

        case 2:
          if (block == 0)
          {
            if (currentTurn) return 7;
            else return 5;
          }

          else return 3;

        case 1:
          return 1;
      }

      return 0;
    }

    #endregion
  }
}
