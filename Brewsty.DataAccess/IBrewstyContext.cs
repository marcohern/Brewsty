using Brewsty.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brewsty.DataAccess
{
    public interface IBrewstyContext
    {
        DbSet<Beer> Beers { get; set; }

        int SaveChanges();
        void Dispose();
    }
}
