using WinFormBase.Domain.Entities;
using WinFormBase.Domain.Repositories;

namespace WinFormBase.Infrastructure.Fake;

internal sealed class TestRepositoryFake : ITestEntityRepository
{
    public TestEntity GetById(int id)
    {
        throw new NotImplementedException();
    }
}
