using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Brewsty.DataAccess
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T model);
        void AddRange(IEnumerable<T> models);

        void Remove(T model);
        void RemoveRange(IEnumerable<T> models);
    }
}