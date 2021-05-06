using Brewsty.Bll;
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
        //private IPunkAPI _api;
        private IBrewstyService _service;
        
        public BrewstyController(IBrewstyService service)
        {
            //this._api = api;
            this._service = service;
        }

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<Beer> GetBeer(int id)
        //{
        //    return await _api.Get(id);
        //}

        //[HttpGet]
        //[Route("importt/{id}")]
        //public async Task<Entities.Beer> ImportBeer(int id)
        //{
        //    BeerCastOptions options = BeerCastOptions.FromQueryString(Request.QueryString.Value);
        //    var beer = (await _api.Get(id)).ToEntity(options);
        //    return beer;
        //}

        [HttpGet]
        [Route("import/{id}")]
        public async Task<Entities.Beer> ImportAndSaveBeer(int id)
        {
            BeerCastOptions options = BeerCastOptions.FromQueryString(Request.QueryString.Value);
            return await this._service.ImportFromPunkAPI(id, options);
        }

        //[HttpGet]
        //[Route("find")]
        //public async Task<List<Beer>> FindBeer()
        //{
        //    return await _api.Query(new Query { beer_name = "Brew" });
        //}
    }
}
