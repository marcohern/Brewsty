using Brewsty.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Brewsty.DataAccess
{
    public class BrewstyContext : DbContext, IBrewstyContext
    {
        public BrewstyContext(DbContextOptions<BrewstyContext> options) : base(options) { }
        public virtual DbSet<Beer> Beers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Beer beer = new Beer
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Aguila",
                Tagline = "",
                Description = "",
                Abv = 0.0f,
                Ibu = 0.0f,
                TargetFG = 0.0f,
                TargetOG = 0.0f,
                Ebc = 0.0f,
                Ph = 0.0f,
                ImageUrl = "",
                AttenuationLevel = 0.0f,
                FirstBrewed = new DateTime(2007, 4, 1),
                ContributedBy = "John Doe",
                VolumeValue = 0.0f,
                VolumeUnit = Unit.litres,
                BoilVolumeValue = 0.0f,
                BoilVolumeUnit = Unit.litres,
                BrewerTips = "",
            };
            List<FoodDescription> foodDescription = new List<FoodDescription>
            {
                new FoodDescription { Id=Guid.NewGuid().ToString(), BeerId=beer.Id , Description= "Lorem ipsum Dolor Sit Amet" }
            };

            Ingredients ingredients = new Ingredients
            {
                Id = Guid.NewGuid().ToString(),
                Yeast = "Blah Blah Blah"
            };
            List<Malt> malt = new List<Malt>
            {
                new Malt { Id=Guid.NewGuid().ToString(), IngredientId=ingredients.Id, Name = "Derp", AmountValue=0.0f, AmountUnit=Unit.grams }
            };
            List<Hop> hops = new List<Hop>
            {
                new Hop { Id=Guid.NewGuid().ToString(), IngredientId=ingredients.Id, Name="Dorp", AmountValue = 0.0f, AmountUnit=Unit.grams, Add="start", Attribute="glitter" }
            };
            Method method = new Method
            {
                Id = Guid.NewGuid().ToString(),
                BeerId = beer.Id,
                Twist = "Yaddah yaddah yaddah"
            };
            List<TempDuration> tempDuration = new List<TempDuration>
            {
                new TempDuration{Id=Guid.NewGuid().ToString(), MethodId=method.Id, Duration=4, TempValue=1.0f, TempUnit = Unit.celsius}
            };
            Fermentation fermentation = new Fermentation { Id = Guid.NewGuid().ToString(), MethodId = method.Id, TempValue = 3.0f, TempUnit = Unit.celsius };

            modelBuilder.Entity<Beer>().HasData(new[] { beer });
            modelBuilder.Entity<FoodDescription>().HasData(foodDescription);
            modelBuilder.Entity<Ingredients>().HasData(new[] { ingredients });
            modelBuilder.Entity<Malt>().HasData(malt);
            modelBuilder.Entity<Hop>().HasData(hops);
            modelBuilder.Entity<Method>().HasData(method);
            modelBuilder.Entity<TempDuration>().HasData(tempDuration);
            modelBuilder.Entity<Fermentation>().HasData(fermentation);
        }
    }
}