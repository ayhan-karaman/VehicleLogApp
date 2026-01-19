using System.Linq.Expressions;
using VehicleLogApp.Entities.Contracts;

namespace VehicleLogApp.Repositories.Contracts;
public interface IRepository<T>
where T : class, IEntity, new()
{
    IQueryable<T> FindAll(bool trackingChanges);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackingChanges);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    

}