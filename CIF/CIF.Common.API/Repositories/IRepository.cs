using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CIF.Common.API.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(int pageIndex, int pageSize);
        IEnumerable<T> Find(Expression<Func<T, bool>> whereCondition);
        IQueryable<T> GetQueryable();

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void SaveChanges();
    }
}
