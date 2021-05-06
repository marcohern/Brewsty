using System.Collections.Generic;

namespace Brewsty.Entities
{
    public class Ingredients : Entity
    {
        public IEnumerable<Malt> Malt { get; set; }
        public IEnumerable<Hop> Hops { get; set; }
        public string Yeast { get; set; }
    }
}