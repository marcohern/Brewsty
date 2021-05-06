using System;
using System.Collections.Generic;
using System.Text;

namespace Brewsty.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IBeerRepository Beers { get; }

        int Complete();
    }
}
