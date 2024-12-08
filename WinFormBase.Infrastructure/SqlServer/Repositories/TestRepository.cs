using WinFormBase.Domain.Entities;
using WinFormBase.Domain.Repositories;

namespace WinFormBase.Infrastructure.SqlServer.Repositories;

internal sealed class TestRepository : ITestEntityRepository
{
    public TestEntity GetById(int id)
    {
        throw new NotImplementedException();
    }
}
