using System.Linq.Expressions;
using Brama.Repositories.Configuration;

namespace Brama.Repositories.Interfaces;

    public interface IGenericRepository<T> where T : class
    {
        Task <List<T>> Find(Expression<Func<T, bool>> predicate, FindOptions? findOptions = null);
        Task <T> Add(T entity);
        void Delete(Guid id);
        T Update(T entity);
    }
    