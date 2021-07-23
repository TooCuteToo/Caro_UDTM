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
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.playerOneNameTxt = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.playerTwoNameTxt = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.settingsBtn = new System.Windows.Forms.Button();
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
      this.panel2.Controls.Add(this.settingsBtn);
      this.panel2.Controls.Add(this.button1);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.playerOneNameTxt);
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(2, 2);
      this.panel2.Margin = new System.Windows.Forms.Padding(2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(221, 615);
      this.panel2.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.Black;
      this.button1.Location = new System.Drawing.Point(40, 298);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(114, 37);
      this.button1.TabIndex = 3;
      this.button1.Text = "UNDO";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(53, 198);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(94, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "BEGINNER";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // playerOneNameTxt
      // 
      this.playerOneNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.playerOneNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerOneNameTxt.ForeColor = System.Drawing.Color.White;
      this.playerOneNameTxt.Location = new System.Drawing.Point(28, 163);
      this.playerOneNameTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.playerOneNameTxt.Name = "playerOneNameTxt";
      this.playerOneNameTxt.Size = new System.Drawing.Size(153, 24);
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
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.playerTwoNameTxt);
      this.panel1.Controls.Add(this.pictureBox2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(903, 2);
      this.panel1.Margin = new System.Windows.Forms.Padding(2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(222, 615);
      this.panel1.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(59, 198);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "BEGINNER";
      // 
      // playerTwoNameTxt
      // 
      this.playerTwoNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.playerTwoNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerTwoNameTxt.ForeColor = System.Drawing.Color.White;
      this.playerTwoNameTxt.Location = new System.Drawing.Point(17, 163);
      this.playerTwoNameTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.playerTwoNameTxt.Name = "playerTwoNameTxt";
      this.playerTwoNameTxt.Size = new System.Drawing.Size(153, 24);
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
      // settingsBtn
      // 
      this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.settingsBtn.ForeColor = System.Drawing.Color.Black;
      this.settingsBtn.Location = new System.Drawing.Point(40, 362);
      this.settingsBtn.Margin = new System.Windows.Forms.Padding(2);
      this.settingsBtn.Name = "settingsBtn";
      this.settingsBtn.Size = new System.Drawing.Size(114, 37);
      this.settingsBtn.TabIndex = 3;
      this.settingsBtn.Text = "SETTINGS";
      this.settingsBtn.UseVisualStyleBackColor = false;
      this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
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
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label playerOneNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerTwoNameTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button settingsBtn;
  }
}

