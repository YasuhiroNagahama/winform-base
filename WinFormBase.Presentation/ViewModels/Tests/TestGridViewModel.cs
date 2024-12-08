using System.ComponentModel;
using WinFormBase.WinForm.Services;
using WinFormBase.WinForm.ViewModels.Bases;

namespace WinFormBase.WinForm.ViewModels.Tests;

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

    public override bool IsModifying()
    {
        throw new NotImplementedException();
    }
}
