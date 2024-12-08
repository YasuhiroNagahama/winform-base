using WinFormBase.Domain.Repositories;
using WinFormBase.Domain.StaticValues;
using WinFormBase.Infrastructure.Fake;
using WinFormBase.Infrastructure.SqlServer.Repositories;

namespace WinFormBase.Infrastructure.SqlServer.Services;

public sealed class RepositoryService : IRepositoryService
{
    private ITestEntityRepository? _testRepository;
    public ITestEntityRepository TestEntityRepository
    {
        get {
#if DEBUG
            if(Shared.IsFake)
            {
                return this._testRepository ??= new TestRepositoryFake();
            }
#endif

            return this._testRepository ??= new TestRepository();
        }
    }
}