using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Caro_UDTM.Components
{
  public class GameConstant
  {
    public static int ROWS = 15;
    public static int COLS = 15;
    public static int WIN_SCORE = 10000000;

    public static Image X_IMG = new Bitmap(Properties.Resources.x, new Size(24 - 7, 24 - 7));
    public static Image O_IMG = new Bitmap(Properties.Resources.o, new Size(24 - 7, 24 - 7));
    public static Image PlayerOneAvater = new Bitmap(Properties.Resources.astronaut);
    public static Image PlayerTwoAvatar = new Bitmap(Properties.Resources.ninja);
    public static Image AIAvater = new Bitmap(Properties.Resources.ai);
    public static Image[] menuImage = { new Bitmap(Properties.Resources.menu_x_icon), new Bitmap(Properties.Resources.menu_o_icon) };

    public static SoundPlayer soundEffect = new SoundPlayer(@"./Resources/sound_effect.wav");
    public static SoundPlayer backgroundMusic = new SoundPlayer(@"./Resources/background.wav");

    public static bool soundEffectFlag = true;
    public static bool backgroundFlag = true;

    public static string soundEffectPath = Application.StartupPath + @"/Resources/sound_effect.wav";
    public static string backgroundMusicPath = Application.StartupPath + @"/Resources/background.wav";
    public static string settingPath = @"./Setting.txt";
    public static string savePlayerFirstPath = @"./SaveGamePlayerFirst.txt";
    public static string saveAIFirstPath = @"./SaveGameAiFirst.txt";
    public static string saveTwoPlayerPath = @"./SaveGameTwoPlayer.txt";
    public static string saveLanPath = @"./SaveGameLAN.txt";
    public static string topPlayer = @"./TopPlayer.txt";

    public static MediaPlayer mPlayer = new MediaPlayer();

    // Madison
    public static System.Drawing.Color boardColor = System.Drawing.Color.FromArgb(44, 62, 80);

    // Dodger blue
    public static System.Drawing.Color boardBorderColor = System.Drawing.Color.FromArgb(0, 154, 255);

    // Light yellow
    public static System.Drawing.Color buttonColor = System.Drawing.Color.FromArgb(241, 196, 15);

    //
    public static System.Drawing.Color buttonClickColor = System.Drawing.Color.FromArgb(213, 244, 255);

    //public static string backgroundMusic = @".\Resources\Kisstherain-Yiruma_7x9x.wav";

    // Main font
    public static Font mainFont = new Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

  }

  public enum GameMode
  {
    TwoPlayer = 2,
    OnePlayer = 1,
    LAN = 3,
    ComCom = 4,
  }
}
