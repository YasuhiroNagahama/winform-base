namespace WinFormBase.Services;

public interface IMessageBoxService
{
    void ShowConfirm(string message);
    void ShowError(string message);

    bool ShowWarning(string message);
}