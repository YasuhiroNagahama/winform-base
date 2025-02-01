using WinFormBase.Domain.Entities;
using WinFormBase.WinForm.Services;

namespace WinFormBase.WinForm.ViewModels.Bases;

public abstract class FormViewModelBase(UserInfo loggedInUser, IMessageBoxService messageBoxService) : ViewModelBase
{
    protected readonly UserInfo _loggedInUser = loggedInUser;
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

    public string UserInfoLableText => $"ユーザー名 : {this._loggedInUser.UserName}";

    private string _debugLabelText = String.Empty;
    public string DebugModelStatusLabelText
    {
        get => this._debugLabelText;
        set => this.SetProperty(ref this._debugLabelText, value);
    }

    protected abstract bool IsModifying();
}