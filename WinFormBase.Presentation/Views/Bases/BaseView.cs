using WinFormBase.WinForm.ViewModels.Bases;

namespace WinFormBase.WinForm.Views.Bases;

public partial class BaseView : Form
{
    public BaseView()
    {
        this.InitializeComponent();
    }

    protected void Bind(FormViewModelBase viewModelBase)
    {
        this.StatusProgress.DataBindings.Add(nameof(StatusProgress.Value), viewModelBase, nameof(viewModelBase.StatusProgressValue));
        this.StatusProgress.DataBindings.Add(nameof(StatusProgress.Maximum), viewModelBase, nameof(viewModelBase.StatusProgressMaximum));
        this.StatusProgress.DataBindings.Add(nameof(StatusProgress.Minimum), viewModelBase, nameof(viewModelBase.StatusProgressMinimum));
        this.StatusProgress.DataBindings.Add(nameof(StatusProgress.Style), viewModelBase, nameof(viewModelBase.StatusProgressStyle));
        this.StatusProgress.DataBindings.Add(nameof(StatusProgress.Visible), viewModelBase, nameof(viewModelBase.StatusProgressVisible));

        this.StatusLabel.DataBindings.Add(nameof(this.StatusLabel.Text), viewModelBase, nameof(viewModelBase.StatusLableText));

        this.UserInfoStatusLabel.DataBindings.Add(nameof(this.UserInfoStatusLabel.Text), viewModelBase, nameof(viewModelBase.UserInfoLableText));

#if DEBUG
        this.DebugModeStatusLabel.DataBindings.Add(nameof(this.DebugModeStatusLabel.Text), viewModelBase, nameof(viewModelBase.DebugModelStatusLabelText));
        viewModelBase.DebugModelStatusLabelText = "デバックモード";
#endif
    }

    protected void InitializeDataGridView(DataGridView dataGridView, FormViewModelBase gridViewModel)
    {
        dataGridView.CurrentCellChanged += (_, __) =>
        {
            gridViewModel.GridSelectedIndex =
            dataGridView.CurrentRow == null
            ? -1
            : dataGridView.CurrentRow.Index;
        };
    }

    protected void ShowPrintDialog()
    {
        PrintDialog printDialog = new();

        printDialog.ShowDialog();
    }
}
