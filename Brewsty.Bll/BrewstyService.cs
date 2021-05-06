using Brewsty.DataAccess;
using Brewsty.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Brewsty.Bll
{
    public class BrewstyService : IBrewstyService
    {
        private readonly IBrewstyContext _context;
        private readonly PunkAPI.IPunkAPI _api;
        public BrewstyService(IBrewstyContext context, PunkAPI.IPunkAPI api)
        {
            this._context = context;
            this._api = api;
        }
        public void Create(Beer beer)
        {
            //using (var buow = new BrewstyUnitOfWork(_context))
            //{
            //    buow.Beers.Add(beer);

            //    buow.Complete();
            //}
        }

        public async Task<Beer> ImportFromPunkAPI(int id, PunkAPI.BeerCastOptions options)
        {
            var punkyBeer = await this._api.Get(id);
            var beer = punkyBeer.ToEntity(options);
            beer.Id = Guid.NewGuid().ToString();
            foreach (var fd in beer.FoodPairing)
            {
                fd.Id = Guid.NewGuid().ToString();
            }
            await _context.Beers.AddAsync(beer);
            _context.SaveChanges();
            return beer;
        }
    }
}
