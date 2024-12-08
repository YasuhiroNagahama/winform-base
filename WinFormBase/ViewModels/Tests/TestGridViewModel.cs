using System.ComponentModel;
using WinFormBase.Presentation.Services;
using WinFormBase.Presentation.ViewModels.Bases;

namespace WinFormBase.Presentation.ViewModels.Tests;

public sealed class TestGridViewModel(int index, IMessageBoxService messageBoxService) : GridViewModelBase<TestGridViewModel>(index, messageBoxService)
{
    private string _userName = String.Empty;
    [DisplayName("ユーザー名")]
    public string UserName
    {
        get => this._userName;
        set => this.SetProperty(ref this._userName, value);
    }

    private string _userEmail = String.Empty;
    [DisplayName("メールアドレス")]
    public string UserEmail
    {
        get => this._userEmail;
        set => this.SetProperty(ref this._userEmail, value);
    }
}
