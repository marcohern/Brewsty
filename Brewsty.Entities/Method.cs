using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewsty.Entities
{
    public class Method
    {
        public int Id { get; set; }
        public List<TempDuration> MashTemp { get; set; }
        public Fermentation Fermentation { get; set; }
        public string Twist { get; set; }
    }
}
