using System.Collections.Generic;

namespace Brewsty.Entities
{
    public class Ingredients : Entity
    {
        public List<Malt> Malt { get; set; }
        public List<Hop> Hops { get; set; }
        public string Yeast { get; set; }
    }
}