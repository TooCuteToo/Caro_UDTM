using Caro_UDTM.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_UDTM
{
    public partial class MainForm : Form
    {
        private Stack<Button> moveStack;
        private List<Button> listBtn;

        #region Thuộc tính của người

        private bool isX;
        private bool isXTurn;
        private GameMode gameType;
        private string userName;

        #endregion

        #region Thuộc tính của AI

        private bool isPlayerTurn;
        private bool aiStartFirst;
        private int depth;
        private Board caroBoard;

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

            this.gameType = gameType;
            this.userName = userName;
            this.depth = depth;

            switch (gameType)
            {
                case GameMode.OnePlayer:
                    aiStartFirst = !isPlayerFirst;
                    isX = false;
                    isXTurn = false;

                    if (isPlayerFirst)
                    {
                        isX = true;
                        isXTurn = true;
                        isPlayerTurn = true;
                        break;
                    }

                    isPlayerTurn = false;
                    break;
            }
        }

        #endregion

        #region Hàm dựng 2 Players

        public MainForm(GameMode gameType, string playerOneName, string playerTwoName)
        {
            InitializeComponent();

            caroBoard = new Board();
            this.gameType = gameType;

            playerOneNameTxt.Text = playerOneName;
            playerTwoNameTxt.Text = playerTwoName;
        }

        #endregion

        #region Hàm dựng LAN

        public MainForm(GameMode gameType, bool isHost, string ipAddress = null)
        {
            InitializeComponent();

            listBtn = new List<Button>();
            caroBoard = new Board();
            this.gameType = gameType;
            this.isHost = isHost ? 0 : 1;

            messageReceiver.DoWork += messageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            isX = false;
            isX = false;

            if (isHost)
            {
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();

                socket = server.AcceptSocket();
            }
            else
            {
                try
                {
                    client = new TcpClient(ipAddress, 5732);
                    socket = client.Client;
                    messageReceiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }

        #endregion 

        #region Khu vưc dành cho LAN

        private void messageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (checkWinner() == 0)
            {
                freezeBoard();
                receiveMove();
                unfreezeBoard();
            }
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

            if (aiStartFirst)
            {
                int midMove = GameConstant.ROWS / 2;
                TableLayoutPanel test = (TableLayoutPanel)mainTablePanel.Controls[2];
                Button btn = (Button)test.Controls[midMove];
                playMove(new Point(midMove, midMove));
            }

            //controlMusic(1);
        }

        #endregion

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

            mainTablePanel.Controls.Add(tableLayout, 1, 0);
        }

        #endregion

        #region Hàm điều khiển nhạc game

        private void controlMusic(int mode)
        {
            //SoundPlayer soundPlayer = new SoundPlayer(GameConstant.backgroundMusic);

            //switch (mode)
            //{
            //    case 1:
            //        soundPlayer.PlayLooping();
            //        return;

            //    case 2:
            //        soundPlayer.Stop();
            //        return;
            //}
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

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (gameType == GameMode.LAN)
            {
                try
                {
                    Point coordition = (Point)btn.Tag;
                    byte[] buffer = { (byte)coordition.X, (byte)coordition.Y, (byte)isHost };

                    playMove(coordition, isHost);
                    socket.Send(buffer);

                    messageReceiver.RunWorkerAsync();

                    btn.Click -= btn_click;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                if (winner == 2)
                {
                    MessageBox.Show("X won");
                    return;
                }

                if (winner == 1)
                {
                    MessageBox.Show("O won");
                    return;
                }
            }

            if (gameType == GameMode.OnePlayer)
            {
                TableLayoutPanel test = (TableLayoutPanel)mainTablePanel.Controls[2];
                int[] bestMove = GameLogic.calculateNextMove(depth, caroBoard);
                Point point = new Point(bestMove[0], bestMove[1]);

                playMove(point);

                Console.WriteLine("Black: " + GameLogic.getScore(caroBoard, true, true) + " White: " + GameLogic.getScore(caroBoard, false, true));

                winner = checkWinner();

                if (winner == 1)
                {
                    MessageBox.Show("O won");
                    return;
                }

                isPlayerTurn = true;
            }

            btn.Click -= btn_click;

            //caroBoard.printBoard();

            //Console.WriteLine("\n========= DIEM DANH GIA =========");
            //Console.WriteLine("X: " + GameLogic.getScore(caroBoard, true, true) + " O: " + GameLogic.getScore(caroBoard, false, true));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TableLayoutPanel test = (TableLayoutPanel)mainTablePanel.Controls[1];
            //Button move = (Button)test.Controls[70];
            //move.Image = GameConstant.O_IMG;

            //isX = true;
            //isXTurn = true;

            controlMusic(2);
        }

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
            btn.BackColor = GameConstant.buttonClickColor;

            if (moveStack.Count > 0)
            {
                moveStack.Peek().BackColor = GameConstant.boardColor;
            }

            moveStack.Push(btn);

            if (btn.Image != null) return false;

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

            btn.Click -= btn_click;

            return true;
        }

        #endregion

        #region Hàm thực hiện đánh quân cờ (1 Player vs 2 Players)

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

            return true;
        }

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            messageReceiver.WorkerSupportsCancellation = true;
            messageReceiver.CancelAsync();

            if (server != null)
            {
                server.Stop();
            }

            controlMusic(2);
        }

        private void freezeBoard()
        {
            foreach (Button btn in listBtn)
            {
                if (btn.Image == null) btn.MouseHover += btn_MouseHover;
            }
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
        }

        private void unfreezeBoard()
        {
            foreach (Button btn in listBtn)
            {
                btn.MouseHover -= btn_MouseHover;
                btn.Enabled = true;
            }
        }

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

                    return;
                }
            }
        }

        #endregion
    }
}
