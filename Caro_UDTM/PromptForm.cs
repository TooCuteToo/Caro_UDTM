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
    public partial class PromptForm : Form
    {
        ComboBox comboBox;
        Label label;
        TextBox textBox2;

        public PromptForm(string caption, int gameType)
        {
            InitializeComponent();
            this.Text = caption;

            label = new Label()
            {
                Location = new Point(32, 101),
                Size = new Size(120, 24),
                Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
            };

            if (gameType == 1)
            {
                comboBox = new ComboBox()
                {
                    Location = new Point(153, 101),
                    Size = new Size(244, 27),
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    DropDownStyle = ComboBoxStyle.DropDownList,
                };

                label.Text = "DIFFICULTY";

                this.Controls.Add(label);
                this.Controls.Add(comboBox);
                initDifficulty();
            }
            else
            {
                textBox2 = new TextBox()
                {
                    Location = new Point(153, 101),
                    Size = new Size(244, 27),
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                };

                label.Text = "NAME 2:";

                this.Controls.Add(label);
                this.Controls.Add(textBox2);
            }
        }

        private void initDifficulty()
        {
            comboBox.Items.Add("EASY");
            comboBox.Items.Add("MEDIUM");
            comboBox.Items.Add("HARD");

            comboBox.SelectedIndex = 0;
        }

        public object[] showDialog()
        {
            if (this.ShowDialog() == DialogResult.OK)
            {
                if (textBox1.Text == "") textBox1.Text = "NGUYEN VAN A";

                return new object[2] { textBox1.Text, (string) comboBox.SelectedItem };
            }

            return new object[2] { null, (string) comboBox.SelectedItem };
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
    }
}
