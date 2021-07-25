namespace Caro_UDTM
{
    partial class MainForm
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
      this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.loadBtn = new System.Windows.Forms.Button();
      this.saveBtn = new System.Windows.Forms.Button();
      this.settingsBtn = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.playerOneScoreTxt = new System.Windows.Forms.Label();
      this.playerOneTitleLB = new System.Windows.Forms.Label();
      this.playerOneNameTxt = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.playerTwoScoreTxt = new System.Windows.Forms.Label();
      this.playerTwoTitleLB = new System.Windows.Forms.Label();
      this.playerTwoNameTxt = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.mainTablePanel.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // mainTablePanel
      // 
      this.mainTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.mainTablePanel.ColumnCount = 3;
      this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.mainTablePanel.Controls.Add(this.panel2, 0, 0);
      this.mainTablePanel.Controls.Add(this.panel1, 2, 0);
      this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainTablePanel.Location = new System.Drawing.Point(0, 0);
      this.mainTablePanel.Margin = new System.Windows.Forms.Padding(2);
      this.mainTablePanel.Name = "mainTablePanel";
      this.mainTablePanel.RowCount = 1;
      this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 619F));
      this.mainTablePanel.Size = new System.Drawing.Size(1127, 619);
      this.mainTablePanel.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.loadBtn);
      this.panel2.Controls.Add(this.saveBtn);
      this.panel2.Controls.Add(this.settingsBtn);
      this.panel2.Controls.Add(this.button1);
      this.panel2.Controls.Add(this.playerOneScoreTxt);
      this.panel2.Controls.Add(this.playerOneTitleLB);
      this.panel2.Controls.Add(this.playerOneNameTxt);
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(2, 2);
      this.panel2.Margin = new System.Windows.Forms.Padding(2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(221, 615);
      this.panel2.TabIndex = 1;
      // 
      // loadBtn
      // 
      this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loadBtn.ForeColor = System.Drawing.Color.Black;
      this.loadBtn.Location = new System.Drawing.Point(54, 435);
      this.loadBtn.Margin = new System.Windows.Forms.Padding(2);
      this.loadBtn.Name = "loadBtn";
      this.loadBtn.Size = new System.Drawing.Size(114, 37);
      this.loadBtn.TabIndex = 3;
      this.loadBtn.Text = "LOAD";
      this.loadBtn.UseVisualStyleBackColor = false;
      this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
      // 
      // saveBtn
      // 
      this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.saveBtn.ForeColor = System.Drawing.Color.Black;
      this.saveBtn.Location = new System.Drawing.Point(54, 379);
      this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(114, 37);
      this.saveBtn.TabIndex = 3;
      this.saveBtn.Text = "SAVE";
      this.saveBtn.UseVisualStyleBackColor = false;
      this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
      // 
      // settingsBtn
      // 
      this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.settingsBtn.ForeColor = System.Drawing.Color.Black;
      this.settingsBtn.Location = new System.Drawing.Point(54, 323);
      this.settingsBtn.Margin = new System.Windows.Forms.Padding(2);
      this.settingsBtn.Name = "settingsBtn";
      this.settingsBtn.Size = new System.Drawing.Size(114, 37);
      this.settingsBtn.TabIndex = 3;
      this.settingsBtn.Text = "SETTINGS";
      this.settingsBtn.UseVisualStyleBackColor = false;
      this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.Black;
      this.button1.Location = new System.Drawing.Point(54, 267);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(114, 37);
      this.button1.TabIndex = 3;
      this.button1.Text = "UNDO";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // playerOneScoreTxt
      // 
      this.playerOneScoreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.playerOneScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerOneScoreTxt.ForeColor = System.Drawing.Color.White;
      this.playerOneScoreTxt.Location = new System.Drawing.Point(2, 229);
      this.playerOneScoreTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.playerOneScoreTxt.Name = "playerOneScoreTxt";
      this.playerOneScoreTxt.Size = new System.Drawing.Size(217, 20);
      this.playerOneScoreTxt.TabIndex = 2;
      this.playerOneScoreTxt.Text = "0";
      this.playerOneScoreTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // playerOneTitleLB
      // 
      this.playerOneTitleLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.playerOneTitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerOneTitleLB.ForeColor = System.Drawing.Color.White;
      this.playerOneTitleLB.Location = new System.Drawing.Point(2, 198);
      this.playerOneTitleLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.playerOneTitleLB.Name = "playerOneTitleLB";
      this.playerOneTitleLB.Size = new System.Drawing.Size(217, 20);
      this.playerOneTitleLB.TabIndex = 2;
      this.playerOneTitleLB.Text = "SILVER";
      this.playerOneTitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // playerOneNameTxt
      // 
      this.playerOneNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.playerOneNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerOneNameTxt.ForeColor = System.Drawing.Color.White;
      this.playerOneNameTxt.Location = new System.Drawing.Point(2, 163);
      this.playerOneNameTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.playerOneNameTxt.Name = "playerOneNameTxt";
      this.playerOneNameTxt.Size = new System.Drawing.Size(217, 24);
      this.playerOneNameTxt.TabIndex = 1;
      this.playerOneNameTxt.Text = "NGUYEN VAN A";
      this.playerOneNameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox1.Image = global::Caro_UDTM.Properties.Resources.astronaut;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(221, 128);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.playerTwoScoreTxt);
      this.panel1.Controls.Add(this.playerTwoTitleLB);
      this.panel1.Controls.Add(this.playerTwoNameTxt);
      this.panel1.Controls.Add(this.pictureBox2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(903, 2);
      this.panel1.Margin = new System.Windows.Forms.Padding(2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(222, 615);
      this.panel1.TabIndex = 2;
      // 
      // playerTwoScoreTxt
      // 
      this.playerTwoScoreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.playerTwoScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerTwoScoreTxt.ForeColor = System.Drawing.Color.White;
      this.playerTwoScoreTxt.Location = new System.Drawing.Point(4, 229);
      this.playerTwoScoreTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.playerTwoScoreTxt.Name = "playerTwoScoreTxt";
      this.playerTwoScoreTxt.Size = new System.Drawing.Size(220, 20);
      this.playerTwoScoreTxt.TabIndex = 5;
      this.playerTwoScoreTxt.Text = "0";
      this.playerTwoScoreTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // playerTwoTitleLB
      // 
      this.playerTwoTitleLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.playerTwoTitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerTwoTitleLB.ForeColor = System.Drawing.Color.White;
      this.playerTwoTitleLB.Location = new System.Drawing.Point(2, 198);
      this.playerTwoTitleLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.playerTwoTitleLB.Name = "playerTwoTitleLB";
      this.playerTwoTitleLB.Size = new System.Drawing.Size(220, 20);
      this.playerTwoTitleLB.TabIndex = 5;
      this.playerTwoTitleLB.Text = "SILVER";
      this.playerTwoTitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // playerTwoNameTxt
      // 
      this.playerTwoNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.playerTwoNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerTwoNameTxt.ForeColor = System.Drawing.Color.White;
      this.playerTwoNameTxt.Location = new System.Drawing.Point(2, 163);
      this.playerTwoNameTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.playerTwoNameTxt.Name = "playerTwoNameTxt";
      this.playerTwoNameTxt.Size = new System.Drawing.Size(218, 24);
      this.playerTwoNameTxt.TabIndex = 4;
      this.playerTwoNameTxt.Text = "NGUYEN VAN A";
      this.playerTwoNameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox2.Image = global::Caro_UDTM.Properties.Resources.ninja;
      this.pictureBox2.Location = new System.Drawing.Point(0, 0);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(222, 145);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1127, 619);
      this.Controls.Add(this.mainTablePanel);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximumSize = new System.Drawing.Size(1143, 655);
      this.MinimumSize = new System.Drawing.Size(1143, 655);
      this.Name = "MainForm";
      this.Text = "GAME CARO";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.mainTablePanel.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label playerOneNameTxt;
        private System.Windows.Forms.Label playerOneTitleLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playerTwoTitleLB;
        private System.Windows.Forms.Label playerTwoNameTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button settingsBtn;
    private System.Windows.Forms.Button loadBtn;
    private System.Windows.Forms.Button saveBtn;
    private System.Windows.Forms.Label playerOneScoreTxt;
    private System.Windows.Forms.Label playerTwoScoreTxt;
  }
}

