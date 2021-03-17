﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro_UDTM.Components
{
    class GameConstant
    {
        public static int ROWS = 21;
        public static int COLS = 21;

        public static int WIN_SCORE = 100000000;

        public static Image X_IMG = new Bitmap(Properties.Resources.x, new Size(24 - 7, 24 - 7));
        public static Image O_IMG = new Bitmap(Properties.Resources.o, new Size(24 - 7, 24 - 7));

        // Madison
        public static Color boardColor = Color.FromArgb(44, 62, 80);

        // Dodger blue
        public static Color boardBorderColor = Color.FromArgb(0, 154, 255);

        // Light yellow
        public static Color buttonColor = Color.FromArgb(241, 196, 15);

        //
        public static Color buttonClickColor = Color.FromArgb(213, 244, 255);

        public static string backgroundMusic = @".\Resources\Kisstherain-Yiruma_7x9x.wav";
    }
}
