using Brewsty.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brewsty.Bll
{
    public interface IBrewstyService
    {
        void Create(Beer beer);

        void ImportFromPunkAPI(int id);
    }
}
