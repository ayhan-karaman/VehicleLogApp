using System.Linq.Expressions;
using VehicleLogApp.Entities.Contracts;
using VehicleLogApp.Repositories.Contracts;

namespace VehicleLogApp.Repositories.Concrete;

public class RepositoryBase<T> : IRepository<T>
where T : class, IEntity, new()
{
    
    public void Create(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> FindAll(bool trackingChanges)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackingChanges)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}