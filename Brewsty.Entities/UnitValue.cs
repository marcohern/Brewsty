using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewsty.Entities
{
    public class UnitValue : Entity
    {
        public Unit Unit { get; set; }
        public float Value { get; set; }

        public UnitValue(float value, Unit unit)
        {
            this.Value = value;
            this.Unit = unit;
        }
    }
}
