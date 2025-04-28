using System.Linq.Expressions;
using Brama.Models;
using Brama.Repositories.Configuration;
using Brama.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Brama.Repositories.Implementation;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDBContext _dbContext;
    
    public GenericRepository(AppDBContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public T Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
        _dbContext.SaveChanges();
        return entity;
    }

    public async Task<T> Add(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public void Delete(Guid id)
    {
        var entity = _dbContext.Set<T>().Find(id);
        if (entity == null) return;
        _dbContext.Set<T>().Remove(entity);
        _dbContext.SaveChanges();
    }

    public async Task<List<T>> Find(Expression<Func<T, bool>> predicate, FindOptions? findOptions = null)
    {
        return await _dbContext.Set<T>().Where(predicate).ToListAsync();
    }
    
 
}
