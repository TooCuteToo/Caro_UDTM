namespace Caro_UDTM
{
  partial class SettingForm
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
      this.soundEffectSettingTxt = new System.Windows.Forms.Label();
      this.musicSettingTxt = new System.Windows.Forms.Label();
      this.saveSettingBtn = new System.Windows.Forms.Button();
      this.effectCB = new System.Windows.Forms.CheckBox();
      this.musicCB = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.block2CB = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // soundEffectSettingTxt
      // 
      this.soundEffectSettingTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.soundEffectSettingTxt.ForeColor = System.Drawing.Color.White;
      this.soundEffectSettingTxt.Location = new System.Drawing.Point(50, 25);
      this.soundEffectSettingTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.soundEffectSettingTxt.Name = "soundEffectSettingTxt";
      this.soundEffectSettingTxt.Size = new System.Drawing.Size(158, 24);
      this.soundEffectSettingTxt.TabIndex = 2;
      this.soundEffectSettingTxt.Text = "SOUND EFFECT";
      this.soundEffectSettingTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // musicSettingTxt
      // 
      this.musicSettingTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.musicSettingTxt.ForeColor = System.Drawing.Color.White;
      this.musicSettingTxt.Location = new System.Drawing.Point(50, 61);
      this.musicSettingTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.musicSettingTxt.Name = "musicSettingTxt";
      this.musicSettingTxt.Size = new System.Drawing.Size(158, 24);
      this.musicSettingTxt.TabIndex = 2;
      this.musicSettingTxt.Text = "MUSIC";
      this.musicSettingTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // saveSettingBtn
      // 
      this.saveSettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
      this.saveSettingBtn.FlatAppearance.BorderSize = 0;
      this.saveSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.saveSettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.saveSettingBtn.ForeColor = System.Drawing.Color.Black;
      this.saveSettingBtn.Location = new System.Drawing.Point(54, 147);
      this.saveSettingBtn.Margin = new System.Windows.Forms.Padding(2);
      this.saveSettingBtn.Name = "saveSettingBtn";
      this.saveSettingBtn.Size = new System.Drawing.Size(183, 46);
      this.saveSettingBtn.TabIndex = 4;
      this.saveSettingBtn.Text = "SAVE";
      this.saveSettingBtn.UseVisualStyleBackColor = false;
      this.saveSettingBtn.Click += new System.EventHandler(this.saveSettingBtn_Click);
      // 
      // effectCB
      // 
      this.effectCB.AutoSize = true;
      this.effectCB.Location = new System.Drawing.Point(222, 33);
      this.effectCB.Name = "effectCB";
      this.effectCB.Size = new System.Drawing.Size(15, 14);
      this.effectCB.TabIndex = 5;
      this.effectCB.UseVisualStyleBackColor = true;
      // 
      // musicCB
      // 
      this.musicCB.AutoSize = true;
      this.musicCB.Location = new System.Drawing.Point(222, 69);
      this.musicCB.Name = "musicCB";
      this.musicCB.Size = new System.Drawing.Size(15, 14);
      this.musicCB.TabIndex = 5;
      this.musicCB.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(50, 98);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(158, 24);
      this.label1.TabIndex = 2;
      this.label1.Text = "BLOCK 2";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // block2CB
      // 
      this.block2CB.AutoSize = true;
      this.block2CB.Location = new System.Drawing.Point(222, 106);
      this.block2CB.Name = "block2CB";
      this.block2CB.Size = new System.Drawing.Size(15, 14);
      this.block2CB.TabIndex = 5;
      this.block2CB.UseVisualStyleBackColor = true;
      // 
      // SettingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.ClientSize = new System.Drawing.Size(295, 204);
      this.Controls.Add(this.block2CB);
      this.Controls.Add(this.musicCB);
      this.Controls.Add(this.effectCB);
      this.Controls.Add(this.saveSettingBtn);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.musicSettingTxt);
      this.Controls.Add(this.soundEffectSettingTxt);
      this.MaximumSize = new System.Drawing.Size(311, 240);
      this.MinimumSize = new System.Drawing.Size(311, 240);
      this.Name = "SettingForm";
      this.Text = "SettingForm";
      this.Load += new System.EventHandler(this.SettingForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label soundEffectSettingTxt;
    private System.Windows.Forms.Label musicSettingTxt;
    private System.Windows.Forms.Button saveSettingBtn;
    private System.Windows.Forms.CheckBox effectCB;
    private System.Windows.Forms.CheckBox musicCB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox block2CB;
  }
}