using WinFormBase.WinForm.Controls;

namespace WinFormBase.WinForm.Views.Bases;

partial class BaseView
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
        this.BaseStatusStrip = new StatusStrip();
        this.StatusProgress = new BindableToolStripProgressBar();
        this.StatusLabel = new BindableToolStripStatusLabel();
        this.UserInfoStatusLabel = new BindableToolStripStatusLabel();
        this.DebugModeStatusLabel = new BindableToolStripStatusLabel();
        this.BaseStatusStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // BaseStatusStrip
        // 
        this.BaseStatusStrip.Font = new Font("Yu Gothic UI", 14F);
        this.BaseStatusStrip.Items.AddRange(new ToolStripItem[] { this.StatusProgress, this.StatusLabel, this.UserInfoStatusLabel, this.DebugModeStatusLabel });
        this.BaseStatusStrip.Location = new Point(0, 405);
        this.BaseStatusStrip.Name = "BaseStatusStrip";
        this.BaseStatusStrip.Size = new Size(880, 30);
        this.BaseStatusStrip.TabIndex = 0;
        this.BaseStatusStrip.Text = "BaseStatusStrip";
        // 
        // StatusProgress
        // 
        this.StatusProgress.Name = "StatusProgress";
        this.StatusProgress.Size = new Size(100, 24);
        // 
        // StatusLabel
        // 
        this.StatusLabel.Name = "StatusLabel";
        this.StatusLabel.Size = new Size(108, 25);
        this.StatusLabel.Text = "StatusLabel";
        // 
        // UserInfoStatusLabel
        // 
        this.UserInfoStatusLabel.BackColor = SystemColors.ActiveCaption;
        this.UserInfoStatusLabel.Name = "UserInfoStatusLabel";
        this.UserInfoStatusLabel.Size = new Size(179, 25);
        this.UserInfoStatusLabel.Text = "UserInfoStatusLabel";
        // 
        // DebugModeStatusLabel
        // 
        this.DebugModeStatusLabel.BackColor = Color.Red;
        this.DebugModeStatusLabel.Name = "DebugModeStatusLabel";
        this.DebugModeStatusLabel.Size = new Size(213, 25);
        this.DebugModeStatusLabel.Text = "DebugModeStatusLabel";
        // 
        // BaseView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(880, 435);
        this.Controls.Add(this.BaseStatusStrip);
        this.Name = "BaseView";
        this.Text = "WinFormBase";
        this.BaseStatusStrip.ResumeLayout(false);
        this.BaseStatusStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private StatusStrip BaseStatusStrip;
    private BindableToolStripProgressBar StatusProgress;
    private BindableToolStripStatusLabel StatusLabel;
    private BindableToolStripStatusLabel UserInfoStatusLabel;
    private BindableToolStripStatusLabel DebugModeStatusLabel;
}