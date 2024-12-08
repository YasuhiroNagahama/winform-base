namespace WinFormBase.Domain.Entities;

public sealed class TestEntity(int userId,
                               string userName,
                               string userEmail,
                               int userPhone,
                               string userPassword)
{
    public int UserId { get; } = userId;

    public string UserName { get; } = userName;

    public string UserEmail { get; } = userEmail;

    public int UserPhone { get; } = userPhone;

    public string UserPassword { get; } = userPassword;
}
