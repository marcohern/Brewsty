using System;
using System.Collections.Generic;
using System.Text;

namespace Brewsty.DataAccess
{
    public class BrewstyUnitOfWork : IUnitOfWork
    {
        private readonly BrewstyContext _context;

        public BrewstyUnitOfWork(BrewstyContext context)
        {
            this._context = context;
        }

        public IBeerRepository Beers { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
