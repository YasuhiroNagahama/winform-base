using Microsoft.Data.SqlClient;
using WinFormBase.Domain.Entities;

namespace WinFormBase.Infrastructure.Factories;

internal static class EntityFactory
{
    internal static TestEntity CreateTestEntity(SqlDataReader reader)
    {
        return new TestEntity(reader.GetInt32(reader.GetOrdinal("UserId")),
                              reader.GetString(reader.GetOrdinal("UserName")),
                              reader.GetString(reader.GetOrdinal("UserEmail")),
                              reader.GetInt32(reader.GetOrdinal("UserPhone")),
                              reader.GetString(reader.GetOrdinal("UserPassword")));
    }
}
