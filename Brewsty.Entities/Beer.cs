using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewsty.Entities
{
    public class Beer: Entity
    {
        public string Name { get; set; }
        public string Tagline { get; set; }
        public DateTime FirstBrewed { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public float Abv { get; set; }
        public float Ibu { get; set; }
        public float TargetFG { get; set; }
        public float TargetOG { get; set; }
        public float Ebc { get; set; }
        public float Ph { get; set; }
        public float AttenuationLevel { get; set; }
        public UnitValue Volume { get; set; }
        public UnitValue BoilVolume { get; set; }
        public Method Method { get; set; }
        public Ingredients Ingredients { get; set; }
        public List<FoodDescription> FoodPairing { get; set; }
        public string BrewerTips { get; set; }
        public string ContributedBy { get; set; }
    }
}
