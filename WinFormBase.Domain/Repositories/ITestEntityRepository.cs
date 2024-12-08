using WinFormBase.Domain.Entities;

namespace WinFormBase.Domain.Repositories;

public interface ITestEntityRepository
{
    TestEntity GetById(int id);

    IReadOnlyList<TestEntity> GetAll();
}
