﻿using System;
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
  public partial class SettingForm : Form
  {
    public SettingForm()
    {
      InitializeComponent();
    }

    private void saveSettingBtn_Click(object sender, EventArgs e)
    {
      bool soundEffectCheck = effectCB.Checked;
      bool backgroundCheck = musicCB.Checked;
      bool block2Check = block2CB.Checked;

      if (!soundEffectCheck)
      {
        GameConstant.soundEffectFlag = false;
      } else
      {
        GameConstant.soundEffectFlag = true;
      }

      if (!backgroundCheck)
      {
        GameConstant.backgroundFlag = false;
        GameConstant.backgroundMusic.Stop();
      } else
      {
        GameConstant.backgroundFlag = true;
        GameConstant.backgroundMusic.PlayLooping();
      }

      if (!block2Check)
      {
        GameConstant.block2Flag = false;
      } else
      {
        GameConstant.block2Flag = true;
      }

      saveSetting();
      Close();
    }

    private void SettingForm_Load(object sender, EventArgs e)
    {
      if (File.Exists(GameConstant.settingPath)) loadSetting();
      effectCB.Checked = GameConstant.soundEffectFlag;
      musicCB.Checked = GameConstant.backgroundFlag;
      block2CB.Checked = GameConstant.block2Flag;
    }

    private void saveSetting()
    {
      using (StreamWriter sw = File.CreateText(GameConstant.settingPath))
      {
        sw.WriteLine(GameConstant.soundEffectFlag);
        sw.WriteLine(GameConstant.backgroundFlag);
        sw.WriteLine(GameConstant.block2Flag);
        sw.Close();
      }
    }

    private void loadSetting()
    {
      using (StreamReader sr = File.OpenText(GameConstant.settingPath))
      {
        string s;
        int i = 0;
        bool[] settings = new bool[]
        {
          false, false, false
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
          } else if (j == 1)
          {
            GameConstant.backgroundFlag = settings[j];
          } else
          {
            GameConstant.block2Flag = settings[j];
          }
        }

        sr.Close();
      }
    }
  }
}
