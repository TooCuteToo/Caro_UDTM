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
            this.gameModeMenu = new System.Windows.Forms.Panel();
            this.multiPlayerBtn = new System.Windows.Forms.Button();
            this.onePlayerBtn = new System.Windows.Forms.Button();
            this.twoPlayerBtn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.leaderBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.onePlayerMenu = new System.Windows.Forms.Panel();
            this.playerFirstBtn = new System.Windows.Forms.Button();
            this.comFirstBtn = new System.Windows.Forms.Button();
            this.gameModeMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.onePlayerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameModeMenu
            // 
            this.gameModeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gameModeMenu.Controls.Add(this.multiPlayerBtn);
            this.gameModeMenu.Controls.Add(this.onePlayerBtn);
            this.gameModeMenu.Controls.Add(this.twoPlayerBtn);
            this.gameModeMenu.Location = new System.Drawing.Point(-390, 246);
            this.gameModeMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameModeMenu.Name = "gameModeMenu";
            this.gameModeMenu.Size = new System.Drawing.Size(390, 217);
            this.gameModeMenu.TabIndex = 1;
            // 
            // multiPlayerBtn
            // 
            this.multiPlayerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.multiPlayerBtn.FlatAppearance.BorderSize = 0;
            this.multiPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiPlayerBtn.Location = new System.Drawing.Point(110, 156);
            this.multiPlayerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.multiPlayerBtn.Name = "multiPlayerBtn";
            this.multiPlayerBtn.Size = new System.Drawing.Size(183, 46);
            this.multiPlayerBtn.TabIndex = 4;
            this.multiPlayerBtn.Text = "MULTIPLAYER";
            this.multiPlayerBtn.UseVisualStyleBackColor = false;
            // 
            // onePlayerBtn
            // 
            this.onePlayerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.onePlayerBtn.FlatAppearance.BorderSize = 0;
            this.onePlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.onePlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onePlayerBtn.Location = new System.Drawing.Point(110, 18);
            this.onePlayerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.twoPlayerBtn.Location = new System.Drawing.Point(110, 87);
            this.twoPlayerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.mainMenu.Controls.Add(this.leaderBtn);
            this.mainMenu.Controls.Add(this.settingBtn);
            this.mainMenu.Location = new System.Drawing.Point(9, 246);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(390, 217);
            this.mainMenu.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(110, 154);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(183, 46);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // leaderBtn
            // 
            this.leaderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.leaderBtn.FlatAppearance.BorderSize = 0;
            this.leaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderBtn.ForeColor = System.Drawing.Color.Black;
            this.leaderBtn.Location = new System.Drawing.Point(110, 84);
            this.leaderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leaderBtn.Name = "leaderBtn";
            this.leaderBtn.Size = new System.Drawing.Size(183, 46);
            this.leaderBtn.TabIndex = 3;
            this.leaderBtn.Text = "LEADERBOARDS";
            this.leaderBtn.UseVisualStyleBackColor = false;
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.Black;
            this.settingBtn.Location = new System.Drawing.Point(110, 15);
            this.settingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(183, 46);
            this.settingBtn.TabIndex = 2;
            this.settingBtn.Text = "SETTINGS";
            this.settingBtn.UseVisualStyleBackColor = false;
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.startGameBtn.FlatAppearance.BorderSize = 0;
            this.startGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.ForeColor = System.Drawing.Color.Black;
            this.startGameBtn.Location = new System.Drawing.Point(119, 183);
            this.startGameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.onePlayerMenu.Controls.Add(this.playerFirstBtn);
            this.onePlayerMenu.Controls.Add(this.comFirstBtn);
            this.onePlayerMenu.Location = new System.Drawing.Point(-390, 246);
            this.onePlayerMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.onePlayerMenu.Name = "onePlayerMenu";
            this.onePlayerMenu.Size = new System.Drawing.Size(390, 214);
            this.onePlayerMenu.TabIndex = 4;
            // 
            // playerFirstBtn
            // 
            this.playerFirstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.playerFirstBtn.FlatAppearance.BorderSize = 0;
            this.playerFirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playerFirstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerFirstBtn.Location = new System.Drawing.Point(110, 15);
            this.playerFirstBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.comFirstBtn.Location = new System.Drawing.Point(110, 84);
            this.comFirstBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comFirstBtn.Name = "comFirstBtn";
            this.comFirstBtn.Size = new System.Drawing.Size(183, 46);
            this.comFirstBtn.TabIndex = 2;
            this.comFirstBtn.Text = "COMPUTER FIRST";
            this.comFirstBtn.UseVisualStyleBackColor = false;
            this.comFirstBtn.Click += new System.EventHandler(this.comFirstBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(409, 570);
            this.Controls.Add(this.onePlayerMenu);
            this.Controls.Add(this.gameModeMenu);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.mainMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(425, 609);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.gameModeMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.onePlayerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameModeMenu;
        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button onePlayerBtn;
        private System.Windows.Forms.Button twoPlayerBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button leaderBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button multiPlayerBtn;
        private System.Windows.Forms.Panel onePlayerMenu;
        private System.Windows.Forms.Button playerFirstBtn;
        private System.Windows.Forms.Button comFirstBtn;
    }
}