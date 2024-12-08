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
        this.StatusProgress = new ToolStripProgressBar();
        this.StatusLabel = new ToolStripStatusLabel();
        this.DebugStatusLabel = new ToolStripStatusLabel();
        this.BaseStatusStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // BaseStatusStrip
        // 
        this.BaseStatusStrip.Font = new Font("Yu Gothic UI", 14F);
        this.BaseStatusStrip.Items.AddRange(new ToolStripItem[] { this.StatusProgress, this.StatusLabel, this.DebugStatusLabel });
        this.BaseStatusStrip.Location = new Point(0, 222);
        this.BaseStatusStrip.Name = "BaseStatusStrip";
        this.BaseStatusStrip.Size = new Size(598, 30);
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
        // DebugStatusLabel
        // 
        this.DebugStatusLabel.BackColor = Color.Red;
        this.DebugStatusLabel.Name = "DebugStatusLabel";
        this.DebugStatusLabel.RightToLeft = RightToLeft.No;
        this.DebugStatusLabel.Size = new Size(113, 25);
        this.DebugStatusLabel.Text = "DebugLabel";
        // 
        // BaseView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(598, 252);
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
    private ToolStripProgressBar StatusProgress;
    private ToolStripStatusLabel StatusLabel;
    private ToolStripStatusLabel DebugStatusLabel;
}