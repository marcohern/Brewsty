using Brewsty.PunkAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Brewsty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrewstyController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public async Task<Beer> GetBeer(int id)
        {
            var api = new PunkAPI.PunkAPI(new HttpClient());
            return await api.Get(id);
        }
        [HttpGet]
        [Route("import/{id}")]
        public async Task<Entities.Beer> ImportBeer(int id)
        {
            BeerCastOptions options = BeerCastOptions.FromQueryString(Request.QueryString.Value);
            var api = new PunkAPI.PunkAPI(new HttpClient());
            var punkyBeer = await api.Get(id);
            var beer = Beer.FromPunky(punkyBeer, options);
            return beer;
        }

        [HttpGet]
        [Route("find")]
        public async Task<List<Beer>> FindBeer()
        {
            var api = new PunkAPI.PunkAPI(new HttpClient());
            return await api.Query(new Query { beer_name = "Brew" });
        }
    }
}
