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
        #region Thuộc tính của người

        private bool isX;
        private bool isXTurn;
        private int gameType;
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

        #endregion

        #region Hàm dựng 1 Player

        public MainForm(int gameType, string userName, int depth, bool isPlayerFirst)
        {
            InitializeComponent();
            caroBoard = new Board();
            this.gameType = gameType;
            this.userName = userName;
            this.depth = depth;

            switch (gameType)
            {
                case 1:
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

                case 2:
                    isX = false;
                    isXTurn = false;
                    break;
            }
        }

        #endregion

        #region Hàm dựng 2 Players hoặc LAN

        public MainForm(int gameType, bool isHost, string ip = null)
        {
            InitializeComponent();

            caroBoard = new Board();
            this.gameType = gameType;


            messageReceiver.DoWork += messageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            //if (isHost)
            //{
            //    isX = false;
            //    isXTurn = false;
            //    server = new TcpListener(System.Net.IPAddress.Any, 5732);
            //    server.Start();
            //    socket = server.AcceptSocket();
            //}
            //else
            //{
            //    isX = true;
            //    isXTurn = true;

            //    try
            //    {
            //        client = new TcpClient(ip, 5732);
            //        socket = client.Client;
            //        messageReceiver.RunWorkerAsync();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        return;
            //    }

            //}
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
            byte[] buffer = new byte[1];
            socket.Receive(buffer);
            playMove(new Point(buffer[0] / GameConstant.ROWS, buffer[0] % GameConstant.ROWS));     
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            renderBoardLayout();   

            if (aiStartFirst)
            {
                int midMove = GameConstant.ROWS / 2;
                TableLayoutPanel test = (TableLayoutPanel)mainTablePanel.Controls[2];
                Button btn = (Button)test.Controls[midMove];
                playMove(new Point(midMove, midMove));
            }

            controlMusic(1);
        }

        #region Hàm thực hiện vẽ giao diện bàn cờ

        private void renderBoardLayout()
        {
            if (gameType == 1)
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
                    tableLayout.Controls.Add(renderChessBtn(i, j), j, i);
                }
            }

            mainTablePanel.Controls.Add(tableLayout, 1, 0);
        }

        #endregion

        #region Hàm điều khiển nhạc game

        private void controlMusic(int mode)
        {
            SoundPlayer soundPlayer = new SoundPlayer(GameConstant.backgroundMusic);

            switch (mode)
            {
                case 1:
                    soundPlayer.PlayLooping();
                    return;

                case 2:
                    soundPlayer.Stop();
                    return;
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

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //if (gameType == 2)
            //{
            //    try
            //    {
            //        Point temp = (Point)btn.Tag;
            //        byte[] buffer = { (byte)(temp.X * GameConstant.ROWS + temp.Y) };
            //        socket.Send(buffer);
            //        playMove(new Point(buffer[0] / GameConstant.ROWS, buffer[0] % GameConstant.ROWS));
            //        freezeBoard();
            //        messageReceiver.RunWorkerAsync();
            //        btn.Click -= btn_click;
            //        return;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        return;
            //    }
            //}

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

            if (gameType < 2)
            {
                TableLayoutPanel test = (TableLayoutPanel)mainTablePanel.Controls[2];
                int[] bestMove = GameLogic.calculateNextMove(depth, caroBoard);
                Point point = new Point(bestMove[0], bestMove[1]);

                playMove(point);

                winner = checkWinner();

                if (winner == 1)
                {
                    MessageBox.Show("O won");
                    return;
                }

                isPlayerTurn = true;
            }

            btn.Click -= btn_click;

            Console.WriteLine("\n\n========= TRANG THAI BAN CO =========");
            for (int i = 0; i < GameConstant.ROWS; ++i)
            {
                for (int j = 0; j < GameConstant.COLS; ++j)
                {
                    Console.Write(caroBoard.board[i, j] + "  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n========= DIEM DANH GIA =========");
            Console.WriteLine("X: " + GameLogic.getScore(caroBoard, true, true) + " O: " + GameLogic.getScore(caroBoard, false, true));
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

        #region Hàm thực hiện đánh quân cờ

        private bool playMove(Point point)
        {
            TableLayoutPanel caroPanel = (TableLayoutPanel)mainTablePanel.Controls[2];
            Button btn = (Button)caroPanel.Controls[point.X * GameConstant.ROWS + point.Y];

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
            List<Button> listBtn = mainTablePanel.Controls[1].Controls.OfType<Button>().ToList();

            foreach (Button btn in listBtn)
            {
                btn.Click -= btn_click;
            }
        }

        private void unfreezeBoard()
        {
            List<Button> listBtn = mainTablePanel.Controls[1].Controls.OfType<Button>().Where(item => item.Image == null).ToList();

            foreach (Button btn in listBtn)
            {
                btn.Click += btn_click;
            }
        }
    }
}
