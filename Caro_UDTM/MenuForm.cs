using Caro_UDTM.Components;
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
using System.Windows.Media;
using Transitions;

namespace Caro_UDTM
{
  public partial class MenuForm : Form
  {
    private PromptForm prompt;

    public MenuForm()
    {
      InitializeComponent();

      if (File.Exists(GameConstant.settingPath))
      {
        loadSetting();
        if (GameConstant.backgroundFlag)
        {
          GameConstant.backgroundMusic.PlayLooping();
        }
      }
      else
      {
        GameConstant.backgroundMusic.PlayLooping();
      }

      pictureBox1.Image = GameConstant.menuImage[new Random().Next(0, 2)];

      timer1.Interval = 1000;
      timer1.Start();
    }

    private void loadSetting()
    {
      using (StreamReader sr = File.OpenText(GameConstant.settingPath))
      {
        string s;
        int i = 0;
        bool[] settings = new bool[]
        {
          false, false
        };

        while ((s = sr.ReadLine()) != null)
        {
          bool setting = bool.Parse(s);
          settings[i] = setting;
          i++;
        }

        for (int j = 0; j < settings.Length; ++j)
        {
          if (j == 0)
          {
            GameConstant.soundEffectFlag = settings[j];
          }
          else
          {
            GameConstant.backgroundFlag = settings[j];
          }
        }
      }
    }

    private void startGameBtn_Click(object sender, EventArgs e)
    {
      Transition transition = new Transition(new TransitionType_EaseInEaseOut(500));
      Button btn = (Button)sender;

      Control controlOn, controlOn2, controlOff;

      if (mainMenu.Left == 9)
      {
        controlOff = gameModeMenu;
        controlOn = mainMenu;
        btn.Text = "BACK";
      }
      else
      {
        controlOn = gameModeMenu;
        controlOff = mainMenu;
        btn.Text = "START";
      }

      controlOn2 = onePlayerMenu;

      controlOn.SendToBack();
      controlOn2.SendToBack();
      controlOff.BringToFront();

      transition.add(controlOn, "Left", -1 * controlOn.Width);
      transition.add(controlOn2, "Left", -1 * controlOn.Width);
      transition.add(controlOff, "Left", 9);
      transition.run();
    }

    private void onePlayerBtn_Click(object sender, EventArgs e)
    {
      Transition transition = new Transition(new TransitionType_EaseInEaseOut(500));
      prompt = new PromptForm("NAME INPUT", GameMode.OnePlayer, this);

      Control controlOn, controlOff;

      if (gameModeMenu.Left == 9)
      {
        controlOff = onePlayerMenu;
        controlOn = gameModeMenu;
      }
      else
      {
        controlOn = onePlayerMenu;
        controlOff = gameModeMenu;
      }

      controlOn.SendToBack();
      controlOff.BringToFront();

      transition.add(controlOn, "Left", -1 * controlOn.Width);
      transition.add(controlOff, "Left", 9);
      transition.run();
    }

    private void playerFirstBtn_Click(object sender, EventArgs e)
    {
      object[] result = prompt.showDialog();

      if (result[0] == null) return;

      string name = (string)result[0];
      string difficulty = (string)result[1];

      MainForm game = new MainForm(GameMode.OnePlayer, name, getDifficulty(difficulty), true);
      Visible = false;
      game.ShowDialog();
      Visible = true;
    }

    private void comFirstBtn_Click(object sender, EventArgs e)
    {
      object[] result = prompt.showDialog();

      if (result[0] == null) return;

      string name = (string)result[0];
      string difficulty = (string)result[1];

      MainForm game = new MainForm(GameMode.OnePlayer, name, getDifficulty(difficulty), false);
      Visible = false;
      game.ShowDialog();
      Visible = true;
    }

    private void twoPlayerBtn_Click(object sender, EventArgs e)
    {
      prompt = new PromptForm("NAME INPUT", GameMode.TwoPlayer, this);
      object[] result = prompt.showDialog2();

      if (result[0] == null) return;

      MainForm game = new MainForm(GameMode.TwoPlayer, result[0].ToString(), result[1].ToString());
      Visible = false;
      game.ShowDialog();
      Visible = true;
    }

    private int getDifficulty(string difficulty)
    {
      if (difficulty == "EASY") return 2;
      if (difficulty == "MEDIUM") return 3;

      return 4;
    }

    private void leaderBtn_Click(object sender, EventArgs e)
    {
      Visible = false;
      new LeaderBoard().ShowDialog();
      Visible = true;
    }

    private void exitBtn_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      Image destination = (pictureBox1.Image == GameConstant.menuImage[0]) ? GameConstant.menuImage[1] : GameConstant.menuImage[0];
      pictureBox1.Image = destination;
    }

    private void helpBtn_Click(object sender, EventArgs e)
    {
      HelpForm help = new HelpForm();
      Visible = false;
      help.ShowDialog();
      Visible = true;
    }

    private void multiPlayerBtn_Click(object sender, EventArgs e)
    {
      new PromptForm("CARO", GameMode.LAN, this).showDialog();
    }

    private void comComBtn_Click(object sender, EventArgs e)
    {
      prompt = new PromptForm("COM VS COM", GameMode.ComCom, this);
      string difficulty = prompt.showDialog3();

      if (difficulty == null) return;

      MainForm game = new MainForm(GameMode.ComCom, getDifficulty(difficulty));
      Visible = false;
      game.ShowDialog();
      Visible = true;
    }

    private void settingBtn_Click(object sender, EventArgs e)
    {
      Visible = false;
      new SettingForm().ShowDialog();
      Visible = true;
    }
  }
}
