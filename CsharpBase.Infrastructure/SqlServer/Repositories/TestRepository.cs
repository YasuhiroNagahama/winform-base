using WinFormBase.Domain.Entities;
using WinFormBase.Domain.Repositories;

namespace WinFormBase.Infrastructure.SqlServer.Repositories;

internal sealed class TestRepository : ITestEntityRepository
{
    private readonly IReadOnlyList<TestEntity> _entities = [];

    public IReadOnlyList<TestEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public TestEntity GetById(int id)
    {
        throw new NotImplementedException();
    }
}