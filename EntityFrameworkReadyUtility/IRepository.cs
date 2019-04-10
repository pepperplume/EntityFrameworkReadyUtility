using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EntityFrameworkReadyUtility
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Find(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindWhere(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
