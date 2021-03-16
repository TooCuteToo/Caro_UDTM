using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_UDTM
{
    public partial class LANForm : Form
    {
        public LANForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm game = new MainForm(2, true);
            Visible = false;
            if (!game.IsDisposed) game.ShowDialog();
            Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm game = new MainForm(2, false, textBox1.Text);
            Visible = false;
            if (!game.IsDisposed) game.ShowDialog();
            Visible = true;
        }
    }
}
