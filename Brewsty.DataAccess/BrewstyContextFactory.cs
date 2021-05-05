using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brewsty.DataAccess
{
    public class BrewstyContextFactory
    {
        public static BrewstyContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BrewstyContext>();
            optionsBuilder.UseSqlServer(connectionString);

            // Ensure that the SQLite database and sechema is created!
            var context = new BrewstyContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}
