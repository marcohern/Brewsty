using System;

namespace Brewsty.Entities
{
    public class Malt : Entity
    {
        public string IngredientId { get; set; }
        public string Name { get; set; }
        public float AmountValue { get; set; }
        public Unit AmountUnit { get; set; }
    }
}