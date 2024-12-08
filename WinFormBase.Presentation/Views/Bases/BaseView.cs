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
        this.DebugStatusLabel.DataBindings.Add(nameof(this.DebugStatusLabel.Text), viewModelBase, nameof(viewModelBase.DebugStatusLabelText));

#if DEBUG
        viewModelBase.DebugStatusLabelText = "デバックモード";
#endif
    }
}
