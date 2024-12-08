using WinFormBase.Domain.Exceptions.Bases;

namespace WinFormBase.WinForm.Utilities;

public static class ExceptionHandler
{
    private static readonly Dictionary<ExceptionType, Action<string>> ExceptionActions = new()
    {
        { ExceptionType.Info, message => MessageBox.Show(message, "確認", MessageBoxButtons.OK, MessageBoxIcon.Information) },
        { ExceptionType.Warning, message => MessageBox.Show(message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning) },
        { ExceptionType.Error, message => MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error) }
    };

    public static void HandleException(object? _, ThreadExceptionEventArgs e)
    {
        if (e.Exception is ExceptionBase exceptionBase &&
            ExceptionActions.TryGetValue(exceptionBase.ExceptionType, out var action))
        {
            action(exceptionBase.Message);
        }
        else
        {
            MessageBox.Show(e.Exception.Message, "予期されていないエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}