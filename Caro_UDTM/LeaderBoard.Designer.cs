namespace Caro_UDTM
{
  partial class LeaderBoard
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
      this.closeLeaderBtn = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // closeLeaderBtn
      // 
      this.closeLeaderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.closeLeaderBtn.FlatAppearance.BorderSize = 0;
      this.closeLeaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.closeLeaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.closeLeaderBtn.ForeColor = System.Drawing.Color.Black;
      this.closeLeaderBtn.Location = new System.Drawing.Point(104, 428);
      this.closeLeaderBtn.Margin = new System.Windows.Forms.Padding(2);
      this.closeLeaderBtn.Name = "closeLeaderBtn";
      this.closeLeaderBtn.Size = new System.Drawing.Size(183, 46);
      this.closeLeaderBtn.TabIndex = 5;
      this.closeLeaderBtn.Text = "CLOSE";
      this.closeLeaderBtn.UseVisualStyleBackColor = false;
      this.closeLeaderBtn.Click += new System.EventHandler(this.closeLeaderBtn_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.Color.White;
      this.label8.Location = new System.Drawing.Point(103, 25);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(184, 31);
      this.label8.TabIndex = 7;
      this.label8.Text = "TOP PLAYER";
      // 
      // LeaderBoard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.ClientSize = new System.Drawing.Size(384, 499);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.closeLeaderBtn);
      this.Name = "LeaderBoard";
      this.Text = "LeaderBoard";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button closeLeaderBtn;
    private System.Windows.Forms.Label label8;
  }
}