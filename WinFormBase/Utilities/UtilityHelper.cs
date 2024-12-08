namespace WinFormBase.Utilities;

public static class UtilityHelper
{
    public static T? TryGetValue<T>(IList<T> values, int i)
    {
        return i >= 0 && values.Count > i ? values[i] : default;
    }
}