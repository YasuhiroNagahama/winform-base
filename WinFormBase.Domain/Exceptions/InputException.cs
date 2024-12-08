using WinFormBase.Domain.Exceptions.Bases;

namespace WinFormBase.Domain.Exceptions;

public sealed class InputException : ExceptionBase
{
    public InputException() : base() { }

    public InputException(string message) : base(message) { }

    public InputException(string? message, Exception? innerException) : base(message, innerException) { }

    public override ExceptionType ExceptionType => ExceptionType.Error;
}