using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Brewsty.Entities
{
    public class Beer: Entity
    {
        public string Name { get; set; }
        public int SourceId { get; set; }
        public string Tagline { get; set; }
        public DateTime FirstBrewed { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public float? Abv { get; set; }
        public float? Ibu { get; set; }
        public float? TargetFG { get; set; }
        public float? TargetOG { get; set; }
        public float? Ebc { get; set; }
        public float? Ph { get; set; }
        public float? AttenuationLevel { get; set; }
        public float? VolumeValue { get; set; }
        public Unit? VolumeUnit { get; set; }
        public float BoilVolumeValue { get; set; }
        public Unit BoilVolumeUnit { get; set; }
        public Method Method { get; set; }
        public Ingredients Ingredients { get; set; }
        public IEnumerable<FoodDescription> FoodPairing { get; set; }
        public string BrewerTips { get; set; }
        public string ContributedBy { get; set; }
    }
}
