using WinFormBase.Domain.Exceptions;

namespace WinFormBase.Domain.Helpers;

public static class Guard
{
    public static void IsNull(object obj, string message)
    {
        if(obj == null)
        {
            throw new InputException(message);
        }
    }
}
