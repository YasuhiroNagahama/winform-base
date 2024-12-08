namespace WinFormBase.Presentation.Views.Tests;

partial class TestView
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
        this.ProgressManualButton = new Button();
        this.ProgressAutoButton = new Button();
        this.StatusLableChangeButton = new Button();
        this.ProgressGroupBox = new GroupBox();
        this.DataGridViewGroup = new GroupBox();
        this.TestDataGrid = new DataGridView();
        this.AddRowButton = new Button();
        this.DeleteButton = new Button();
        this.ProgressGroupBox.SuspendLayout();
        this.DataGridViewGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.TestDataGrid).BeginInit();
        this.SuspendLayout();
        // 
        // ProgressManualButton
        // 
        this.ProgressManualButton.Font = new Font("Yu Gothic UI", 14F);
        this.ProgressManualButton.Location = new Point(6, 22);
        this.ProgressManualButton.Name = "ProgressManualButton";
        this.ProgressManualButton.Size = new Size(138, 41);
        this.ProgressManualButton.TabIndex = 1;
        this.ProgressManualButton.Text = "Progress手動";
        this.ProgressManualButton.UseVisualStyleBackColor = true;
        // 
        // ProgressAutoButton
        // 
        this.ProgressAutoButton.Font = new Font("Yu Gothic UI", 14F);
        this.ProgressAutoButton.Location = new Point(6, 69);
        this.ProgressAutoButton.Name = "ProgressAutoButton";
        this.ProgressAutoButton.Size = new Size(138, 41);
        this.ProgressAutoButton.TabIndex = 2;
        this.ProgressAutoButton.Text = "Progress自動";
        this.ProgressAutoButton.UseVisualStyleBackColor = true;
        // 
        // StatusLableChangeButton
        // 
        this.StatusLableChangeButton.Font = new Font("Yu Gothic UI", 14F);
        this.StatusLableChangeButton.Location = new Point(6, 116);
        this.StatusLableChangeButton.Name = "StatusLableChangeButton";
        this.StatusLableChangeButton.Size = new Size(181, 41);
        this.StatusLableChangeButton.TabIndex = 3;
        this.StatusLableChangeButton.Text = "ステータスラベル変更";
        this.StatusLableChangeButton.UseVisualStyleBackColor = true;
        // 
        // ProgressGroupBox
        // 
        this.ProgressGroupBox.Controls.Add(this.ProgressManualButton);
        this.ProgressGroupBox.Controls.Add(this.StatusLableChangeButton);
        this.ProgressGroupBox.Controls.Add(this.ProgressAutoButton);
        this.ProgressGroupBox.Location = new Point(12, 398);
        this.ProgressGroupBox.Name = "ProgressGroupBox";
        this.ProgressGroupBox.Size = new Size(200, 171);
        this.ProgressGroupBox.TabIndex = 4;
        this.ProgressGroupBox.TabStop = false;
        this.ProgressGroupBox.Text = "ProgressGroup";
        // 
        // DataGridViewGroup
        // 
        this.DataGridViewGroup.Controls.Add(this.DeleteButton);
        this.DataGridViewGroup.Controls.Add(this.AddRowButton);
        this.DataGridViewGroup.Controls.Add(this.TestDataGrid);
        this.DataGridViewGroup.Location = new Point(12, 12);
        this.DataGridViewGroup.Name = "DataGridViewGroup";
        this.DataGridViewGroup.Size = new Size(488, 254);
        this.DataGridViewGroup.TabIndex = 5;
        this.DataGridViewGroup.TabStop = false;
        this.DataGridViewGroup.Text = "DataGridViewGroup";
        // 
        // dataGridView1
        // 
        this.TestDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.TestDataGrid.Dock = DockStyle.Top;
        this.TestDataGrid.Location = new Point(3, 19);
        this.TestDataGrid.Name = "dataGridView1";
        this.TestDataGrid.Size = new Size(482, 187);
        this.TestDataGrid.TabIndex = 0;
        // 
        // AddRowButton
        // 
        this.AddRowButton.Font = new Font("Yu Gothic UI", 14F);
        this.AddRowButton.Location = new Point(6, 212);
        this.AddRowButton.Name = "AddRowButton";
        this.AddRowButton.Size = new Size(135, 33);
        this.AddRowButton.TabIndex = 1;
        this.AddRowButton.Text = "追加";
        this.AddRowButton.UseVisualStyleBackColor = true;
        // 
        // DeleteButton
        // 
        this.DeleteButton.Font = new Font("Yu Gothic UI", 14F);
        this.DeleteButton.Location = new Point(147, 212);
        this.DeleteButton.Name = "DeleteButton";
        this.DeleteButton.Size = new Size(135, 33);
        this.DeleteButton.TabIndex = 2;
        this.DeleteButton.Text = "削除";
        this.DeleteButton.UseVisualStyleBackColor = true;
        // 
        // TestView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1165, 602);
        this.Controls.Add(this.DataGridViewGroup);
        this.Controls.Add(this.ProgressGroupBox);
        this.Name = "TestView";
        this.Text = "TestView";
        this.Controls.SetChildIndex(this.ProgressGroupBox, 0);
        this.Controls.SetChildIndex(this.DataGridViewGroup, 0);
        this.ProgressGroupBox.ResumeLayout(false);
        this.DataGridViewGroup.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.TestDataGrid).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Button ProgressManualButton;
    private Button ProgressAutoButton;
    private Button StatusLableChangeButton;
    private GroupBox ProgressGroupBox;
    private GroupBox DataGridViewGroup;
    private DataGridView TestDataGrid;
    private Button DeleteButton;
    private Button AddRowButton;
}