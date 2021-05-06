using Brewsty.DataAccess;
using Brewsty.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Brewsty.Bll
{
    public class BrewstyService : IBrewstyService
    {
        private IBrewstyContext _context;
        public BrewstyService(IBrewstyContext context)
        {
            this._context = context;
        }
        public void Create(Beer beer)
        {
            using (var buow = new BrewstyUnitOfWork(_context))
            {
                buow.Beers.Add(beer);

                buow.Complete();
            }
        }

        public async void ImportFromPunkAPI(int id)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://www.punkapi.com/beer/{id}");
            response.EnsureSuccessStatusCode();
            string jsonString = await response.Content.ReadAsStringAsync();

        }
    }
}
