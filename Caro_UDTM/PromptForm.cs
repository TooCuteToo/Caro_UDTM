using Caro_UDTM.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_UDTM
{
  public partial class PromptForm : Form
  {
    ComboBox comboBox;
    Label label2;
    TextBox textBox2;
    Button okBtn;
    RadioButton hostRadio, connectRadio;
    GameMode gameType;
    Form context;

    public PromptForm(string caption, GameMode gameType, Form context)
    {
      InitializeComponent();

      this.Text = caption;
      this.gameType = gameType;
      this.context = context;

      initLabel();
      initTextBox();

      initDifficulty();
      initButton();

      initRadio();

      if (gameType == GameMode.OnePlayer)
      {
        label1.Text = "NAME:";
        label2.Text = "DIFFICULTY:";

        textBox1.Name = "nameInputTxt";
        textBox1.KeyPress += textBox_KeyPress;
        this.Controls.Add(textBox1);

        comboBox.Name = "difficutyCB";
        this.Controls.Add(comboBox);

        this.Controls.Add(label1);
        this.Controls.Add(label2);

        this.Controls.Add(okBtn);
      }
      else if (gameType == GameMode.TwoPlayer)
      {
        label1.Text = "NAME 1:";
        label2.Text = "NAME 2:";

        this.Controls.Add(label1);
        this.Controls.Add(label2);

        textBox1.Name = "playerOneNameTxt";
        textBox2.Name = "playerTwoNameTxt";

        textBox1.KeyPress += textBox_KeyPress;
        textBox2.KeyPress += textBox_KeyPress;

        this.Controls.Add(textBox1);

        this.Controls.Add(textBox2);

        this.Controls.Add(okBtn);
      }
      else
      {
        string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();

        label1.Font = GameConstant.mainFont;
        label1.Location = new Point(20, 65);
        label1.Text = "IP ADDRESS:";

        textBox1.Name = "ipTxt";
        textBox1.Text = myIP;
        textBox1.Enabled = false;

        this.Controls.Add(label1);
        this.Controls.Add(textBox1);

        this.Controls.Add(okBtn);

        this.Controls.Add(hostRadio);
        this.Controls.Add(connectRadio);
      }
    }

    private void initDifficulty()
    {
      comboBox = new ComboBox()
      {
        Location = new Point(145, 101),
        Size = new Size(244, 27),
        Font = GameConstant.mainFont,
        DropDownStyle = ComboBoxStyle.DropDownList,
      };

      comboBox.Items.Add("EASY");
      comboBox.Items.Add("MEDIUM");
      comboBox.Items.Add("HARD");

      comboBox.SelectedIndex = 0;
    }

    private void initLabel()
    {
      label1 = new Label()
      {
        Location = new Point(20, 60),
        Size = new Size(120, 24),
        Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
        ForeColor = Color.White,
      };

      label2 = new Label()
      {
        Location = new Point(20, 101),
        Size = new Size(120, 24),
        Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
        ForeColor = Color.White,
      };
    }

    private void initTextBox()
    {
      textBox1 = new TextBox()
      {
        Location = new Point(145, 60),
        Size = new Size(244, 27),
        Font = GameConstant.mainFont,
      };

      textBox2 = new TextBox()
      {
        Location = new Point(145, 101),
        Size = new Size(244, 27),
        Font = GameConstant.mainFont,
      };
    }

    private void initButton()
    {
      okBtn = new Button()
      {
        Location = new Point(145, 155),
        Size = new Size(185, 39),
        Font = GameConstant.mainFont,
        Text = "OK",
        BackColor = Color.FromArgb(241, 196, 15),
        ForeColor = Color.Black,
        FlatStyle = FlatStyle.Flat,
        DialogResult = DialogResult.OK,
      };

      okBtn.FlatAppearance.BorderSize = 0;

      if (gameType == GameMode.LAN)
      {
        okBtn.Click += lanBtn_click;
      }
    }

    private void initRadio()
    {
      hostRadio = new RadioButton()
      {
        Location = new Point(110, 111),
        Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
        Checked = true,
        Text = "HOST",
        ForeColor = Color.White,
      };

      connectRadio = new RadioButton()
      {
        Location = new Point(220, 111),
        Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
        Text = "CONNECT",
        ForeColor = Color.White,
      };
    }

    public object[] showDialog()
    {
      if (this.ShowDialog() == DialogResult.OK)
      {
        if (textBox1.Text == "") textBox1.Text = "NGUYEN VAN A";

        return new object[2] { textBox1.Text, (string)comboBox.SelectedItem };
      }

      return new object[2] { null, (string)comboBox.SelectedItem };
    }

    public object[] showDialog2()
    {
      if (this.ShowDialog() == DialogResult.OK)
      {
        if (textBox1.Text == "") textBox1.Text = "NGUYEN VAN A";

        if (textBox2.Text == "") textBox2.Text = "NGUYEN VAN B";

        return new object[2] { textBox1.Text, textBox2.Text };
      }

      return new object[2] { null, "NGUYEN VAN B" };
    }

    private void lanBtn_click(object sender, EventArgs e)
    {
      MainForm game;

      if (hostRadio.Checked)
      {
        game = new MainForm(GameMode.LAN, true, textBox1.Text);
        this.Visible = false;
        context.Visible = false;
        if (!game.IsDisposed) game.ShowDialog();
        context.Visible = true;
        return;
      }

      game = new MainForm(GameMode.LAN, false, textBox1.Text);
      this.Visible = false;
      context.Visible = false;
      if (!game.IsDisposed) game.ShowDialog();
      context.Visible = true;
      return;
    }

    private void textBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      var regex = new Regex(@"[^a-zA-Z\s]");
      if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
      {
        e.Handled = true;
      }
    }

  }
}
