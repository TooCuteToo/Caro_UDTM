namespace Caro_UDTM
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.gameModeMenu = new System.Windows.Forms.Panel();
      this.multiPlayerBtn = new System.Windows.Forms.Button();
      this.onePlayerBtn = new System.Windows.Forms.Button();
      this.twoPlayerBtn = new System.Windows.Forms.Button();
      this.mainMenu = new System.Windows.Forms.Panel();
      this.exitBtn = new System.Windows.Forms.Button();
      this.helpBtn = new System.Windows.Forms.Button();
      this.leaderBtn = new System.Windows.Forms.Button();
      this.settingBtn = new System.Windows.Forms.Button();
      this.startGameBtn = new System.Windows.Forms.Button();
      this.onePlayerMenu = new System.Windows.Forms.Panel();
      this.comComBtn = new System.Windows.Forms.Button();
      this.playerFirstBtn = new System.Windows.Forms.Button();
      this.comFirstBtn = new System.Windows.Forms.Button();
      this.leaderboardPanel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.gameModeMenu.SuspendLayout();
      this.mainMenu.SuspendLayout();
      this.onePlayerMenu.SuspendLayout();
      this.leaderboardPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // gameModeMenu
      // 
      this.gameModeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.gameModeMenu.Controls.Add(this.multiPlayerBtn);
      this.gameModeMenu.Controls.Add(this.onePlayerBtn);
      this.gameModeMenu.Controls.Add(this.twoPlayerBtn);
      this.gameModeMenu.Location = new System.Drawing.Point(-330, 252);
      this.gameModeMenu.Margin = new System.Windows.Forms.Padding(2);
      this.gameModeMenu.Name = "gameModeMenu";
      this.gameModeMenu.Size = new System.Drawing.Size(330, 202);
      this.gameModeMenu.TabIndex = 1;
      // 
      // multiPlayerBtn
      // 
      this.multiPlayerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.multiPlayerBtn.FlatAppearance.BorderSize = 0;
      this.multiPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.multiPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.multiPlayerBtn.ForeColor = System.Drawing.Color.Black;
      this.multiPlayerBtn.Location = new System.Drawing.Point(80, 140);
      this.multiPlayerBtn.Margin = new System.Windows.Forms.Padding(2);
      this.multiPlayerBtn.Name = "multiPlayerBtn";
      this.multiPlayerBtn.Size = new System.Drawing.Size(183, 46);
      this.multiPlayerBtn.TabIndex = 4;
      this.multiPlayerBtn.Text = "MULTIPLAYER";
      this.multiPlayerBtn.UseVisualStyleBackColor = false;
      this.multiPlayerBtn.Click += new System.EventHandler(this.multiPlayerBtn_Click);
      // 
      // onePlayerBtn
      // 
      this.onePlayerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.onePlayerBtn.FlatAppearance.BorderSize = 0;
      this.onePlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.onePlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.onePlayerBtn.ForeColor = System.Drawing.Color.Black;
      this.onePlayerBtn.Location = new System.Drawing.Point(81, 12);
      this.onePlayerBtn.Margin = new System.Windows.Forms.Padding(2);
      this.onePlayerBtn.Name = "onePlayerBtn";
      this.onePlayerBtn.Size = new System.Drawing.Size(183, 46);
      this.onePlayerBtn.TabIndex = 3;
      this.onePlayerBtn.Text = "1 PLAYER";
      this.onePlayerBtn.UseVisualStyleBackColor = false;
      this.onePlayerBtn.Click += new System.EventHandler(this.onePlayerBtn_Click);
      // 
      // twoPlayerBtn
      // 
      this.twoPlayerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.twoPlayerBtn.FlatAppearance.BorderSize = 0;
      this.twoPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.twoPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.twoPlayerBtn.ForeColor = System.Drawing.Color.Black;
      this.twoPlayerBtn.Location = new System.Drawing.Point(81, 76);
      this.twoPlayerBtn.Margin = new System.Windows.Forms.Padding(2);
      this.twoPlayerBtn.Name = "twoPlayerBtn";
      this.twoPlayerBtn.Size = new System.Drawing.Size(183, 46);
      this.twoPlayerBtn.TabIndex = 2;
      this.twoPlayerBtn.Text = "2 PLAYERS";
      this.twoPlayerBtn.UseVisualStyleBackColor = false;
      this.twoPlayerBtn.Click += new System.EventHandler(this.twoPlayerBtn_Click);
      // 
      // mainMenu
      // 
      this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.mainMenu.Controls.Add(this.exitBtn);
      this.mainMenu.Controls.Add(this.helpBtn);
      this.mainMenu.Controls.Add(this.leaderBtn);
      this.mainMenu.Controls.Add(this.settingBtn);
      this.mainMenu.Location = new System.Drawing.Point(9, 252);
      this.mainMenu.Margin = new System.Windows.Forms.Padding(2);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Size = new System.Drawing.Size(330, 266);
      this.mainMenu.TabIndex = 2;
      // 
      // exitBtn
      // 
      this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.exitBtn.FlatAppearance.BorderSize = 0;
      this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.exitBtn.ForeColor = System.Drawing.Color.Black;
      this.exitBtn.Location = new System.Drawing.Point(81, 202);
      this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
      this.exitBtn.Name = "exitBtn";
      this.exitBtn.Size = new System.Drawing.Size(183, 46);
      this.exitBtn.TabIndex = 5;
      this.exitBtn.Text = "EXIT";
      this.exitBtn.UseVisualStyleBackColor = false;
      this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
      // 
      // helpBtn
      // 
      this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.helpBtn.FlatAppearance.BorderSize = 0;
      this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.helpBtn.ForeColor = System.Drawing.Color.Black;
      this.helpBtn.Location = new System.Drawing.Point(80, 139);
      this.helpBtn.Margin = new System.Windows.Forms.Padding(2);
      this.helpBtn.Name = "helpBtn";
      this.helpBtn.Size = new System.Drawing.Size(183, 46);
      this.helpBtn.TabIndex = 4;
      this.helpBtn.Text = "HELP";
      this.helpBtn.UseVisualStyleBackColor = false;
      this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
      // 
      // leaderBtn
      // 
      this.leaderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.leaderBtn.FlatAppearance.BorderSize = 0;
      this.leaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.leaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.leaderBtn.ForeColor = System.Drawing.Color.Black;
      this.leaderBtn.Location = new System.Drawing.Point(80, 76);
      this.leaderBtn.Margin = new System.Windows.Forms.Padding(2);
      this.leaderBtn.Name = "leaderBtn";
      this.leaderBtn.Size = new System.Drawing.Size(183, 46);
      this.leaderBtn.TabIndex = 3;
      this.leaderBtn.Text = "LEADERBOARD";
      this.leaderBtn.UseVisualStyleBackColor = false;
      this.leaderBtn.Click += new System.EventHandler(this.leaderBtn_Click);
      // 
      // settingBtn
      // 
      this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.settingBtn.FlatAppearance.BorderSize = 0;
      this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.settingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.settingBtn.ForeColor = System.Drawing.Color.Black;
      this.settingBtn.Location = new System.Drawing.Point(80, 12);
      this.settingBtn.Margin = new System.Windows.Forms.Padding(2);
      this.settingBtn.Name = "settingBtn";
      this.settingBtn.Size = new System.Drawing.Size(183, 46);
      this.settingBtn.TabIndex = 2;
      this.settingBtn.Text = "SETTINGS";
      this.settingBtn.UseVisualStyleBackColor = false;
      this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
      // 
      // startGameBtn
      // 
      this.startGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.startGameBtn.FlatAppearance.BorderSize = 0;
      this.startGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startGameBtn.ForeColor = System.Drawing.Color.Black;
      this.startGameBtn.Location = new System.Drawing.Point(89, 202);
      this.startGameBtn.Margin = new System.Windows.Forms.Padding(2);
      this.startGameBtn.Name = "startGameBtn";
      this.startGameBtn.Size = new System.Drawing.Size(183, 46);
      this.startGameBtn.TabIndex = 3;
      this.startGameBtn.Text = "START";
      this.startGameBtn.UseVisualStyleBackColor = false;
      this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
      // 
      // onePlayerMenu
      // 
      this.onePlayerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.onePlayerMenu.Controls.Add(this.comComBtn);
      this.onePlayerMenu.Controls.Add(this.playerFirstBtn);
      this.onePlayerMenu.Controls.Add(this.comFirstBtn);
      this.onePlayerMenu.Location = new System.Drawing.Point(-330, 252);
      this.onePlayerMenu.Margin = new System.Windows.Forms.Padding(2);
      this.onePlayerMenu.Name = "onePlayerMenu";
      this.onePlayerMenu.Size = new System.Drawing.Size(330, 202);
      this.onePlayerMenu.TabIndex = 4;
      // 
      // comComBtn
      // 
      this.comComBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.comComBtn.FlatAppearance.BorderSize = 0;
      this.comComBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.comComBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comComBtn.ForeColor = System.Drawing.Color.Black;
      this.comComBtn.Location = new System.Drawing.Point(81, 139);
      this.comComBtn.Margin = new System.Windows.Forms.Padding(2);
      this.comComBtn.Name = "comComBtn";
      this.comComBtn.Size = new System.Drawing.Size(183, 46);
      this.comComBtn.TabIndex = 4;
      this.comComBtn.Text = "COM VS COM";
      this.comComBtn.UseVisualStyleBackColor = false;
      this.comComBtn.Click += new System.EventHandler(this.comComBtn_Click);
      // 
      // playerFirstBtn
      // 
      this.playerFirstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.playerFirstBtn.FlatAppearance.BorderSize = 0;
      this.playerFirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.playerFirstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerFirstBtn.ForeColor = System.Drawing.Color.Black;
      this.playerFirstBtn.Location = new System.Drawing.Point(81, 12);
      this.playerFirstBtn.Margin = new System.Windows.Forms.Padding(2);
      this.playerFirstBtn.Name = "playerFirstBtn";
      this.playerFirstBtn.Size = new System.Drawing.Size(183, 46);
      this.playerFirstBtn.TabIndex = 3;
      this.playerFirstBtn.Text = "PLAYER FIRST";
      this.playerFirstBtn.UseVisualStyleBackColor = false;
      this.playerFirstBtn.Click += new System.EventHandler(this.playerFirstBtn_Click);
      // 
      // comFirstBtn
      // 
      this.comFirstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.comFirstBtn.FlatAppearance.BorderSize = 0;
      this.comFirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.comFirstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comFirstBtn.ForeColor = System.Drawing.Color.Black;
      this.comFirstBtn.Location = new System.Drawing.Point(81, 76);
      this.comFirstBtn.Margin = new System.Windows.Forms.Padding(2);
      this.comFirstBtn.Name = "comFirstBtn";
      this.comFirstBtn.Size = new System.Drawing.Size(183, 46);
      this.comFirstBtn.TabIndex = 2;
      this.comFirstBtn.Text = "COMPUTER FIRST";
      this.comFirstBtn.UseVisualStyleBackColor = false;
      this.comFirstBtn.Click += new System.EventHandler(this.comFirstBtn_Click);
      // 
      // leaderboardPanel
      // 
      this.leaderboardPanel.Controls.Add(this.label1);
      this.leaderboardPanel.Location = new System.Drawing.Point(416, 6);
      this.leaderboardPanel.Margin = new System.Windows.Forms.Padding(2);
      this.leaderboardPanel.Name = "leaderboardPanel";
      this.leaderboardPanel.Size = new System.Drawing.Size(343, 563);
      this.leaderboardPanel.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 41);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Caro_UDTM.Properties.Resources.menu_o_icon;
      this.pictureBox1.Location = new System.Drawing.Point(90, 47);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(183, 126);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // MenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.ClientSize = new System.Drawing.Size(348, 540);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.leaderboardPanel);
      this.Controls.Add(this.onePlayerMenu);
      this.Controls.Add(this.gameModeMenu);
      this.Controls.Add(this.startGameBtn);
      this.Controls.Add(this.mainMenu);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximumSize = new System.Drawing.Size(364, 576);
      this.MinimumSize = new System.Drawing.Size(364, 576);
      this.Name = "MenuForm";
      this.Text = "GAME CARO";
      this.gameModeMenu.ResumeLayout(false);
      this.mainMenu.ResumeLayout(false);
      this.onePlayerMenu.ResumeLayout(false);
      this.leaderboardPanel.ResumeLayout(false);
      this.leaderboardPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameModeMenu;
        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button onePlayerBtn;
        private System.Windows.Forms.Button twoPlayerBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button leaderBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button multiPlayerBtn;
        private System.Windows.Forms.Panel onePlayerMenu;
        private System.Windows.Forms.Button playerFirstBtn;
        private System.Windows.Forms.Button comFirstBtn;
        private System.Windows.Forms.Panel leaderboardPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button comComBtn;
    }
}