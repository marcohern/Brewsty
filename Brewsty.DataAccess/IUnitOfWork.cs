using System;
using System.Collections.Generic;
using System.Text;

namespace Brewsty.DataAccess
{
    public interface IUnitOfWork
    {
        IBeerRepository Beers { get; }

        int Complete();
        void Dispose();
    }
}
