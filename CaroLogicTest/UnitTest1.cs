using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caro_UDTM.Components;
using System.Threading;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White;
using TestStack.White.UIItems.ListBoxItems;
using System.Linq;

namespace CaroLogicTest
{
  //[TestClass]
  //public class UnitTest1
  //{
  //  #region Khu vực chức năng của bàn cờ

  //  [TestMethod]
  //  public void addMove_Test()
  //  {
  //    Board caroBoard = new Board();
  //    caroBoard.addMove(5, 2, true);

  //    Assert.IsTrue(caroBoard.getBoard()[5, 2] != 0);
  //  }

  //  [TestMethod]
  //  public void clearMove_Test()
  //  {
  //    Board caroBoard = new Board();
  //    caroBoard.addMove(5, 2, true);
  //    caroBoard.clearMove(5, 2);

  //    Assert.IsTrue(caroBoard.getBoard()[5, 2] == 0);
  //  }

  //  #endregion

  //  #region Khu vực tạo nước khả thi

  //  [TestMethod]
  //  public void generateMoves_OneMove()
  //  {
  //    Board caroBoard = new Board();
  //    caroBoard.addMove(5, 10, false);
  //    Assert.AreEqual(GameLogic.generateMoves(caroBoard).Count, 8, "Có 8 nước khả thi!");
  //  }

  //  [TestMethod]
  //  public void generateMoves_TwoMoveSeparate()
  //  {
  //    Board caroBoard = new Board();
  //    caroBoard.addMove(5, 10, false);
  //    caroBoard.addMove(10, 2, true);
  //    Assert.AreEqual(GameLogic.generateMoves(caroBoard).Count, 16, "Có 16 nước khả thi!");

  //  }

  //  [TestMethod]
  //  public void generateMoves_ThreeMoveAdjacent()
  //  {
  //    Board caroBoard = new Board();
  //    caroBoard.addMove(5, 10, false);
  //    caroBoard.addMove(6, 9, true);
  //    Assert.AreEqual(GameLogic.generateMoves(caroBoard).Count, 12, "Có 12 nước khả thi!");
  //  }

  //  #endregion

  //  #region Khu vực tìm nước đi chiến thắng

  //  [TestMethod]
  //  public void searchWinningMove_Horizontal()
  //  {
  //    Board caroBoard = new Board();

  //    for (int i = 0; i < 5; ++i)
  //    {
  //      caroBoard.addMove(5, i + 1, false);
  //    }

  //    Object[] move = GameLogic.searchWinningMove(caroBoard);
  //    string message = String.Format("Nước chiến thắng là: {0} - {1}", move[1], move[2]);

  //    Assert.IsNotNull(move, message);
  //  }

  //  [TestMethod]
  //  public void searchWinningMove_Vertical()
  //  {
  //    Board caroBoard = new Board();

  //    for (int i = 0; i < 5; ++i)
  //    {
  //      caroBoard.addMove(i + 1, 5, false);
  //    }

  //    Object[] move = GameLogic.searchWinningMove(caroBoard);
  //    string message = String.Format("Nước chiến thắng là: {0} - {1}", move[1], move[2]);

  //    Assert.IsNotNull(move, message);
  //  }

  //  [TestMethod]
  //  public void searchWinningMove_Diagonal()
  //  {
  //    Board caroBoard = new Board();

  //    for (int i = 0; i < 5; ++i)
  //    {
  //      caroBoard.addMove(i + 1, i + 1, false);
  //    }

  //    Object[] move = GameLogic.searchWinningMove(caroBoard);
  //    string message = String.Format("Nước chiến thắng là: {0} - {1}", move[1], move[2]);

  //    Assert.IsNotNull(move, message);
  //  }

  //  #endregion

  //  #region Khu vực đánh giá ưu thế

  //  [TestMethod]
  //  public void evaluateBoardForO_OWin()
  //  {
  //    Board caroBoard = new Board();

  //    caroBoard.addMove(5, 2, false);
  //    caroBoard.addMove(5, 3, false);
  //    caroBoard.addMove(10, 1, true);

  //    Assert.IsTrue(GameLogic.evaluateBoardForO(caroBoard, false) >= 1);
  //  }

  //  [TestMethod]
  //  public void evaluateBoardForO_XWin()
  //  {
  //    Board caroBoard = new Board();

  //    caroBoard.addMove(5, 2, true);
  //    caroBoard.addMove(5, 3, true);
  //    caroBoard.addMove(10, 1, false);

  //    Assert.IsTrue(GameLogic.evaluateBoardForO(caroBoard, true) <= 1);
  //  }

  //  [TestMethod]
  //  public void evaluateBoardForO_XOEqual()
  //  {
  //    Board caroBoard = new Board();

  //    caroBoard.addMove(5, 2, true);
  //    caroBoard.addMove(5, 3, true);

  //    caroBoard.addMove(10, 1, false);
  //    caroBoard.addMove(10, 2, false);

  //    Assert.IsTrue(GameLogic.evaluateBoardForO(caroBoard, false) >= 1);
  //  }

  //  #endregion

  //  #region Khu vực tính điểm từng dòng

  //  [TestMethod]
  //  public void evaluateVertical_4MovesNoBlock()
  //  {
  //    Board caroBoard = new Board();

  //    for (int i = 0; i < 4; ++i)
  //    {
  //      caroBoard.addMove(i + 1, 2, false);
  //    }

  //    Assert.IsTrue(GameLogic.evaluateVertical(caroBoard, false, false) > 200000);
  //  }

  //  [TestMethod]
  //  public void evaluateVertical_4Moves1Block()
  //  {
  //    Board caroBoard = new Board();

  //    for (int i = 0; i < 4; ++i)
  //    {
  //      caroBoard.addMove(i + 1, 2, false);
  //    }

  //    caroBoard.addMove(6, 2, true);

  //    Assert.IsTrue(GameLogic.evaluateVertical(caroBoard, false, false) >= 200);
  //  }

  //  [TestMethod]
  //  public void evaluateHorizontal_2Block()
  //  {
  //    Board caroBoard = new Board();

  //    for (int i = 0; i < 4; ++i)
  //    {
  //      caroBoard.addMove(5, i + 1, false);
  //    }

  //    caroBoard.addMove(5, 0, true);
  //    caroBoard.addMove(5, 5, true);

  //    Assert.IsTrue(GameLogic.evaluateHorizontal(caroBoard, false, false) == 0);
  //  }

  //  [TestMethod]
  //  public void evaluateDiagonal_3MoveNoBlock()
  //  {
  //    Board caroBoard = new Board();

  //    for (int i = 0; i < 3; ++i)
  //    {
  //      caroBoard.addMove(i + 1, i + 1, false);
  //    }

  //    Assert.IsTrue(GameLogic.evaluateDiagonal(caroBoard, false, false) >= 50000);
  //  }

  //  #endregion

  //  #region Khu vực lấy điểm đánh giá

  //  [TestMethod]
  //  public void getScore_4MovesAllDirection()
  //  {
  //    Board caroBoard = new Board();

  //    for (int i = 0; i < 5; ++i)
  //    {
  //      caroBoard.addMove(i + 1, 5, false);
  //      caroBoard.addMove(2, i + 1, false);
  //      caroBoard.addMove(i + 1, i + 1, false);
  //    }

  //    Assert.IsTrue(GameLogic.getScore(caroBoard, false, false) >= 500000);
  //  }

  //  #endregion

  //  #region Khu vực test thuật toán

   

  //  [TestMethod]
  //  public void nextMove_Test2()
  //  {
  //    Board caroBoard = new Board();
  //    initTestCase2(caroBoard);

  //    int[] move = GameLogic.calculateNextMove(3, caroBoard);
  //    caroBoard.addMove(move[0], move[1], false);

  //    Assert.IsTrue(move[0] == 12 && move[1] == 4);
  //  }

  //  [TestMethod]
  //  public void nextMove_Test3()
  //  {
  //    Board caroBoard = new Board();
  //    initTestCase3(caroBoard);

  //    int[] move = GameLogic.calculateNextMove(3, caroBoard);
  //    caroBoard.addMove(move[0], move[1], false);

  //    Assert.IsTrue(move[0] == 7 && move[1] == 8);
  //  }

  //  public void initTestCase2(Board caroBoard)
  //  {
  //    // Quân O đánh
  //    caroBoard.addMove(7, 7, false);
  //    caroBoard.addMove(6, 6, false);

  //    caroBoard.addMove(8, 5, false);
  //    caroBoard.addMove(7, 5, false);

  //    caroBoard.addMove(7, 9, false);

  //    // Quân X đánh 
  //    caroBoard.addMove(8, 6, true);
  //    caroBoard.addMove(8, 8, true);

  //    caroBoard.addMove(9, 7, true);
  //    caroBoard.addMove(10, 6, true);

  //    caroBoard.addMove(11, 5, true);
  //  }

  //  public void initTestCase3(Board caroBoard)
  //  {
  //    // Quân O đánh
  //    caroBoard.addMove(7, 7, false);
  //    caroBoard.addMove(6, 6, false);

  //    caroBoard.addMove(8, 5, false);
  //    caroBoard.addMove(7, 5, false);

  //    caroBoard.addMove(7, 9, false);
  //    caroBoard.addMove(12, 4, false);

  //    caroBoard.addMove(7, 6, false);

  //    // Quân X đánh 
  //    caroBoard.addMove(8, 6, true);
  //    caroBoard.addMove(8, 8, true);

  //    caroBoard.addMove(9, 7, true);
  //    caroBoard.addMove(10, 6, true);

  //    caroBoard.addMove(11, 5, true);
  //    caroBoard.addMove(9, 6, true);

  //    caroBoard.addMove(11, 6, true);
  //  }

  //  #endregion

  //}

  [TestClass]
  public class UITest
  {
    private string filePath = @"C:\Users\Admin\Desktop\Caro_UDTM\Caro_UDTM\bin\Debug\CARO_UDTM.exe";
    private int endTime = 700;

    #region Khu vực test menu logic

    [TestMethod]
    public void startButtonTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startBtn = windows.Get<Button>(SearchCriteria.ByText("START"));
      startBtn.Click();

      Assert.AreEqual(startBtn.Text, "BACK");

      Thread.Sleep(endTime);

      application.Close();
    }

    [TestMethod]
    public void exitButtonTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(2000);

      var exitBtn = windows.Get<Button>(SearchCriteria.ByText("EXIT"));
      exitBtn.Click();

      var kq = windows.IsClosed;

      Assert.AreEqual(kq, true);

      Thread.Sleep(endTime);

      application.Close();
    }

    [TestMethod]
    public void helpButtonTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var helpBtn = windows.Get<Button>(SearchCriteria.ByText("HELP"));
      helpBtn.Click();

      var helpWindows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      var nextBtn = helpWindows.Get<Button>(SearchCriteria.ByAutomationId("nextBtn"));

      for (int i = 0; i < 4; ++i)
      {
        nextBtn.Click();
        Thread.Sleep(700);
      }

      var prevBtn = helpWindows.Get<Button>(SearchCriteria.ByAutomationId("previousBtn"));

      for (int i = 0; i < 4; ++i)
      {
        prevBtn.Click();
        Thread.Sleep(700);
      }

      var letGoBtn = helpWindows.Get<Button>(SearchCriteria.ByAutomationId("startGameBtn"));
      letGoBtn.Click();

      var kq = helpWindows.IsClosed;

      Assert.AreEqual(kq, true);

      Thread.Sleep(endTime);

      application.Close();
    }

    #endregion

    #region Khu vực test ràng buộc

    [TestMethod]
    public void nameTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var onePlayerButton = windows.Get<Button>(SearchCriteria.ByText("1 PLAYER"));
      onePlayerButton.Click();

      Thread.Sleep(700);

      var playerFirstButton = windows.Get<Button>(SearchCriteria.ByText("PLAYER FIRST"));
      playerFirstButton.Click();

      Thread.Sleep(700);

      var nameInput = windows.Get<TextBox>(SearchCriteria.ByAutomationId("nameInputTxt"));
      nameInput.Text = "NGUYEN @@@@@@";

      Thread.Sleep(2000);

      nameInput.Text = "NGUYEN 123123123";

      Thread.Sleep(2000);

      nameInput.Text = "++++++++ NGUYEN ///////////";

      Thread.Sleep(2000);

      string nameTest = "NGUYEN ";
      Assert.AreEqual(nameInput.Text, nameTest);

      Thread.Sleep(2000);

      application.Close();
    }

    [TestMethod]
    public void onePlayerNameTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var onePlayerButton = windows.Get<Button>(SearchCriteria.ByText("1 PLAYER"));
      onePlayerButton.Click();

      Thread.Sleep(700);

      var playerFirstButton = windows.Get<Button>(SearchCriteria.ByText("PLAYER FIRST"));
      playerFirstButton.Click();

      Thread.Sleep(700);

      var nameInput = windows.Get<TextBox>(SearchCriteria.ByAutomationId("nameInputTxt"));
      nameInput.Text = "NGUYEN VAN B";

      Thread.Sleep(700);

      var playButton = windows.Get<Button>(SearchCriteria.ByText("OK"));
      playButton.Click();

      var mainForm = application.GetWindow("GAME CARO", InitializeOption.NoCache);
      var playerOneNameTxt = mainForm.Get<Label>(SearchCriteria.ByAutomationId("playerOneNameTxt"));

      string nameTest = "NGUYEN VAN B";
      Assert.AreEqual(playerOneNameTxt.Text, nameTest);

      Thread.Sleep(2000);

      application.Close();
    }

    [TestMethod]
    public void twolayerNameTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var twoPlayerButton = windows.Get<Button>(SearchCriteria.ByText("2 PLAYERS"));
      twoPlayerButton.Click();

      Thread.Sleep(700);

      var playerOneNameInput = windows.Get<TextBox>(SearchCriteria.ByAutomationId("playerOneNameTxt"));
      playerOneNameInput.Text = "NGUYEN VAN B";

      Thread.Sleep(700);

      var playerTwoNameInput = windows.Get<TextBox>(SearchCriteria.ByAutomationId("playerTwoNameTxt"));
      playerTwoNameInput.Text = "NGUYEN VAN C";

      Thread.Sleep(700);

      var playButton = windows.Get<Button>(SearchCriteria.ByText("OK"));
      playButton.Click();

      var mainForm = application.GetWindow("GAME CARO", InitializeOption.NoCache);
      var playerOneNameTxt = mainForm.Get<Label>(SearchCriteria.ByAutomationId("playerOneNameTxt"));
      var playerTwoNameTxt = mainForm.Get<Label>(SearchCriteria.ByAutomationId("playerTwoNameTxt"));

      string nameOneTest = "NGUYEN VAN B";
      string nameTwoTest = "NGUYEN VAN C";

      Assert.AreEqual(playerOneNameTxt.Text, nameOneTest);
      Assert.AreEqual(playerTwoNameTxt.Text, nameTwoTest);

      Thread.Sleep(2000);

      application.Close();
    }

    [TestMethod]
    public void lanIPTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var lanButton = windows.Get<Button>(SearchCriteria.ByText("MULTIPLAYER"));
      lanButton.Click();

      Thread.Sleep(700);

      var ipAddress = windows.Get<TextBox>(SearchCriteria.ByAutomationId("ipTxt"));

      Assert.AreNotEqual(ipAddress.Text, "");

      Thread.Sleep(endTime);

      application.Close();
    }

    #endregion

    #region Khu vực test Game logic

    [TestMethod]
    public void renderBoardTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var onePlayerButton = windows.Get<Button>(SearchCriteria.ByText("1 PLAYER"));
      onePlayerButton.Click();

      Thread.Sleep(700);

      var playerFirstButton = windows.Get<Button>(SearchCriteria.ByText("PLAYER FIRST"));
      playerFirstButton.Click();

      Thread.Sleep(700);

      var playButton = windows.Get<Button>(SearchCriteria.ByText("OK"));
      playButton.Click();

      var mainForm = application.GetWindow("GAME CARO", InitializeOption.NoCache);
      var mainTablePanel = mainForm.Get<Panel>(SearchCriteria.ByAutomationId("mainTablePanel"));

      var chessBoardLayout = mainForm.Get<Panel>(SearchCriteria.Indexed(1));

      Assert.AreEqual(chessBoardLayout.Items.Count, GameConstant.ROWS * GameConstant.COLS);

      application.Close();
    }

    [TestMethod]
    public void playerMove()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var onePlayerButton = windows.Get<Button>(SearchCriteria.ByText("1 PLAYER"));
      onePlayerButton.Click();

      Thread.Sleep(700);

      var playerFirstButton = windows.Get<Button>(SearchCriteria.ByText("PLAYER FIRST"));
      playerFirstButton.Click();

      Thread.Sleep(700);

      var playButton = windows.Get<Button>(SearchCriteria.ByText("OK"));
      playButton.Click();

      var mainForm = application.GetWindow("GAME CARO", InitializeOption.NoCache);
      var mainTablePanel = mainForm.Get<Panel>(SearchCriteria.ByAutomationId("mainTablePanel"));

      var chessBoardLayout = mainForm.Get<Panel>(SearchCriteria.Indexed(1));

      var chess = chessBoardLayout.Get<Button>(SearchCriteria.Indexed(50));
      chess.Click();

      Assert.AreEqual(chess.VisibleImage.RawFormat, GameConstant.X_IMG.RawFormat);

      Thread.Sleep(endTime);

      application.Close();
    }

    [TestMethod]
    public void winnerTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);
    
      var twoPlayerButton = windows.Get<Button>(SearchCriteria.ByText("2 PLAYERS"));
      twoPlayerButton.Click();

      Thread.Sleep(700);

      var playButton = windows.Get<Button>(SearchCriteria.ByText("OK"));
      playButton.Click();

      var mainForm = application.GetWindow("GAME CARO", InitializeOption.NoCache);
      var chessBoardLayout = mainForm.Get<Panel>(SearchCriteria.Indexed(1));

      initWinnerTestCase(chessBoardLayout);

      var dialog = mainForm.ModalWindow("WINNER", InitializeOption.NoCache);
      var closeBtn = dialog.Get<Button>(SearchCriteria.ByText("Cancel"));

      Assert.AreNotEqual(dialog, null);

      Thread.Sleep(1500);

      closeBtn.Click();
      Assert.AreEqual(dialog.IsClosed, true);

      Thread.Sleep(endTime);

      application.Close();
    }

    private void initWinnerTestCase(Panel chessBoardLayout)
    {
      IUIItem[] btns = chessBoardLayout.GetMultiple(SearchCriteria.All).OfType<Button>().ToArray();
      int j = 0;
      int k = 0;

      for (int i = 0; i < 9; ++i)
      {
        if (i % 2 == 0)
        {
          btns[110 + j++].Click();
          Thread.Sleep(500);
          continue;
        }

        btns[120 + k++].Click();
        Thread.Sleep(500);
      }
    }

    [TestMethod]
    public void undoTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      Thread.Sleep(700);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var twoPlayerButton = windows.Get<Button>(SearchCriteria.ByText("2 PLAYERS"));
      twoPlayerButton.Click();

      Thread.Sleep(700);

      var playButton = windows.Get<Button>(SearchCriteria.ByText("OK"));
      playButton.Click();

      var mainForm = application.GetWindow("GAME CARO", InitializeOption.NoCache);
      var chessBoardLayout = mainForm.Get<Panel>(SearchCriteria.Indexed(1));

      initUndoCase(chessBoardLayout);

      var leftPanel = mainForm.Get<Panel>(SearchCriteria.Indexed(0));
      var undoBtn = leftPanel.Get<Button>(SearchCriteria.ByText("UNDO"));

      for (int i = 0; i < 3; ++i)
      {
        undoBtn.Click();
        Thread.Sleep(700);
      }

      Thread.Sleep(endTime);

      application.Close();
    }

    private void initUndoCase(Panel chessBoardLayout)
    {
      IUIItem[] btns = chessBoardLayout.GetMultiple(SearchCriteria.All).OfType<Button>().ToArray();
      int j = 0;
      int k = 0;

      for (int i = 0; i < 8; ++i)
      {
        if (i % 2 == 0)
        {
          btns[110 + j++].Click();
          Thread.Sleep(500);
          continue;
        }

        btns[120 + k++].Click();
        Thread.Sleep(500);
      }
    }

    #endregion

    #region Khu vực test AI

    [TestMethod]
    public void aiTest()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var onePlayerButton = windows.Get<Button>(SearchCriteria.ByText("1 PLAYER"));
      onePlayerButton.Click();

      Thread.Sleep(700);

      var comFirstButton = windows.Get<Button>(SearchCriteria.ByText("COMPUTER FIRST"));
      comFirstButton.Click();

      var difficutyCB = windows.Get<ComboBox>(SearchCriteria.ByAutomationId("difficutyCB"));
      difficutyCB.Select(1);

      Thread.Sleep(700);

      var playButton = windows.Get<Button>(SearchCriteria.ByText("OK"));
      playButton.Click();

      var mainForm = application.GetWindow("GAME CARO", InitializeOption.NoCache);
      var mainTablePanel = mainForm.Get<Panel>(SearchCriteria.ByAutomationId("mainTablePanel"));

      var chessBoardLayout = mainForm.Get<Panel>(SearchCriteria.Indexed(1));

      initTestCase(chessBoardLayout);
      var aiMove = chessBoardLayout.Get<Button>(SearchCriteria.Indexed(113));

      Assert.AreEqual(aiMove.VisibleImage.RawFormat, GameConstant.O_IMG.RawFormat);

      Thread.Sleep(endTime);

      application.Close();
    }

    [TestMethod]
    public void aiTest2()
    {
      var application = Application.Launch(filePath);
      var windows = application.GetWindow("GAME CARO", InitializeOption.NoCache);

      var startNode = windows.Get<Button>(SearchCriteria.ByText("START"));
      startNode.Click();

      Thread.Sleep(700);

      var onePlayerButton = windows.Get<Button>(SearchCriteria.ByText("1 PLAYER"));
      onePlayerButton.Click();

      Thread.Sleep(700);

      var comFirstButton = windows.Get<Button>(SearchCriteria.ByText("COMPUTER FIRST"));
      comFirstButton.Click();

      var difficutyCB = windows.Get<ComboBox>(SearchCriteria.ByAutomationId("difficutyCB"));
      difficutyCB.Select(0);

      Thread.Sleep(700);

      var playButton = windows.Get<Button>(SearchCriteria.ByText("OK"));
      playButton.Click();

      var mainForm = application.GetWindow("GAME CARO", InitializeOption.NoCache);
      var mainTablePanel = mainForm.Get<Panel>(SearchCriteria.ByAutomationId("mainTablePanel"));

      var chessBoardLayout = mainForm.Get<Panel>(SearchCriteria.Indexed(1));

      initTestCase2(chessBoardLayout);
      var aiMove = chessBoardLayout.Get<Button>(SearchCriteria.Indexed(94));

      Assert.AreEqual(aiMove.VisibleImage.RawFormat, GameConstant.O_IMG.RawFormat);

      Thread.Sleep(endTime);

      application.Close();
    }

    private void initTestCase(Panel chessBoardLayout)
    {
      IUIItem[] btns = chessBoardLayout.GetMultiple(SearchCriteria.All).OfType<Button>().ToArray();
      int[] indexs = new int[]
      {
        126, 128, 142, 156, 170, 141, 171,
      };

      foreach (int index in indexs)
      {
        btns[index].Click();
        Thread.Sleep(500);
      }
    }

    private void initTestCase2(Panel chessBoardLayout)
    {
      IUIItem[] btns = chessBoardLayout.GetMultiple(SearchCriteria.All).OfType<Button>().ToArray();
      int[] indexs = new int[]
      {
        128, 84, 126, 99, 129, 114,
      };

      foreach (int index in indexs)
      {
        btns[index].Click();
        Thread.Sleep(500);
      }
    }

    #endregion
  }
}
