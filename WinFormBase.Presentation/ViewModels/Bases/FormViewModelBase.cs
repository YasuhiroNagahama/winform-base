using WinFormBase.Presentation.Services;

namespace WinFormBase.Presentation.ViewModels.Bases;

public abstract class FormViewModelBase(IMessageBoxService messageBoxService) : ViewModelBase
{
    protected readonly IMessageBoxService _messageBoxService = messageBoxService;

    public int GridSelectedIndex { get; set; }
    public int DisplayGridIndex => this.GridSelectedIndex + 1;

    private int _statusProgressValue;
    public int StatusProgressValue
    {
        get => this._statusProgressValue;
        set => this.SetProperty(ref this._statusProgressValue, value);
    }

    private int _statusProgressMaximum;
    public int StatusProgressMaximum
    {
        get => this._statusProgressMaximum;
        set => this.SetProperty(ref this._statusProgressMaximum, value);
    }

    private int _statusProgressMinimum;
    public int StatusProgressMinimum
    {
        get => this._statusProgressMinimum;
        set => this.SetProperty(ref this._statusProgressMinimum, value);
    }

    private bool _statusProgressVisible;
    public bool StatusProgressVisible
    {
        get => this._statusProgressVisible;
        set => this.SetProperty(ref this._statusProgressVisible, value);
    }

    private ProgressBarStyle _statusProgressStyle;
    public ProgressBarStyle StatusProgressStyle
    {
        get => this._statusProgressStyle;
        set => this.SetProperty(ref this._statusProgressStyle, value);
    }

    private string _statusLabelText = String.Empty;
    public string StatusLableText
    {
        get => this._statusLabelText;
        set => this.SetProperty(ref this._statusLabelText, value);
    }
}