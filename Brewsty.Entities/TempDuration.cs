using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewsty.Entities
{
    public class TempDuration : Entity
    {
        public string MethodId { get; set; }
        public float TempValue { get; set; }
        public Unit TempUnit { get; set; }
        public float Duration { get; set; }
    }
}
