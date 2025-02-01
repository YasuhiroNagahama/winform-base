using System.Collections;
using WinFormBase.Domain.Entities;
using WinFormBase.Domain.Repositories;

namespace WinFormBase.Domain.StaticValues;

public static class Tests
{
    private static List<TestEntity> _entities = [];

    public static void Create(ITestEntityRepository repository)
    {
        lock(((ICollection)_entities).SyncRoot)
        {
            _entities.Clear();

            _entities.AddRange(repository.GetAll());
        }
    }

    public static TestEntity? GetById(int id)
    {
        lock (((ICollection)_entities).SyncRoot)
        {
            return _entities.FirstOrDefault(entity => entity.UserId == id);
        }
    }
}
