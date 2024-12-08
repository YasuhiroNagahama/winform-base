using Timer = System.Threading.Timer;

namespace WinFormBase.WinForm.BackgroundWorker;

internal static class LatestTimer
{
    private readonly static Timer s_timer = new(Callback);
    private static bool s_isWork = false;

    internal static void Start()
    {
        s_timer.Change(10000, 10000);
    }

    internal static void Stop()
    {
        s_timer.Change(Timeout.Infinite, Timeout.Infinite);
    }

    private static void Callback(object? o)
    {
        if(s_isWork)
        {
            return;
        }

        s_timer.Change(Timeout.Infinite, Timeout.Infinite);

        try
        {
            s_isWork = true;
        }
        finally
        {
            s_isWork = false;
        }
    }
}
