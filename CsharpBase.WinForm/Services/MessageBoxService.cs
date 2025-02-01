namespace WinFormBase.WinForm.Services;

public sealed class MessageBoxService : IMessageBoxService
{
    public void ShowConfirm(string message)
    {
        MessageBox.Show(message, "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ShowError(string message)
    {
        MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public bool ShowWarning(string message)
    {
        return MessageBox.Show(message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
    }
}
