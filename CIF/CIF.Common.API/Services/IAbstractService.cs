using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CIF.Common.API.Services
{
    public interface IAbstractService<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(int pageIndex, int pageSize);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        IQueryable<T> GetQueryable();
    }
}
