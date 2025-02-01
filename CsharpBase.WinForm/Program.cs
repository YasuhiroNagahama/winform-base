using WinFormBase.WinForm.Utilities;
using WinFormBase.WinForm.Views.Tests;

namespace WinFormBase.WinForm;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Application.ThreadException += ExceptionHandler.HandleException;

        Application.Run(new TestView());
    }
}