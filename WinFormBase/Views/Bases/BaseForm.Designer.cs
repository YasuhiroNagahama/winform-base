namespace WinFormBase.Views;

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
        this.statusStrip1 = new StatusStrip();
        this.StatusProgress = new Controls.BindableToolStripProgressBar();
        this.StatusLabel = new Controls.BindableToolStripStatusLabel();
        this.statusStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // statusStrip1
        // 
        this.statusStrip1.Font = new Font("Yu Gothic UI", 14F);
        this.statusStrip1.Items.AddRange(new ToolStripItem[] { this.StatusProgress, this.StatusLabel });
        this.statusStrip1.Location = new Point(0, 420);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new Size(800, 30);
        this.statusStrip1.TabIndex = 0;
        this.statusStrip1.Text = "statusStrip1";
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
        // BaseView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.statusStrip1);
        this.Name = "BaseView";
        this.Text = "WinFormBase";
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private StatusStrip statusStrip1;
    private Controls.BindableToolStripStatusLabel StatusLabel;
    private Controls.BindableToolStripProgressBar StatusProgress;
}