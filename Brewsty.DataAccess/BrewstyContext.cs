using Brewsty.Entities;
using Microsoft.EntityFrameworkCore;

namespace Brewsty.DataAccess
{
    public class BrewstyContext : DbContext
    {
        public BrewstyContext(DbContextOptions<BrewstyContext> options) : base(options) { }
        public virtual DbSet<Beer> Beers { get; set; }
        
    }
}