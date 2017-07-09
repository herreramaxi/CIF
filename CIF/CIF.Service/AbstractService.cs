using CIF.Common.API.Repositories;
using CIF.Common.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIF.Services
{
    public abstract class AbstractService<T> : IAbstractService<T> where T : class
    {
        private IRepository<T> repository;

        public AbstractService(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return this.repository.GetAll();
        }

        public virtual IEnumerable<T> GetAll(int pageIndex, int pageSize)
        {
            return this.repository.GetAll(pageIndex, pageSize);
        }

        public IQueryable<T> GetQueryable()
        {
            return this.repository.GetQueryable();
        }

        public virtual IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return this.repository.Find(expression);
        }

        public T Get(int id)
        {
            return this.repository.Get(id);
        }
    }
}
