using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace Caro_UDTM
{
    public partial class MenuForm : Form
    {
        private String userName;
        PromptForm prompt;

        public MenuForm()
        {
            InitializeComponent();
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
            prompt = new PromptForm("NAME INPUT", 1);

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

            string name = (string) result[0];
            string difficulty = (string)result[1];

            MainForm game = new MainForm(1, name, getDifficulty(difficulty), true);
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

            MainForm game = new MainForm(1, name, getDifficulty(difficulty), false);
            Visible = false;
            game.ShowDialog();
            Visible = true;
        }

        private void twoPlayerBtn_Click(object sender, EventArgs e)
        {
            prompt = new PromptForm("NAME INPUT", 2);
            object[] result = prompt.showDialog2();

            if (result[0] == null) return;

            MainForm game = new MainForm(2, false);
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
            int iWidth;

            if (leaderBtn.Text == "LEADERBOARD")
            {
                iWidth = 700;
                leaderBtn.Text = "BACK";
            }
            else
            {
                iWidth = 421;
                leaderBtn.Text = "LEADERBOARD";
            }

            Transition.run(this, "Width", iWidth, new TransitionType_EaseInEaseOut(500));
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
