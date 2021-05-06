using Brewsty.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Brewsty.DataAccess
{
    class BeerRepository : IBeerRepository
    {
        private IBrewstyContext _context;
        public BeerRepository(IBrewstyContext context)
        {
            this._context = context;
        }

        public void Add(Beer model)
        {
            this._context.Beers.Add(model);
        }

        public void AddRange(IEnumerable<Beer> models)
        {
            this._context.Beers.AddRange(models);
        }

        public IEnumerable<Beer> Find(Expression<Func<Beer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Beer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Beer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Beer model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Beer> models)
        {
            throw new NotImplementedException();
        }
    }
}
