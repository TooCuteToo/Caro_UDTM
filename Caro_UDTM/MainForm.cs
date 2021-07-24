using Caro_UDTM.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_UDTM
{
  public partial class MainForm : Form
  {
    private Stack<Button> moveStack;
    private List<Button> listBtn;
    private List<Button> movedBtns;
    private List<Player> players;

    #region Thuộc tính của người

    private bool isX;
    private bool isXTurn;
    private bool isPlayerFirst;

    private GameMode gameType;
    private string userName;

    #endregion

    #region Thuộc tính của AI

    private bool isPlayerTurn;
    private bool aiStartFirst;
    private int depth;
    private Board caroBoard;
    Thread worker;

    #endregion

    #region Thuộc tính của multiplayer

    private BackgroundWorker messageReceiver = new BackgroundWorker();
    private TcpListener server = null;
    private TcpClient client;
    private Socket socket;
    private int isHost;

    #endregion

    #region Hàm dựng 1 Player

    public MainForm(GameMode gameType, string userName, int depth, bool isPlayerFirst)
    {
      InitializeComponent();
      caroBoard = new Board();
      movedBtns = new List<Button>();
      players = readLeaderboard();
      centerLabel();

      this.gameType = gameType;
      this.userName = userName.ToUpper();
      this.depth = depth;
      this.isPlayerFirst = isPlayerFirst;
      playerTwoNameTxt.Text = "MAY";
      playerOneNameTxt.Text = this.userName;
      pictureBox1.Image = GameConstant.PlayerOneAvater;
      pictureBox2.Image = GameConstant.AIAvater;
      initTitleLB();

      aiStartFirst = !isPlayerFirst;
      isX = false;
      isXTurn = false;

      if (isPlayerFirst)
      {
        isX = true;
        isXTurn = true;
        isPlayerTurn = true;
      } else
      {
        isPlayerTurn = false;
      }
    }

    #endregion

    #region Hàm dựng COM vs COM

    public MainForm(GameMode gameType, int depth)
    {
      InitializeComponent();
      caroBoard = new Board();
      movedBtns = new List<Button>();

      this.gameType = gameType;
      this.depth = depth;
      this.isPlayerFirst = false;

      playerOneNameTxt.Text = "MAY MOT";
      playerTwoNameTxt.Text = "MAY HAI";
      initTitleLB();

      aiStartFirst = !isPlayerFirst;
      isX = false;
      isXTurn = false;

      if (isPlayerFirst)
      {
        isX = true;
        isXTurn = true;
        isPlayerTurn = true;
      } else
      {
        isPlayerTurn = false;
      }
    }

    #endregion

    #region Hàm dựng 2 Players

    public MainForm(GameMode gameType, string playerOneName, string playerTwoName)
    {
      InitializeComponent();

      movedBtns = new List<Button>();
      caroBoard = new Board();
      players = readLeaderboard();
      this.gameType = gameType;

      playerOneNameTxt.Text = playerOneName.ToUpper();
      playerTwoNameTxt.Text = playerTwoName.ToUpper();
      pictureBox1.Image = GameConstant.PlayerOneAvater;
      pictureBox2.Image = GameConstant.PlayerTwoAvatar;

      initTitleLB();
    }

    #endregion

    #region Hàm dựng LAN

    public MainForm(GameMode gameType, bool isHost, string ipAddress = null)
    {
      try
      {
        InitializeComponent();

        caroBoard = new Board();
        listBtn = new List<Button>();
        players = readLeaderboard();
        saveBtn.Enabled = false;
        loadBtn.Enabled = false;
        
        this.gameType = gameType;
        this.isHost = isHost ? 0 : 1;

        messageReceiver.DoWork += messageReceiver_DoWork;
        CheckForIllegalCrossThreadCalls = false;

        isX = false;

        if (isHost)
        {
          server = new TcpListener(System.Net.IPAddress.Any, 5732);
          server.Start();
          socket = server.AcceptSocket();
        }
        else
        {
          client = new TcpClient(ipAddress, 5732);
          socket = client.Client;
          messageReceiver.RunWorkerAsync();
        }
      } catch
      {
        MessageBox.Show("OOPS!!! SOMETHING IS WRONG");
        Close();
      }
    }

    #endregion

    #region Khu vưc dành cho LAN

    private void messageReceiver_DoWork(object sender, DoWorkEventArgs e)
    {
      freezeBoard();
      receiveMove();
      unfreezeBoard();
    }

    private void receiveMove()
    {
      byte[] buffer = new byte[3];
      socket.Receive(buffer);
      playMove(new Point(buffer[0], buffer[1]), buffer[2]);
    }

    #endregion

    #region Máy đi nước đầu tiên

    private void Form1_Load(object sender, EventArgs e)
    {
      renderBoardLayout();
      moveStack = new Stack<Button>();

      if (aiStartFirst && this.gameType == GameMode.ComCom)
      {
        worker = new Thread(new ThreadStart(doSomeThing));
        worker.IsBackground = true;
        worker.Start();
        return;
      }

      if (aiStartFirst)
      {
        int midMove = GameConstant.ROWS / 2;
        playMove(new Point(midMove, midMove));
      }

      //controlMusic(1);
    }

    #endregion

    private void doSomeThing()
    {
      int xMove = new Random().Next(GameConstant.ROWS);
      int yMove = new Random().Next(GameConstant.COLS);
      playMove(new Point(xMove, yMove));
    }

    private void centerLabel()
    {
      int playerOneX = (panel2.Size.Width - playerOneNameTxt.Size.Width) / 2;
      int playerTwoX = (panel2.Size.Width - playerTwoNameTxt.Size.Width) / 2;
      int xLabel = (panel2.Size.Width - playerTwoTitleLB.Size.Width) / 2;

      playerOneNameTxt.Location = new Point(playerOneX, playerOneNameTxt.Location.Y);
      playerTwoNameTxt.Location = new Point(playerTwoX, playerTwoNameTxt.Location.Y);

      playerTwoTitleLB.Location = new Point(xLabel, playerTwoTitleLB.Location.Y);
      playerOneTitleLB.Location = new Point(xLabel, playerOneTitleLB.Location.Y);
    }

    #region Hàm thực hiện vẽ giao diện bàn cờ

    private void renderBoardLayout()
    {
      listBtn = new List<Button>();

      if (gameType == GameMode.OnePlayer)
      {
        playerOneNameTxt.Text = userName.ToUpper();
      }

      TableLayoutPanel tableLayout = new TableLayoutPanel()
      {
        Margin = new Padding(0),
        Dock = DockStyle.Fill,
        BackColor = GameConstant.boardColor,
        Name = "chessBoardPanel",
      };

      for (int i = 0; i < GameConstant.ROWS; ++i)
      {
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / GameConstant.ROWS));
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / GameConstant.COLS));

        for (int j = 0; j < GameConstant.COLS; ++j)
        {
          Button btn = renderChessBtn(i, j);
          tableLayout.Controls.Add(btn, j, i);
          listBtn.Add(btn);
        }
      }

      mainTablePanel.Controls.Add(tableLayout);
    }

    #endregion

    #region Hàm thực hiện khởi tạo lại bàn cờ

    private void clearBoardLayout()
    {
      caroBoard = new Board();
      moveStack = new Stack<Button>();

      foreach (Button btn in movedBtns)
      {
        btn.Image = null;
        btn.Click += btn_click;
        btn.BackColor = GameConstant.boardColor;
      }

      if (gameType == GameMode.OnePlayer)
      {
        //aiStartFirst = !isPlayerFirst;
        if (isPlayerFirst)
        {
          isX = true;
          isXTurn = true;
          isPlayerTurn = true;
        }
        else isPlayerTurn = false;
      }

      moveStack = new Stack<Button>();
      movedBtns = new List<Button>();

      if (aiStartFirst)
      {
        isX = false;
        isXTurn = false;
        isPlayerTurn = false;
        int midMove = GameConstant.ROWS / 2;
        playMove(new Point(midMove, midMove));
      }
    }

    #endregion

    #region Hàm tạo button tương ứng là một ô cờ

    private Button renderChessBtn(int i, int j)
    {
      Button btn = new Button()
      {
        Text = "",
        Margin = new Padding(0),
        Dock = DockStyle.Fill,
        Tag = new Point(i, j),
        FlatStyle = FlatStyle.Flat,
      };

      btn.FlatAppearance.BorderColor = GameConstant.boardBorderColor;
      btn.Click += btn_click;

      return btn;
    }

    #endregion

    #region Sự kiện cho quân cờ

    private void btn_click(object sender, EventArgs e)
    {
      Button btn = (Button)sender;

      if (gameType == GameMode.LAN)
      {
        try
        {
          Point coordition = (Point)btn.Tag;
          byte[] buffer = { (byte)coordition.X, (byte)coordition.Y, (byte)isHost };

          socket.Send(buffer);
          playMove(coordition, isHost);
          messageReceiver.RunWorkerAsync();

          btn.Click -= btn_click;
          return;
        }
        catch (Exception ex)
        {
          MessageBox.Show("NOT YOUR TURN");
          return;
        }
      }

      if (!playMove((Point)btn.Tag))
      {
        isPlayerTurn = true;
        return;
      }

      int winner = checkWinner();

      if (winner != 0)
      {
        if (gameType == GameMode.OnePlayer && winner == 2 || winner == 1)
        {
          showWinnerDialog(playerOneNameTxt.Text);
          addToLeaderboard(playerOneNameTxt.Text);
        }

        else if (winner == 2)
        {
          showWinnerDialog(playerTwoNameTxt.Text);
        }
      }

      else if (gameType == GameMode.OnePlayer)
      {
        int[] bestMove = GameLogic.calculateNextMove(depth, caroBoard);
        Point point = new Point(bestMove[0], bestMove[1]);
        playMove(point);

        //Console.WriteLine("Black: " + GameLogic.getScore(caroBoard, true, true) + " White: " + GameLogic.getScore(caroBoard, false, true));
        winner = checkWinner();

        if (winner == 1)
        {
          showWinnerDialog(playerTwoNameTxt.Text);
        }

        isPlayerTurn = true;
      }

      //Console.WriteLine("\n========= DIEM DANH GIA =========");
      //Console.WriteLine("X: " + GameLogic.getScore(caroBoard, true, true) + " O: " + GameLogic.getScore(caroBoard, false, true));
    }

    #endregion

    #region Hàm thông báo thắng

    private void showWinnerDialog(string userName)
    {
      try
      {
        if (this.gameType == GameMode.ComCom)
        {
          this.Invoke((MethodInvoker)delegate
          {
            //MessageBox.Show(userName + " IS A WINNER", "WINNER");
            // close the form on the forms thread
            worker.Abort();

            if (userName != "HOA")
            {
              MessageBox.Show(userName + " IS A WINNER", "WINNER");
            }
            else
            {
              MessageBox.Show("THERE IS NO WINNER");
            }

            Close();
          });

          return;
        }

        DialogResult result = MessageBox.Show(userName + " IS A WINNER", "WINNER", MessageBoxButtons.OKCancel);

        if (result == DialogResult.OK)
        {
          clearBoardLayout();
          return;
        }

        this.Close();
        return;
      } catch
      {

      }
    }

    #endregion

    #region Hàm đánh giá thắng thua

    // Quy ước:
    // 2 là X thắng
    // 1 là O thắng
    // 0 là hòa
    private int checkWinner()
    {
      if (GameLogic.getScore(caroBoard, true, false) >= GameConstant.WIN_SCORE) return 2;
      if (GameLogic.getScore(caroBoard, false, true) >= GameConstant.WIN_SCORE) return 1;

      return 0;
    }

    #endregion

    #region Hàm thực hiện đánh quân cờ (1 Player vs 2 Players)

    private bool playMove(Point point)
    {
      TableLayoutPanel caroPanel = (TableLayoutPanel)mainTablePanel.Controls[2];
      Button btn = (Button)caroPanel.Controls[point.X * GameConstant.ROWS + point.Y];

      if (btn.Image != null) return false;

      btn.BackColor = GameConstant.buttonClickColor;
      //Console.WriteLine("O / X: " + GameLogic.evaluateBoardForO(caroBoard, isXTurn).ToString());
      movedBtns.Add(btn);

      if (moveStack.Count > 0)
      {
        moveStack.Peek().BackColor = GameConstant.boardColor;
      }

      moveStack.Push(btn);

      if (isX)
      {
        btn.Image = GameConstant.X_IMG;
        caroBoard.addMove(point.X, point.Y, isX);
        isX = false;
      }

      else
      {
        btn.Image = GameConstant.O_IMG;
        caroBoard.addMove(point.X, point.Y, isX);
        isX = true;
      }

      if (this.gameType != GameMode.ComCom)
      {
        if (GameConstant.soundEffectFlag)
        {
          GameConstant.mPlayer.Open(new Uri(GameConstant.soundEffectPath));
          GameConstant.mPlayer.Play();
        }
      }

      btn.Click -= btn_click;

      if (this.gameType == GameMode.ComCom)
      {
        Thread.Sleep(300);
        int winner = checkWinner();

        if (winner != 0)
        {
          if (winner == 1)
          {
            showWinnerDialog(playerOneNameTxt.Text);
          }
          else if (winner == 2)
          {
            showWinnerDialog(playerTwoNameTxt.Text);
          }
          else if (winner == 0)
          {
            showWinnerDialog("HOA");
          }
        }
        else
        {
          TableLayoutPanel test = (TableLayoutPanel)mainTablePanel.Controls[2];
          int[] bestMove = GameLogic.calculateNextMove(depth, caroBoard);

          if (bestMove == null)
          {
            showWinnerDialog("HOA");
          }

          Point comPoint = new Point(bestMove[0], bestMove[1]);

          playMove(comPoint);

          winner = checkWinner();

          if (winner == 1)
          {
            showWinnerDialog(playerTwoNameTxt.Text);
          }
          else if (winner == 2)
          {
            showWinnerDialog(playerTwoNameTxt.Text);
          }
          else if (winner == 0)
          {
            showWinnerDialog("HOA");
          }

          isPlayerTurn = true;
        }
      }

      return true;
    }

    #endregion

    #region Hàm thực hiện đánh quân cờ LAN

    private bool playMove(Point point, int isHost)
    {
      TableLayoutPanel caroPanel = (TableLayoutPanel)mainTablePanel.Controls[2];
      Button btn = (Button)caroPanel.Controls[point.X * GameConstant.ROWS + point.Y];
      btn.BackColor = GameConstant.buttonClickColor;

      if (moveStack.Count > 0)
      {
        moveStack.Peek().BackColor = GameConstant.boardColor;
      }

      moveStack.Push(btn);

      if (btn.Image != null) return false;

      if (isHost == 1)
      {
        btn.Image = GameConstant.X_IMG;
        caroBoard.addMove(point.X, point.Y, true);
      }

      else
      {
        btn.Image = GameConstant.O_IMG;
        caroBoard.addMove(point.X, point.Y, false);
      }

      btn.Click -= btn_click;

      int winner = checkWinner();

      if (winner == 1)
      {
        MessageBox.Show("PLAYER ONE WIN");
        Close();
      }

      else if (winner == 2)
      {
        MessageBox.Show("PLAYER TWO WIN");
        Close();
      }

      return true;
    }

    #endregion

    #region Khu vực chức năng đánh LAN

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      messageReceiver.WorkerSupportsCancellation = true;
      messageReceiver.CancelAsync();

      if (server != null)
      {
        server.Stop();
      }
    }

    private void freezeBoard()
    {
      foreach (Button btn in listBtn)
      {
        if (btn.Image == null) btn.Enabled = false;
      }
    }

    private void unfreezeBoard()
    {
      foreach (Button btn in listBtn)
      {
        btn.Enabled = true;
      }
    }

    #endregion

    #region Chức năng undo

    private void button1_Click_1(object sender, EventArgs e)
    {
      if (moveStack.Count >= 2)
      {
        if (gameType == GameMode.OnePlayer)
        {
          for (int i = 0; i < 2; ++i)
          {
            Button btn = moveStack.Pop();
            btn.BackColor = GameConstant.boardColor;
            btn.Click += btn_click;
            Point point = (Point)btn.Tag;
            btn.Image = null;
            caroBoard.clearMove(point.X, point.Y);
            //caroBoard.printBoard();
            if (moveStack.Count >= 2)
            {
              moveStack.Peek().BackColor = GameConstant.buttonClickColor;
            }
          }

          return;
        }

        if (gameType == GameMode.TwoPlayer)
        {
          Button btn = moveStack.Pop();
          btn.BackColor = GameConstant.boardColor;
          btn.Click += btn_click;
          Point point = (Point)btn.Tag;
          btn.Image = null;
          caroBoard.clearMove(point.X, point.Y);
          //caroBoard.printBoard();
          isX = !isX;
          if (moveStack.Count >= 1)
          {
            moveStack.Peek().BackColor = GameConstant.buttonClickColor;
          }

          return;
        }
      }
    }

    #endregion

    #region Save, Load, Setting, Leaderboard

    private void settingsBtn_Click(object sender, EventArgs e)
    {
      new SettingForm().ShowDialog();
    }

    private void loadBtn_Click(object sender, EventArgs e)
    {
      try
      {
        StreamReader sr = null;

        if (gameType == GameMode.OnePlayer)
        {
          if (isPlayerFirst) sr = File.OpenText(GameConstant.savePlayerFirstPath);
          else if (aiStartFirst) sr = File.OpenText(GameConstant.saveAIFirstPath);
        }
        else if (gameType == GameMode.TwoPlayer)
        {
          sr = File.OpenText(GameConstant.saveTwoPlayerPath);
        }

        clearBoardLayout();

        string s;
        while ((s = sr.ReadLine()) != null)
        {
          string[] str = s.Split(' ');
          int point = int.Parse(str[0]);

          if (str[1] == "X")
          {
            isX = true;
            isXTurn = true;
          }
          else
          {
            isX = false;
            isXTurn = false;
          }

          Point loadPoint = new Point(point / GameConstant.COLS, point % GameConstant.COLS);
          playMove(loadPoint);
        }

        sr.Close();
      }
      catch
      {
        MessageBox.Show("CANT FIND SAVE!!!");
        return;
      }
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
      if (gameType == GameMode.OnePlayer)
      {
        if (isPlayerFirst)
        {
          using (StreamWriter sw = File.CreateText(GameConstant.savePlayerFirstPath))
          {
            writeToFile(sw);
          }
        }
        else if (aiStartFirst)
        {
          using (StreamWriter sw = File.CreateText(GameConstant.saveAIFirstPath))
          {
            writeToFile(sw);
          }
        }
      }
      else if (gameType == GameMode.TwoPlayer)
      {
        using (StreamWriter sw = File.CreateText(GameConstant.saveTwoPlayerPath))
        {
          writeToFile(sw);
        }
      }

      MessageBox.Show("YOUR GAME IS SAVED");
    }

    private void writeToFile(StreamWriter sw)
    {
      foreach (Button btn in movedBtns)
      {
        Point savePoint = (Point)btn.Tag;
        if (btn.Image == GameConstant.X_IMG) sw.WriteLine(savePoint.X * GameConstant.COLS + savePoint.Y + " " + "X");
        if (btn.Image == GameConstant.O_IMG) sw.WriteLine(savePoint.X * GameConstant.COLS + savePoint.Y + " " + "O");
      }
    }

    private void addToLeaderboard(string userName)
    {
      Player player = players.FirstOrDefault(item => item.Name == userName);

      if (player != null)
      {
        string str = player.Name + " - " + player.Score.ToString();
        player.Score += 10;
        string newStr = player.Name + " - " + player.Score.ToString();
        File.WriteAllText(GameConstant.topPlayer, File.ReadAllText(GameConstant.topPlayer).Replace(str, newStr));
      }
      else
      {
        using (StreamWriter sw = File.AppendText(GameConstant.topPlayer))
        {
          Player newPlayer = new Player(userName, 10);
          players.Add(newPlayer);
          sw.WriteLine(newPlayer.Name + " - " + newPlayer.Score.ToString());
        }
      }

      players = readLeaderboard();
      initTitleLB();
    }

    private List<Player> readLeaderboard()
    {
      using (StreamReader sr = File.OpenText(GameConstant.topPlayer))
      {
        List<Player> players = new List<Player>();
        string s;
        int i = 1;
        while ((s = sr.ReadLine()) != null && i < 8)
        {
          string[] str = s.Split('-');
          players.Add(new Player(str[0].TrimStart().TrimEnd(), int.Parse(str[1].TrimEnd())));
        }

        return players.OrderByDescending(item => item.Score).ToList();
      }
    }

    private void initTitleLB()
    {
      if (gameType == GameMode.OnePlayer)
      {
        if (depth == 2) playerTwoTitleLB.Text = "SILVER";
        else if (depth == 3) playerTwoTitleLB.Text = "PLATINUM";
        else if (depth == 4) playerTwoTitleLB.Text = "DIAMOND";

        getPlayerOneTitle(playerOneNameTxt.Text);
        
      }
      else if (gameType == GameMode.TwoPlayer || gameType == GameMode.LAN)
      {
        getPlayerOneTitle(playerOneNameTxt.Text);
        getPlayerTwoTitle(playerTwoNameTxt.Text);
      }
      else
      {
        if (depth == 2)
        {
          playerOneTitleLB.Text = "SILVER";
          playerTwoTitleLB.Text = "SILVER";
        }
        else if (depth == 3)
        {
          playerOneTitleLB.Text = "PLATINUM";
          playerTwoTitleLB.Text = "PLATINUM";
        }
        else if (depth == 4)
        {
          playerOneTitleLB.Text = "DIAMOND";
          playerTwoTitleLB.Text = "DIAMOND";
        }
      }
    }

    private void getPlayerOneTitle(string userName)
    {
      Player player = players.FirstOrDefault(item => item.Name == userName);

      if (player != null)
      {
        playerOneScoreTxt.Text = player.Score.ToString();

        if (player.Score >= 50)
        {
          playerOneTitleLB.Text = "DIAMOND";
        }
        else if (player.Score >= 30)
        {
          playerOneTitleLB.Text = "PLATINUM";
        }
        else
        {
          playerOneTitleLB.Text = "SILVER";
        }
      }
      else
      {
        playerOneTitleLB.Text = "SILVER";
      }
    }

    private void getPlayerTwoTitle(string userName)
    {
      Player player = players.FirstOrDefault(item => item.Name == userName);

      if (player != null)
      {
        playerTwoScoreTxt.Text = player.Score.ToString();

        if (player.Score >= 50)
        {
          playerTwoTitleLB.Text = "DIAMOND";
        }
        else if (player.Score >= 30)
        {
          playerTwoTitleLB.Text = "PLATINUM";
        }
        else
        {
          playerTwoTitleLB.Text = "SILVER";
        }
      }
      else
      {
        playerTwoTitleLB.Text = "SILVER";
      }
    }

    #endregion
  }
}
