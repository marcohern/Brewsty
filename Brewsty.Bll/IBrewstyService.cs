using Brewsty.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Brewsty.Bll
{
    public interface IBrewstyService
    {
        void Create(Beer beer);

        Task<Beer> ImportFromPunkAPI(int id, PunkAPI.BeerCastOptions options);
    }
}
