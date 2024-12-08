using WinFormBase.ViewModels.Bases;
using WinFormBase.ViewModels.Tests;

namespace WinFormBase.Views;

public partial class TestView : BaseView
{
    private readonly TestViewModel _viewModel;
    public TestView()
    {
        this.InitializeComponent();

        this._viewModel = new();

        this.Bind(this._viewModel);

        /* ----- DataGridViewGroup ----- */

        this.TestDataGrid.DataSource = this._viewModel.TestGridItems;
        this.TestDataGrid.Columns[nameof(TestGridViewModel.DisplayIndex)].DisplayIndex = 0;
        this.TestDataGrid.Columns[nameof(TestGridViewModel.UserName)].DataPropertyName = nameof(TestGridViewModel.UserName);
        this.TestDataGrid.Columns[nameof(TestGridViewModel.UserEmail)].DataPropertyName = nameof(TestGridViewModel.UserEmail);

        this.TestDataGrid.SelectionChanged += (_, __) => this._viewModel.GridSelectedIndex = this.TestDataGrid.CurrentRow.Index;

        this.AddRowButton.Click += (_, __) => this._viewModel.AddGridItem();
        this.DeleteButton.Click += (_, __) => this._viewModel.DeleteGridItem();
        /* ---------- */

        /* ----- ProgressGroup ----- */
        this.ProgressManualButton.Click += (_, __) => this._viewModel.ProgressManual();
        this.ProgressAutoButton.Click += (_, __) => this._viewModel.ProgressAuto();
        /* ---------- */

        this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void StatusLableChangeButton_Click(object? sender, EventArgs e)
    {
        this._viewModel.StatusLableText = "ステータスバー変更";
    }
}
