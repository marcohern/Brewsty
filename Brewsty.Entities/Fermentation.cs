using System;

namespace Brewsty.Entities
{
    public class Fermentation : Entity
    {
        public string MethodId { get; set; }
        public float TempValue { get; set; }
        public Unit TempUnit { get; set; }
    }
}