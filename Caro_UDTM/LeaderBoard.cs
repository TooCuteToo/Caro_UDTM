using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caro_UDTM.Components;

namespace Caro_UDTM
{
  public partial class LeaderBoard : Form
  {
    public LeaderBoard()
    {
      InitializeComponent();
      initLeaderboard();
    }

    private void initLeaderboard()
    {
      int x = 81;
      int y = 85;
      List<Player> players = new List<Player>(); 

      using (StreamReader sr = File.OpenText(GameConstant.topPlayer))
      {
        string s;

        while ((s = sr.ReadLine()) != null)
        {
          string[] str = s.Split('-');
          players.Add(new Player(str[0].TrimEnd(), int.Parse(str[1].TrimStart())));
        }

        players = players.OrderByDescending(item => item.Score).ToList();

        int n = players.Count < 8 ? players.Count : 7;

        for (int i = 0; i < n; i++)
        {
          Label playerLB = new Label()
          {
            Text = (i + 1).ToString() + ". " + players[i].Name + " - " + players[i].Score,
            Location = new Point(x, y),
            ForeColor = Color.White,
            Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
            Size = new Size(232, 24),
          };

          y += 49;
          this.Controls.Add(playerLB);
        }
      }
    }

    private void closeLeaderBtn_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
